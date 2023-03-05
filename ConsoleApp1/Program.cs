using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // taks 1

            int tarix = 2000;

            if (tarix + 18 > 2023){
                Console.WriteLine("18 yas olmayib");
            }
            else{
                Console.WriteLine("18 yas olub");
            }

            // task 2

            int num = -5678;
            int cem = 0;
            
            if( num < 0){
                num *= -1;
            }
            int a = num % 10;
            int b = num / 10 % 10;
            int c = num / 100 % 10;
            int d = num / 1000 ;

            cem = a + b + c + d;
            
            Console.WriteLine(cem);

        }
    }
}
