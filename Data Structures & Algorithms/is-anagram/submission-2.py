class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        s = s.strip()
        t = t.strip()

        if len(s) != len(t):
            return False
        
        return sorted(s) == sorted(t)