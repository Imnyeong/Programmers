using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        s = Console.ReadLine().Split(' '); // 띄어쓰기로 구분

        int a = Int32.Parse(s[0]); // 정수형 변환
        int b = Int32.Parse(s[1]);

        for (int i = 0; i < b; i++)
        {
            for (int j = 0; j < a; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }
    }
}