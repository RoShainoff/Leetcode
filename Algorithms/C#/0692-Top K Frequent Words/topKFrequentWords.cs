//-----------------------------------------------------------------------------
// Runtime: 304ms
// Memory Usage: 46.7 MB
// Link: https://leetcode.com/submissions/detail/826078414/
//-----------------------------------------------------------------------------

public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        var dictionary = new Dictionary<string, int>();
        
        foreach(var word in words){
            if(!dictionary.ContainsKey(word)){
                dictionary.Add(word, 0);
            }
            else{
                dictionary[word]++;
            }
        }
        
        return dictionary
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .Take(k)
            .Select(x => x.Key).ToList();
    }
}
