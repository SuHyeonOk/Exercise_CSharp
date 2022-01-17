using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 전화번호부 만들기
    삭제, 추가, 수정이 가능하도록*/
namespace PhoneBook
{
    class Program
    {
        static string[] name = new string[100];
        static int[] number = new int[100];

        static public string _name = "";
        static int _number = 0;

        enum PhoneBook
        {
            None,
            Input,
            Correction,
            Addition,
            Delete
        }

        static void Input()
        {
            Console.WriteLine(" 찾고싶은 전화번호 이름을 입력해주세요.");
            string find = Console.ReadLine();

            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                j = _name[i];
            }

            if (find == name[j])
            {
                Console.WriteLine($"{_number} 입니다");
            }
            else
            {
                Console.WriteLine(" 찾으시는 이름의 전화번호가 없습니다");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*---             전화번호부            ---*");
            Console.WriteLine("*--- 최대 100개의 전화번호가 저장됩니다 ---*");
            Console.WriteLine("*--- 1. 전화번호 찾기                  ---*");
            Console.WriteLine("*--- 2. 이름, 전화번호 수정하기        ---*");
            Console.WriteLine("*--- 3. 전화번호 추가하기              ---*");
            Console.WriteLine("*--- 4. 전화번호 삭제하기              ---*");

            int input = int.Parse(Console.ReadLine());

            switch ((PhoneBook)input)
            {
                case PhoneBook.Input:
                    Input();
                    break;

            }
        }
    }
}
