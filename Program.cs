using System;

namespace PrimenumberChecker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int checknumber;
           
            Console.WriteLine("Lütfen Asal sayı kontrolü için sayı giriniz.");
            checknumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < checknumber; i++) {

                if (checknumber % i == 0)
                {

                    Console.WriteLine($"{checknumber} bir asal sayı Değildir.");
                    return;
                }
        

              
            }


            Console.WriteLine($"{checknumber} bir asal sayı .");
            Console.ReadKey();
        }
    }
}
