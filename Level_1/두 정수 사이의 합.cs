public class Solution
{
    public long solution(int a, int b)
    {
        long answer = 0;

        if (a > b) // a가 b보다 크다면 a와 b를 바꿔준다 (통일하기 위해서)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        for (int i = a; i <= b; i++)
        { answer += i; } // 작은 수 부터 큰 수까지 더하기 a 와 b 가 같다면 1번만 실행되어 a가 들어간다.

        return answer;
    }
}