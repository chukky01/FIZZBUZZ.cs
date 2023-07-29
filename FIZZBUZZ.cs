
using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           //cycle through numbers from 1 to 100
           for(int i = 0; i<=100; i++)
           {
            //if the number is divisible by both 3 and 5, print fizzbuzz
            if(i % 15 == 0){
                Console.WriteLine(i + "FIZZBUZZ");
            }
            //but if the number is divisible by 3 and not 5, print fizz
            else if(i % 3 == 0){
                Console.WriteLine(i + "FIZZ");
            }
            //and if the number is divisible by 5 but not 3, print buzz
            else if(i % 5 == 0){
                Console.WriteLine(i + "BUZZ");
            }
            //Finally, is the number is not divisible by any of them, just print the number like that
            else{
                Console.WriteLine(i);
            }
           }
           
        }
    }
}
