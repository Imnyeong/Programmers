public class Solution
{
    public string solution(int num)
    {
        string answer = "";

        if (num % 2 == 0) // 짝수일 경우
        { answer = "Even"; }
        else // 홀수일 경우
        { answer = "Odd"; }
        return answer;
    }
}