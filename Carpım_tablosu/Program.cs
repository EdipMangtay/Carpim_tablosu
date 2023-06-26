using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpım_tablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carpım();
            Console.ReadLine();

        }
        public static void Carpım()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int sonuc = i * j;
                    Console.Write("{0} \t", sonuc);

                }
                Console.WriteLine();
            }
        }
    }
}
