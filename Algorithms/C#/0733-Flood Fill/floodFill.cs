//-----------------------------------------------------------------------------
// Runtime: 154ms
// Memory Usage: 45.7 MB
// Link: https://leetcode.com/submissions/detail/826573621/
//-----------------------------------------------------------------------------

public class Solution {
    
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        int original = image[sr][sc];
        
        if(original == color)
            return image;
        
        DFS(image, sr, sc, original, color);
        
        return image;
    }
    
    public void DFS(int[][] image, int i, int j, int curr, int target){
        if(i < 0 || i >= image.Length || j < 0 || j >= image[0].Length || image[i][j] != curr)
            return;
        
        image[i][j] = target;
                        
        DFS(image, i-1, j, curr, target);
        DFS(image, i+1, j, curr, target);
        DFS(image, i, j-1, curr, target);
        DFS(image, i, j+1, curr, target);
    }
}
