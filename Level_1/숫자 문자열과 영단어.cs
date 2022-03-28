using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;
        String answerString = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].ToString() == "z") // zero의 경우
            { answerString += "0"; i = i + 3; }
            else if (s[i].ToString() == "o") // one의 경우
            { answerString += "1"; i = i + 2; }
            else if (s[i].ToString() == "t")
            {
                if (s[i + 1].ToString() == "w") // two의 경우
                { answerString += "2"; i = i + 2; }
                else // three의 경우
                { answerString += "3"; i = i + 4; }
            }
            else if (s[i].ToString() == "f")
            {
                if (s[i + 1].ToString() == "o") // four의 경우
                { answerString += "4"; i = i + 3; }
                else
                { answerString += "5"; i = i + 3; }
            }
            else if (s[i].ToString() == "s")
            {
                if (s[i + 1].ToString() == "i") // siz의 경우
                { answerString += "6"; i = i + 2; }
                else // seven의 경우
                { answerString += "7"; i = i + 4; }
            }
            else if (s[i].ToString() == "e") // eight의 경우
            { answerString += "8"; i = i + 4; }
            else if (s[i].ToString() == "n") // nine의 경우
            { answerString += "9"; i = i + 3; }
            else // 그 외의 경우 (= 숫자의 경우)
            { answerString += s[i].ToString(); }
        }

        answer = Int32.Parse(answerString);

        return answer;
    }
}