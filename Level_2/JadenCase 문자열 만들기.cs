using System;
using System.Text;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        StringBuilder builder = new StringBuilder();

        char[] charArray = s.ToCharArray();
        builder.Append(Char.ToUpper(charArray[0])); // 첫 자는 무조건 대문자

        for (int i = 0; i < charArray.Length - 1; ++i)
        {
            if (charArray[i] == ' ') // 공백이라면
            {
                builder.Append(Char.ToUpper(charArray[i + 1])); // 다음 글자는 대문자
            }
            else // 아니라면
            {
                builder.Append(Char.ToLower(charArray[i + 1])); // 다음 글자는 소문자
            }
        }
        answer = builder.ToString();
        return answer;
    }
}