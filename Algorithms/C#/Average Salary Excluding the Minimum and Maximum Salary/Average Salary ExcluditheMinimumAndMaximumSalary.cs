/*Variant 1*/
public class Solution {
    public double Average(int[] salary) {
        int max = 0;
        int min = int.MaxValue;
        
        int sum = 0;
        
        for(int i = 0; i < salary.Length; i++){
            if(salary[i] > max) max = salary[i];
            if(salary[i] < min) min = salary[i];
            
            sum += salary[i];
        }
        
        sum -= max + min;
        
        return sum / (salary.Length - 2d);
    }
}

/*Variant 2*/
public class Solution {
    public double Average(int[] salary) {
        Array.Sort(salary);
        
        int length = salary.Length
        int sum = 0;
        
        for(int i = 1; i < len - 1; i++)
        {
            sum += salary[i];
        }
        
        return sum/(len - 2.0);
    }
}
