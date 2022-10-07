﻿public class Solution
{
    public int solution(int n)
    {
        int answer = 0;

        for (int i = 1; i <= n; ++i)
        {
            if (n % i == 0) // 약수를 찾는 조건 == 나머지가 0
                answer += i;
        }

        return answer;
    }
}