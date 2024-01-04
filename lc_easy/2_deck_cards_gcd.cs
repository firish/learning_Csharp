// Introduces array, dictionary, and function

// Link: https://leetcode.com/problems/x-of-a-kind-in-a-deck-of-cards/

public class Solution {
    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    
    public bool HasGroupsSizeX(int[] deck) {
        
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int card in deck) {
            if (!dict.ContainsKey(card)){
                dict.Add(card, 0);
            }
            dict[card]++;
        }
        
        int gcd = dict.Values.First();
        foreach (int count in dict.Values) {
            gcd = GCD(gcd, count);
            if (gcd == 1) {
                return false;
            }
        }
        return gcd > 1;
    }
}
