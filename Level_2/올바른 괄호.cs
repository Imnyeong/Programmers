using System;

public class Solution
{
    public bool solution(string s)
    {
        bool answer = true;
        int count = 0;

        if (s[0] == ')' || s[s.Length - 1] == '(') // 시작이 닫는 괄호이거나 끝이 여는 괄호라면 false
        { return false; }

        for (int i = 0; i < s.Length; ++i)
        {
            if (count < 0)
                return false; // 열린 갯수보다 닫은 갯수가 많아지면 false
            if (s[i] == '(')
                count++;
            else
                count--;
        }

        answer = count == 0; // true가 되는 조건
        return answer;
    }
}