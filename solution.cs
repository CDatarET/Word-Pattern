public class Solution {
    public bool WordPattern(string pattern, string s) {
        char[] alps = pattern.ToCharArray();
        string[] strs = s.Split(" ");

        if(alps.Length != strs.Length){
            return(false);
        }

        Dictionary<char, string> d = new Dictionary<char, string>();
        for(int i = 0; i < alps.Length; i++){
            if(!d.ContainsKey(alps[i])){
                if(d.ContainsValue(strs[i])){
                    return(false);
                }
                d.Add(alps[i], strs[i]);
            }
            else{
                if(d[alps[i]] != strs[i]){
                    return(false);
                }
            }
        }
        return(true);
    }
}
