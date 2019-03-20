using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //My name is Dan The compuetr man I am.
            //This is my work.
            Console.WriteLine("N\t\t10*N\t\t100*N\t\t1000*N");
            for (int i = 3; i < 8; i++) 
            {
                Console.WriteLine($"{i}\t\t{i * 10}\t\t{i * 100}\t\t{i * 1000} ");

            }
            Console.ReadLine();

            Console.WriteLine("while loop");
            
            int start = 3;
            int finish = 8;
            while (start <= finish) 

            {
                Console.WriteLine($"{start}\t\t{start * 10}\t\t{start * 100}\t\t{start * 1000}");
                start++;

            }
            Console.ReadLine();

            Console.WriteLine("do while loop");
            start = 3;
            do
            {
                Console.WriteLine($"{start}\t\t{start * 10}\t\t{start * 100}\t\t{start * 1000}");
                start++;

            }
            while (start <= finish);
            Console.ReadLine();

            //Task 2 

            Console.WriteLine("The For Loop");
            
            for (int i = 1; i < 13; i++) 
            {
                Console.WriteLine($"{i} x 7 = {i * 7}");


            }
            Console.ReadLine();

            Console.WriteLine("The While Loop");
            

            int start1 = 1;
            int finish1 = 12;
            while (start1 <= finish1)
            {
                Console.WriteLine($"{start1} x 7 = {start1 * 7}");
                start1++;


            }
            Console.ReadLine();

            Console.WriteLine("The do while loop");
            

            start1 = 1;
            do
            {
                Console.WriteLine($"{start1} x 7 = {start1 * 7}");
                start1++;


            }
            while (start1 <= finish1);
            Console.ReadLine();
            
            
            //Task 3


            Console.WriteLine(" The for loop");
            Console.ReadLine();
            Console.WriteLine("Number\t\tSquare\t\tCube\t\t");

            for (int i = 0; i <= 10; i++)


            {
                Console.WriteLine($"{i}\t\t{i * i}\t\t{i * i * i}");


            }
            Console.ReadLine();

            Console.WriteLine("The While Loop");
            Console.ReadLine();

            int start2 = 0;
            int finish2 = 10;
            while (start2 <= finish2)
            {
                Console.WriteLine($"{start2}\t\t{start2 * start2}\t\t{start2 * start2 * start2}");
                start2++;
            }
            Console.ReadLine();

            Console.WriteLine("The do while loop");
            Console.ReadLine();
            start2 = 0;
            do
            {
                Console.WriteLine($"{start2}\t\t{start2 * start2}\t\t{start2 * start2 * start2}");
                start2++;

            }
            while (start2 <= finish2);
            Console.ReadLine();


        }
    }
}
