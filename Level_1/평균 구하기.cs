public class Solution
{
    public double solution(int[] arr)
    {
        double answer = 0;

        for (int i = 0; i < arr.Length; ++i)
        {
            answer += arr[i]; // 모든 합 더하기
        }
        answer /= arr.Length; // 개수 만큼 더한다

        return answer;
    }
}