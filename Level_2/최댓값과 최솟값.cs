using System.Collections.Generic;
using System;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        string[] words = s.Split(' '); // 띄어쓰기 마다 하나 씩 분리

        List<int> numberList = new List<int>();

        foreach (string word in words)
        {
            numberList.Add(Convert.ToInt32(word)); // int형 리스트로 변환
        }

        numberList.Sort(); // 크기 순으로 정렬

        answer = $"{numberList[0]} {numberList[numberList.Count - 1]}"; // 최소, 최대값을 출력
        return answer;
    }
}