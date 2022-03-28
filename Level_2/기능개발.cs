using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        int[] answer = new int[] { };
        int[] days = new int[progresses.Length];
        List<int> ans = new List<int>();
        int j = 0;

        for (int i = 0; i < days.Length; i++)
            days[i] = 0; // days 배열 초기화

        for (int i = 0; i < progresses.Length; i++)
        {
            while (progresses[i] < 100)
            {
                progresses[i] += speeds[i]; // 하루에 할 수 있는 속도
                days[i]++; // 하루 경화
            }
        }
        int count = 1;
        for (int i = 1; i < days.Length; i++)
        {
            if (days[0] >= days[i])
            { count++; } // 먼저 완성 되었다면 count++
            else
            {
                ans.Add(count); // 배포되는 개수 추가
                count = 1;
                days[0] = days[i]; // 앞으로 당긴다.
            }
        }
        ans.Add(count);

        answer = ans.ToArray(); // 배열로 변환
        return answer;
    }
}