//-----------------------------------------------------------------------------
// Runtime: 119ms
// Memory Usage: 51.8 MB
// Link: https://leetcode.com/submissions/detail/826100229/
//-----------------------------------------------------------------------------

public class Solution {
    public int NumIslands(char[][] grid) {
        int result = 0;
        int[] dx = new int[] { 1, -1, 0, 0 },
              dy = new int[] { 0, 0, 1, -1 };
        
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
                if (grid[i][j] == '1')
                {
                    result++;
                    
                    Queue<int[]> queue = new Queue<int[]>();
                    
                    queue.Enqueue(new int[] { i, j });
                    grid[i][j] = 'N';
                    
                    while (queue.Count > 0)
                    {
                        int[] cur = queue.Dequeue();
                        
                        for (int k = 0; k < 4; k++)
                        {
                            int newX = cur[0] + dx[k],
                                newY = cur[1] + dy[k];
                            
                            if (newX > -1 && newX < grid.Length && newY > -1 && newY < grid[0].Length && grid[newX][newY] == '1')
                            {
                                queue.Enqueue(new int[] { newX, newY });
                                grid[newX][newY] = 'N';
                            }
                        }
                    }
                }
        
        return result;
    }
}
