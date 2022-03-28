using System;
using System.Linq;

public class Solution
{
    public int solution(int[] numbers)
    {
        int answer = 0;
        int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 있어야할 숫자들, 0은 합에 영향 없으므로 필요 없음

        for (int i = 0; i < num.Length; i++)
        {
            if (!numbers.Contains(num[i])) // number에 없는 숫자들
            {
                answer += num[i]; // 답에 더한다.
            }
        }
        return answer;
    }
}