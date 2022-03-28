using System.Linq;
using System;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        int len = s.Length;
        int pos;
        Char[] str = new Char[s.Length]; // 문자열을 문자 배열로 변환
        str = s.ToArray();

        if (len % 2 == 1) // 문자열의 길이가 홀수라면
        {
            pos = len / 2; // 반으로 나눈 후
            answer = str[pos].ToString(); // 중앙 값 입력
        }
        else
        { // 짝수라면
            pos = len / 2; // 반으로 나눈 후

            answer = str[pos - 1].ToString() + str[pos].ToString(); // 중앙 두 개의 값 입력
        }

        return answer;
    }
}