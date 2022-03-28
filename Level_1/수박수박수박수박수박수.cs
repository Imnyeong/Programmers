using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(int n)
    {
        string answer = "";
        List<String> str = new List<String>();

        for (int i = 1; i <= n; i++) // n 번 반복
        {
            if (i % 2 == 1) // 홀수의 경우
            { str.Add("수"); }
            else // 짝수의 경우
            { str.Add("박"); }
        }
        answer = String.Join("", str.ToArray()); // "" 추가

        return answer;
    }
}