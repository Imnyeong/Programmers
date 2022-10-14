using System;

public class Solution
{
    public long solution(long n)
    {
        long answer = 0;

        char[] charArrN = n.ToString().ToCharArray();
        // 정수형 n 을 string 으로 변환 후 그 string 을 char 형의 array로 변환
        Array.Sort(charArrN);
        Array.Reverse(charArrN);
        // 정렬 후 뒤집기
        answer = Convert.ToInt64(new string(charArrN));
        // char array를 string으로 변환 후 ToInt64 ( = long ) 형태로 변환하여 answer에 대입
        return answer;
    }
}