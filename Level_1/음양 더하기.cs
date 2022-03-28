using System;

public class Solution
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int answer = 0;

        for (int i = 0; i < absolutes.Length; i++) // absolutes 배열의 길이 만큼 반복
        {
            if (signs[i] == false) // i 번째 원소가 음수라면
            {
                absolutes[i] = absolutes[i] * -1; // -1을 곱해준다
            }
            answer += absolutes[i]; // 원소들의 합
        }

        return answer;
    }
}