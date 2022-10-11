public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;

        var map = new Dictionary<char, char>(26);
        var visited = new HashSet<char>(26);
        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                if (map[s[i]] != t[i]) return false;
            }
            else
            {
                if (visited.Contains(t[i])) return false;
                map.Add(s[i], t[i]);
                visited.Add(t[i]);
            }
        }
        
        return true;
    }
}
