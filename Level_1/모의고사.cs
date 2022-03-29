using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] answers)
    {
        int[] answer = new int[3] { 0, 0, 0 }; // 답이 들어갈 배열
        List<int> answerList = new List<int>(); // 동적 사이즈를 위해 리스트로 구현 후 배열로 변경

        int[] count = new int[3]; // 정답 개수 배열
        // 각 수포자들의 답안
        int[] Person_1 = new int[5] { 1, 2, 3, 4, 5 };
        int[] Person_2 = new int[8] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] Person_3 = new int[10] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int max = 0; // 최대값

        count[0] = Check(answers, Person_1);
        count[1] = Check(answers, Person_2);
        count[2] = Check(answers, Person_3);

        if (count[0] == count[1] && count[1] == count[2]) // 모두 같다면
        { answer[0] = 1; answer[1] = 2; answer[2] = 3; } // 1, 2, 3 입력
        else
        {
            for (int i = 0; i < count.Length; i++) // 카운트의 길이 (3) 만큼 반복
            {
                if (max < count[i]) // 현재 정답 개수가 최대값 보다 크다면
                {
                    answerList.Clear(); // 이전까지 최고 기록자들 초기화
                    answerList.Add(i + 1); // 현재 수포자 리스트에 추가
                    max = count[i]; // 최대값 변경
                }
                else if (max == count[i]) // 최대값과 동일한 정답 개수라면
                { answerList.Add(i + 1); } // 현재 수포자 리스트에 추가
                else { } // 아니라면 동작 X
            }
            answer = answerList.ToArray(); // 만들어진 리스트를 배열로 출력
        }

        return answer;
    }

    public int Check(int[] answers, int[] Person) // 정답 개수 체크
    {
        int count = 0;
        int j = 0;

        for (int i = 0; i < answers.Length; i++) // 답안 배열의 끝까지 반복
        {
            if (j == Person.Length) // 끝까지 갔다면 다시 처음으로 반복
            { j = 0; }
            if (answers[i] == Person[j]) // 정답이라면
            { count++; } // count++
            j++;
        }
        return count;
    }
}