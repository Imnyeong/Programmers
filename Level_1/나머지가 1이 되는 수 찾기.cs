using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int maxNum = 1000000; // 최대 범위

        while (answer < maxNum)
        {
            answer++;
            if (n % answer == 1) // 탈출 조건
                break;
        }
        return answer;
    }
}