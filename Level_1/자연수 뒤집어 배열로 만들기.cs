using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(long n)
    {
        int[] answer = new int[] { };

        List<int> intList = new List<int>();

        for (int i = 0; i < n.ToString().Length; ++i)
        {
            intList.Add(Convert.ToInt32(n.ToString()[n.ToString().Length - (i + 1)].ToString()));
        }
        // 정수형 변수 n을 문자로 바꾸어 정수형 리스트 끝부터 하나씩 리스트에 추가한다
        answer = intList.ToArray();
        // 리스트를 배열로 변형
        return answer;
    }
}