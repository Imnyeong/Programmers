using System;
using System.Collections.Generic;

public class Solution
{
    public long[] solution(int x, int n)
    {
        long[] answer = new long[n];

        for (int i = 0; i < n; ++i)
        {
            answer[i] = (long)x * (i + 1);
        }
        // 규칙대로 배열에 대입 long 배열에 int가 껴서 그런지 (long) 체크가 필요  
        return answer;
    }
}