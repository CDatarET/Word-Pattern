class Solution(object):
    def wordPattern(self, pattern, s):
        """
        :type pattern: str
        :type s: str
        :rtype: bool
        """
        alps = list(pattern)
        strs = s.split()
        if(len(alps) != len(strs)):
            return(False)

        d = {}
        for i in range(len(alps)):
            if(alps[i] not in d):
                if(strs[i] in d.values()):
                    return(False)
                d[alps[i]] = strs[i]
            else:
                if(d[alps[i]] != strs[i]):
                    return(False)

        return(True)
