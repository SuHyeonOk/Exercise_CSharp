using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Baekjoon
{
    class Program
    {
        enum Calculator
        {
            None = 0,
            Plus = 1,
            Minus = 2,
            Multiplication = 3,
            Division = 4,
            TheRest = 5,
            Min = 6,
            Max = 7
        }
        static int Plus(ref int a, ref int b)
        {
            return a + b;
        }
        static int Minus(ref int a, ref int b)
        {
            return a - b;
        }
        static int Multiplication(ref int a, ref int b)
        {
            return a * b;
        }
        static int Division(ref int a, ref int b)
        {
            return a / b;
        }
        static int TheRest(ref int a, ref int b)
        {
            return a % b;
        }
        static void Min()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"***{number}개의 숫자를 비교합니다***");
            int[] arr = new int[number];

            int result = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] < result)
                {
                    result = arr[i];
                }
            }
            Console.WriteLine($"*^^* 최소값은 {result}입니다 *^^*");
        }
        static void Max()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"***{number}개의 숫자를 비교합니다***");
            int[] arr = new int[number];

            int result = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] > result)
                {
                    result = arr[i];
                }
            }
            Console.WriteLine($"*^^* 최대값은 {result}입니다 *^^*");
        }

        static int EnterCalculator()
        {
            Console.WriteLine("+*********************************************+");
            Console.WriteLine("*               [1] 더하기                    *");
            Console.WriteLine("*               [2] 빼기                      *");
            Console.WriteLine("*               [3] 곱하기                    *");
            Console.WriteLine("*               [4] 나누기(몫)                *");
            Console.WriteLine("*               [5] 나누기(나머지)            *");
            Console.WriteLine("*               [6] 최소값                    *");
            Console.WriteLine("*               [7] 최대값                    *");
            Console.WriteLine("* 1 ~ 7 숫자 외 다른 숫자를 누르면 종료됩니다.*");
            Console.WriteLine("+*********************************************+");

            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int choice = EnterCalculator();

                if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5)
                {
                    Console.WriteLine("**************************************");
                    Console.WriteLine($"*        [{choice}] 입력하셨습니다         *");
                    Console.WriteLine($"* 계산할 두 개의 숫자를 입력하세요. *");
                    Console.WriteLine("**************************************");
                    Console.WriteLine();

                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());

                    switch ((Calculator)choice)
                    {
                        case Calculator.Plus:
                            int plus = Program.Plus(ref num1, ref num2);
                            Console.WriteLine($"*^^* 결과는 {plus} 입니다 *^^*");
                            Console.WriteLine();
                            break;
                        case Calculator.Minus:
                            int minus = Program.Minus(ref num1, ref num2);
                            Console.WriteLine($"*^^* 결과는 {minus} 입니다 *^^*");
                            Console.WriteLine();
                            break;
                        case Calculator.Multiplication:
                            int multiplication = Program.Multiplication(ref num1, ref num2);
                            Console.WriteLine($"*^^* 결과는 {multiplication} 입니다 *^^*");
                            Console.WriteLine();
                            break;
                        case Calculator.Division:
                            int division = Program.Division(ref num1, ref num2);
                            Console.WriteLine($"*^^* 결과는 {division} 입니다 *^^*");
                            Console.WriteLine();
                            break;
                        case Calculator.TheRest:
                            int therest = Program.TheRest(ref num1, ref num2);
                            Console.WriteLine($"*^^* 결과는 {therest} 입니다 *^^*");
                            Console.WriteLine();
                            break;
                    }
                }
                else if (choice == 6 || choice == 7)
                {
                    Console.WriteLine("**************************************");
                    Console.WriteLine($"*        [{choice}] 입력하셨습니다           *");
                    Console.WriteLine("*   몇 개의 숫자를 입력하시겠습니까?     *");
                    Console.WriteLine("**************************************");
                    Console.WriteLine();

                    if (choice == 6) // 최소값
                    {
                        Program.Min();
                    }
                    else if (choice == 7) // 최대값
                    {
                        Program.Max();
                    }
                }
                else
                {
                    Console.WriteLine("******프로그램을 종료합니다.******");
                    break;
                }
            }
        }
    }
}

