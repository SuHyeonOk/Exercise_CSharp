using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_simple
{
    class Program
    {
        // ﻿가장 큰 값을 반환하는
        static int GetHighestScore(int[] scores)
        {
            int Max = 0;

            for(int i = 0; i < scores.Length; i++)
            {
                if(Max < scores[i])
                {
                    Max = scores[i];
                }
            }

            Console.WriteLine(Max);
            return Max;
        }
        //﻿ 평균 값을 반환하는
        static int GetAverageScores(int[] scores)
        {
            return 0;
        }
        // ﻿배열에서 내가 원하는 값이 있는지 없는지 찾기 있다면 몇번째에 있는지 반환하고 없으면 -1을 반환하기
        static int GetIndexOf(int[] scores, int value)
        {

        }
        // ﻿배열을 Sort을 이용해서 호출하면 작은 것부터 큰 순서대로 출력하는 함수
        static void Sort(int[] scores)
        {

        }

        static void Main(string[] args)
        {
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            GetHighestScore();
        }
    }
}
