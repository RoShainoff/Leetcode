//-----------------------------------------------------------------------------
// Runtime: 58ms
// Memory Usage: 24.9 MB
// Link: https://leetcode.com/submissions/detail/826575031/
//-----------------------------------------------------------------------------

public class Solution {
    public int Fib(int n) {
        if(n <= 1) return n;
        
        return Fib(n - 1) + Fib(n - 2);
    }
}
