using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] citations)
    {
        int answer = 0;

        Array.Sort(citations); // 오름차순 정렬

        for (int i = 0; i <= citations[citations.Length - 1]; i++) // 가장 큰 인용 횟수만큼
        {
            if (Array.Exists(citations, x => x == i)) // 배열 내에 있는 숫자만 체크
            {
                int count = 0;
                for (int j = 0; j < citations.Length; j++) // 배열 끝까지 탐색
                {
                    if (citations[j] >= i) // h 번 이상 인용되었다면
                    { count++; } // 인용된 논문 1편 추가              
                }
                Console.WriteLine("count = " + count.ToString());
                if (i >= count && count > answer) // h번 인용된 논문의 수가 h 개 이상이면서 이전 최대값보다 크다면
                { answer = count; } // 최대값 변경
            }
        }
        return answer;
    }
}