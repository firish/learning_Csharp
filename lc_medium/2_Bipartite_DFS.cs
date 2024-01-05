// Bipartite Graph
// Many new concepts - fucntions, recurrsion, tertiary operator

// Link: https://leetcode.com/problems/is-graph-bipartite/

// My soln
public class Solution {
    
    public bool dfs(int node, int color, int[] colors, int[][] graph){
        colors[node] = color;
        
        int next_color = color == 0 ? 1 : 0;
        foreach (int nbr in graph[node]){
            if (colors[nbr] == -1) {
                bool bipartite = dfs(nbr, next_color, colors, graph);
                if (! bipartite) {
                    return false;
                }
            }
            else if (colors[nbr] == color){
                return false;
            }
        }
        return true;
    }
    
    public bool IsBipartite(int[][] graph) {
        int n = graph.Length;
        int[] colors = Enumerable.Repeat(-1, n).ToArray();
        foreach (int node in Enumerable.Range(0, n)){
            if (colors[node] == -1){
                colors[node] = 0;
                bool bipartite = dfs(node, 0, colors, graph);
                if (! bipartite){
                    return false;
                }
            }
        }
        return true;
    }
}
