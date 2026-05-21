class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        result = []
        for i,x in enumerate(temperatures):
            flag = False
            for j in range(i + 1, len(temperatures)):
                if temperatures[j] > x and not flag:
                    result.append(j - i)
                    flag = True
            if len(result) < i + 1:
                result.append(0)
        return result