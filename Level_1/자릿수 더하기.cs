using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        string strN = n.ToString(); // 문자열로 전환

        for (int i = 0; i < strN.Length; ++i)
        {
            answer += Int32.Parse(strN[i].ToString()); // 자리 수 별로 answer에 더한다
        }

        return answer;
    }
}