using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    /*
  * 랜덤함수를 통해서 10개의 랜덤한 숫자를 만들어 길이가 10인 배열에 저장하기
  * 그 배열을 오름차순ㄴ으로 정렬하여 출혁하기 for문으로
  * for(int i = 0; i < 10; i++)
  * Console.WriteLine(arr[i]);
  */
    class Program
    {
        // Swap함수는 왜 ref가 없는데 가능했을까? 배열은 참조타입 이기 때문이다
        // int index, int num 복사가 되는 게 상관 없는 애들이다
        static void Swap(int[] arr, int index, int num)
        {
            int temp = arr[num];
            arr[num] = arr[index];
            arr[index] = temp;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++) // arr 배열에 랜덤 숫자를 넣는 for문
            {
                int ran = random.Next(1, 11);
                arr[i] = ran;
                //Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            foreach (int value in arr) // 단순한 출력의 경우는 foreach이 낫다
            {
                Console.WriteLine(value);
            }


            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < arr.Length; i++) // 선택되는 방 번호
            {
                for (int j = i; j < arr.Length; j++) // 랜덤숫자가 들어간 arr의 방을 돌면서 작은 값 찾기
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                        index = j;
                    }
                }
                //Swap(arr, index, i);
                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
                min = int.MaxValue;
            }

            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
