using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG2
{
    class TextRPG
    {
        static void Main(string[] args)
        {
            Game gmae = new Game();

            while (true)
            {
                gmae.Process();
            }
        }
    }
}
