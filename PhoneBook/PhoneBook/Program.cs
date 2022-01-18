using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 전화번호부 만들기
    삭제, 추가, 수정이 가능하도록*/
//1
namespace PhoneBook
{
    class Program
    {
        static string[] name = new string[100];
        static int[] phoneNumber = new int[100];

        static int _number = 101;

        enum PhoneBook
        {
            None,
            Find,
            Addition,
            Correction,
            Delete
        }
        static void Sign()
        {
            Console.WriteLine("\n" + "*---             전화번호부             ---*");
            Console.WriteLine("*--- 최대 100개의 전화번호가 저장됩니다 ---*");
            Console.WriteLine("*--- 1. 전화번호부 검색하기             ---*");
            Console.WriteLine("*--- 2. 이름 + 전화번호 추가하기        ---*");
            Console.WriteLine("*--- 3. 이름 + 전화번호 수정하기        ---*");
            Console.WriteLine("*--- 4. 이름 + 전화번호 삭제하기        ---*" + "\n");
        }
        static void Find()
        {
            Console.WriteLine("*--- 1. 전화번호부 검색하기 ---*");
            Console.WriteLine("1. 이름으로 찾고 싶어요.");
            Console.WriteLine("2. 전화번호로 찾고 싶어요.");           
            int find = int.Parse(Console.ReadLine());

            if(find == 1) // 이름으로 찾기
            {
                Console.WriteLine(" *이름으로 전화번호 찾기입니다.");
                Console.WriteLine(" *찾으실 전화번호 이름을 입력해주세요.");
                string findName = Console.ReadLine();

                for (int i = 0; i < 100; i++)
                {
                    if(findName == name[i])
                    {
                        _number = i;
                    }
                }
                if (findName == name[_number])
                {
                    Console.WriteLine($"*{name[_number]}*님의 전화번호는");
                    Console.WriteLine($"*{phoneNumber[_number]}* 입니다");
                }
                else if (findName != null)
                {
                    Console.WriteLine(" *입력하신 이름에 저장된 전화번호가 없습니다.");
                }
            }
            else if(find == 2) // 전화번호로 찾기
            {
                Console.WriteLine(" *전화번호로 이름찾기 입니다.");
                Console.WriteLine(" *찾으실 이름의 전화번호를 입력해주세요.");
                int findPhoneNumber = int.Parse(Console.ReadLine());

                for (int i = 0; i < 100; i++)
                {
                    if (findPhoneNumber == phoneNumber[i])
                    {
                        _number = i;
                    }
                }
                if (findPhoneNumber == phoneNumber[_number])
                {
                    Console.WriteLine($"{name[_number]}님의 전화번호는");
                    Console.WriteLine($"{phoneNumber[_number]} 입니다");
                }
                else if(findPhoneNumber != phoneNumber[_number])
                {
                    Console.WriteLine(" *입력하신 전화번호에 저장된 전화번호가 없습니다.");
                }
            }
            else
            {
                Console.WriteLine(" *숫자를 잘못 입력하셨습니다.");
            }
        }

        static void Addition()
        {
            Console.WriteLine("*--- 2. 이름 + 전화번호 추가하기 ---*");
            Console.WriteLine(" *추가할 이름을 입력해주세요.");
            string AddName = Console.ReadLine();

            for(int i = 0; i < 100; i++)
            {
                if(name[i] == null)
                {
                    name[i] = AddName;
                    _number = i;
                }
            }

            Console.WriteLine(" *추가할 전화번호를 입력해주세요.");
            int AddPhoneNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < 100; i++)
            {
                if (phoneNumber[i] == 0)
                    phoneNumber[i] = AddPhoneNumber;
            }

            Console.WriteLine($"입력하신 *{name[_number]}*님의 전화번호");
            Console.WriteLine($"*{phoneNumber[_number]}*이 추가되었습니다");
        }

