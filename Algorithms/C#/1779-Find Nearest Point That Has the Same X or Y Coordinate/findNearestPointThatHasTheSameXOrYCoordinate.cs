//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 60 MB
// Link: https://leetcode.com/submissions/detail/821558881/
//-----------------------------------------------------------------------------

public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
        
        var minValue = int.MaxValue;
        var minIndex = -1;
               
        for(int i = 0; i < points.Length; i++){
            
            var point = points[i];
            
            if(point[0] == x || point[1] == y)
            {  
                var dist = Math.Abs(x - point[0]) +  Math.Abs(y - point[1]);
                
                if(dist == 0){
                    return i;
                }
                
                if(dist < minValue){
                    minValue = dist;
                    minIndex = i;
                }
            }
        }
        
        return minIndex;
    }
}
