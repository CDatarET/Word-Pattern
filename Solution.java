class Solution {
    public boolean wordPattern(String pattern, String s) {
        char[] alps = pattern.toCharArray();
        String[] strs = s.split(" ");

        if(alps.length != strs.length){
            return(false);
        }

        HashMap<Character, String> map = new HashMap<Character, String>();
        for(int i = 0; i < alps.length; i++){
            if(map.get(alps[i]) == null){
                if(map.containsValue(strs[i])){
                    return(false);
                }
                map.put(alps[i], strs[i]);
            }
            else{
                if(map.get(alps[i]).compareTo(strs[i]) != 0){
                    return(false);
                }
            }
        }
        return(true);
    }
}
