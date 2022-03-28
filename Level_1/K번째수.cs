using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer = new int[] { };
        List<int> answerList = new List<int>();

        for (int i = 0; i < commands.GetLength(0); i++) // 2차원 배열 길이만큼 반복
        {
            List<int> tempList = new List<int>(); // 임시 리스트
            for (int j = commands[i, 0] - 1; j < commands[i, 1]; j++) // i번째부터 j번째 원소까지 리스트로 구현
            {
                tempList.Add(array[j]);
            }
            tempList.Sort(); // 임시 리스트 정렬
            answerList.Add(tempList[commands[i, 2] - 1]); // k번째의 수 구하기
        }
        answer = answerList.ToArray(); // 리스트를 배열로
        return answer;
    }
}