public class Solution {
    public int SubtractProductAndSum(int n)
    {
        var sum = 0;
        var product = 1;
        
        while (n > 0)
        {
            var value = n % 10;
            sum += value;
            product *= value;
            n /= 10;
        }
        
        return product - sum;
    }
}