        static void Correction()
        {
            Console.WriteLine("*--- 3. 이름 + 전화번호 수정하기 ---*");
            Console.WriteLine("1. 이름으로 수정 싶어요");
            Console.WriteLine("2. 전화번호로 수정 싶어요");
            int correction = int.Parse(Console.ReadLine());

            if (correction == 1) // 이름으로 수정
            {
                Console.WriteLine(" *이름으로 전화번호 수정하기입니다.");
                Console.WriteLine(" *수정하실 전화번호 이름을 입력해주세요.");
                string findName = Console.ReadLine();

                for (int i = 0; i < 100; i++)
                {
                    if (findName == name[i])
                    {
                        _number = i;
                    }
                }
                if (findName == name[_number])
                {
                    Console.WriteLine($"{name[_number]}님의 이름 + 전화번호를 수정합니다");
                    Console.WriteLine(" *수정할 이름을 입력해주세요.");
                    string correctionName = Console.ReadLine();
                    name[_number] = correctionName;

                    Console.WriteLine(" *수정할 전화번호를 입력해주세요.");
                    int correctionPhoneNumber = int.Parse(Console.ReadLine());
                    phoneNumber[_number] = correctionPhoneNumber;

                    Console.WriteLine($"수정된 이름은 *{name[_number]}* 입니다");
                    Console.WriteLine($"수정된 전화번호는 *{phoneNumber[_number]}* 입니다");

                    _number = 101;
                }
                else
                {
                    Console.WriteLine(" *입력하신 이름의 저장되어있는 전화번호가 없습니다.");
                }
            }
            else if (correction == 2) // 전화번호로 수정
            {
                Console.WriteLine(" *전화번호로 이름 수정하기 입니다.");
                Console.WriteLine(" *수정하실 이름의 전화번호를 입력해주세요.");
                int findPhoneNumber = int.Parse(Console.ReadLine());

                for (int i = 0; i < 100; i++)
                {
                    if (findPhoneNumber == phoneNumber[i])
                    {
                        _number = i;
                    }
                }
                if (findPhoneNumber == phoneNumber[_number])
                {
                    Console.WriteLine($"{phoneNumber[_number]}님의 이름 + 전화번호를 수정합니다");
                    Console.WriteLine(" *수정할 이름을 입력해주세요.");
                    string correctionName = Console.ReadLine();
                    name[_number] = correctionName;

                    Console.WriteLine(" *수정할 전화번호를 입력해주세요.");
                    int correctionPhoneNumber = int.Parse(Console.ReadLine());
                    phoneNumber[_number] = correctionPhoneNumber;

                    Console.WriteLine($"수정된 이름은 *{name[_number]}* 입니다");
                    Console.WriteLine($"수정된 전화번호는 *{phoneNumber[_number]}* 입니다");

                    _number = 101;
                }
                else
                {
                    Console.WriteLine(" *입력하신 전화번호의 저장되어있는 이름이 없습니다.");
                }
            }
            else
            {
                Console.WriteLine(" *숫자를 잘못 입력하셨습니다.");
            }
        }

        static void Delete()
        {
            Console.WriteLine("*--- 4. 이름 + 전화번호 삭제하기 ---*");
            Console.WriteLine("1. 이름으로 삭제하고 싶어요.");
            Console.WriteLine("2. 전화번호로 삭제하고 싶어요.");
            int find = int.Parse(Console.ReadLine());

            if (find == 1) // 이름으로 삭제
            {
                Console.WriteLine(" *이름으로 이름 + 전화번호 삭제하기 입니다.");
                Console.WriteLine(" *삭제하고 싶은 이름을 입력해주세요.");
                string findName = Console.ReadLine();

                for (int i = 0; i < 100; i++)
                {
                    if (findName == name[i])
                    {
                        _number = i;
                    }
                }
                if (findName == name[_number])
                {
                    Console.WriteLine($"정말로 {findName}님의 이름 + 전화번호를 삭제하시겠습니까?");
                    Console.WriteLine("1. 네");
                    Console.WriteLine("2. 아니요");
                    int really = int.Parse(Console.ReadLine());

                    if (really == 1)
                    {
                        name[_number] = null;
                        phoneNumber[_number] = 0;
                        Console.WriteLine($"이름이 {findName}님이신 이름 + 전화번호를 삭제합니다.");

                        _number = 101;
                    }
                    else if(really == 2)
                    {
                        Console.WriteLine(" *삭제를 취소합니다");
                    }
                    else
                    {
                        Console.WriteLine(" *숫자를 잘못입력 하셨습니다");
                    }
                }
                else
                {
                    Console.WriteLine(" *입력하신 이름에 삭제할 이름 + 전화번호가 없습니다.");
                }
            }
            else if (find == 2) // 전화번호로 삭제
            {
                Console.WriteLine(" *전화번호로 이름 + 전화번호 삭제하기 입니다.");
                Console.WriteLine(" *삭제하실 전화번호를 입력해주세요.");
                int findPhoneNumber = int.Parse(Console.ReadLine());

                for (int i = 0; i < 100; i++)
                {
                    if (findPhoneNumber == phoneNumber[i])
                    {
                        _number = i;
                    }
                }
                if (findPhoneNumber == phoneNumber[_number])
                {
                    Console.WriteLine($"정말로 {findPhoneNumber}님의 이름 + 전화번호를 삭제하시겠습니까?");
                    Console.WriteLine("1. 네");
                    Console.WriteLine("2. 아니요");
                    int really = int.Parse(Console.ReadLine());

                    if (really == 1)
                    {
                        name[_number] = null;
                        phoneNumber[_number] = 0;
                        Console.WriteLine($"전화번호가 {findPhoneNumber}님이신 이름 + 전화번호를 삭제합니다.");

                        _number = 101;
                    }
                    else if (really == 2)
                    {
                        Console.WriteLine(" *삭제를 취소합니다");
                    }
                    else
                    {
                        Console.WriteLine(" *숫자를 잘못입력 하셨습니다");
                    }
                }
                else
                {
                    Console.WriteLine(" *입력하신 전화번호에 저장된 전화번호가 없습니다.");
                }
            }
            else
            {
                Console.WriteLine(" *숫자를 잘못 입력하셨습니다.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Sign();
                int input = int.Parse(Console.ReadLine());

                switch ((PhoneBook)input)
                {
                    case PhoneBook.Find:
                        Find();
                        break;
                    case PhoneBook.Addition:
                        Addition();
                        break;
                    case PhoneBook.Correction:
                        Correction();
                        break;
                    case PhoneBook.Delete:
                        Delete();
                        break;
                }
            }



        }
    }
}
