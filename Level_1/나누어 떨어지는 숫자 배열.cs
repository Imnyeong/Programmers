using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[] {};
        List<int> ansList = new List<int>();
        
        for(int i = 0 ; i < arr.Length ; ++i)
        {
            if(arr[i] % divisor == 0)
            {
                ansList.Add(arr[i]);
            }           
        }
        
        if(ansList.Count == 0)
        {
            ansList.Add(-1);
        }
        
        ansList.Sort();
        answer = ansList.ToArray();
            
        return answer;
    }
}