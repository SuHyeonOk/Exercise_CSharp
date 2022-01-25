using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_simple
{
    class Program
    {
        // 입력받은 16진수를 10진수로 변경하기
        static int GetHighestScore(int[] scores)
        {
            string number = Console.ReadLine();
            //int number2 = int.Parse(Console.ReadLine());
            int[] arr = new int[number.Length];

            int temp = 1;
            int[] calculate = new int[number.Length];
            int result = 0;

            for (int i = 0; i < number.Length; i++) // arr 배열크기 만큼 도는 for문
            {
                    arr[i] = int.Parse(number[i].ToString()); // arr 배열에 입력한 number하나씩 잘라서 넣기           
            }

            int num = number.Length - 1;
            for (int i = 0; i < number.Length; i++) // 하나씩 들어가진 배열 값 계산하기
            {
                for (int j = 0; j < num; j++)
                {
                    temp *= 16;
                }
                calculate[i] = temp * arr[i];
                temp = 1;
                num--;
            }

            for (int i = 0; i < number.Length; i++)
            {
                result += calculate[i];
            }
            Console.WriteLine($"0X{result}");
    }
}
