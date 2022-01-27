using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_simple
{
    class Program
    {
         // 10진수를 16진수로 바꾸기
        static void Main(string[] args)
        {
            int number = 25415;
            int result = number; // 몫
            int result2 = 0; // 나머지

            // number가 16보다 작아질때 까지 반복한다
            while (true)
            {
                if (result > 16) // number에서 16을 나눈 것이 16보다 크니?
                {
                    result2 = result % 16;
                    result = result / 16;

                    Console.WriteLine(result2);

                    if(result < 16)
                      Console.WriteLine(result);
                }
                else
                    break;
            }
    }
}
