using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[] { };
        List<int> ans = new List<int>();
        int k = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                k = numbers[i] + numbers[j]; // 두 개 뽑아서 나오는 모든 수
                ans.Add(k);
            }
        }
        ans.Sort(); // 리스트 정렬
        ans = ans.Distinct().ToList(); // 중복 제거

        answer = ans.ToArray(); // 배열로 변환

        return answer;
    }
}