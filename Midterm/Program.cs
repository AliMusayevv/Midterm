using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Girilən 10 rəqəm içindən 10 ve 20 arasındaki rəqəmlerin sayı və cəmini tapmaq.
             */
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + "- ci Reqemi daxil edin: ");

                int imput = Int32.Parse(Console.ReadLine());
                arr[i] = imput;
            }

            int say = 0;
            int cem = 0;
            foreach (int a in arr)
            {
                if (a <= 20 && a >= 10)
                {


                    cem = cem + a;
                    say++;

                }

            }
            Console.WriteLine();
            Console.WriteLine("10 ve 20 Aralığındaki rəqəm sayı : " + say);
            Console.WriteLine("10 ve 20 Aralığındaki rəqəmlərin cəmi :" + cem);


            Console.Read();

        }
    }
}
