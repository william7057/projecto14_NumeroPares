using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecto14_NumeroPares
{
    class Program
    {
        static void Main(string[] args)
        {

           int x = 1;
            int suma = 0;
            //2 ,4 , 6  ,  8= 20
            while (x<=10)
            {
                Console.WriteLine(x*2);
                suma = suma + x * 2;
                x = x + 1;
            }

            Console.WriteLine("la suma es  : {0} ", suma);
            Console.Read();
        }
    }
}
