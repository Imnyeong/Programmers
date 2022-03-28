using System;

public class Solution
{
    public int solution(int[] a, int[] b)
    {
        int answer = 0;

        for (int i = 0; i < a.Length; i++)
        {
            answer += a[i] * b[i]; // a 의 i 번째 원소와 b 의 i 번째 원소를 곱한 값을 answer에 더한다.
        }

        return answer;
    }
}