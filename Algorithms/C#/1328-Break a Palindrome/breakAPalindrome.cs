public class Solution {
    public string BreakPalindrome(string palindrome) {
               
        if(palindrome.Length <= 1) return string.Empty;
        
        var last = palindrome.Length - 1;
        
        char[] charArr = palindrome.ToCharArray();
		
        bool isAllIsA = true;
        
        for(int i = 0; i < palindrome.Length / 2; i++){
            if(charArr[i] != 'a'){ 
                isAllIsA = false;
                charArr[i] = 'a';
                break;
            }
        }
        
        if(isAllIsA) charArr[last] = 'b';
        
        return new string(charArr);
    }
}
