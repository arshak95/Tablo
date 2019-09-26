using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablo
{
    class Program
    {
        static void Main(string [] args)
        {
            int[,] Tablo = { { 1, 2, 3, }, { 4, 5, 6, }, { 7, 8, 9, }, { 10, 11, 12, }, { 13, 14, 15, } };
            int boy = Tablo.GetUpperBound(0) + 1;
            int erkarutyun = Tablo.Length;
            for (int i = 0; i < boy; i++)
            {
                for (int j = 0; j < erkarutyun; j++)
                {
                    Console.Write($"{ Tablo [ i, j]  } \t ");
                }
                Console.WriteLine();
            }

        }
    }
}
