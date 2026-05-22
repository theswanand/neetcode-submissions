class Solution:
    def isValid(self, s: str) -> bool:
        seen = []

        for ch in s:
            if ch in "({[":
                seen.append(ch)
            else:
                if not seen:
                    return False

                top = seen.pop()

                if ch == ')' and top != '(':
                    return False
                if ch == ']' and top != '[':
                    return False
                if ch == '}' and top != '{':
                    return False

        return len(seen) == 0