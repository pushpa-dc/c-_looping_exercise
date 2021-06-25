using System;

namespace looping
{
    class Program
    {
        static void Main(string[] args)
        {




            // Console.WriteLine("Input a number : ");
            // int to = int.Parse(Console.ReadLine());
            // Cube(to);

            // System.Console.WriteLine("Enter nummber");
            // int input = int.Parse(System.Console.ReadLine());
            // MultiplicationTable(input);


            // Console.WriteLine("Enter a positive number: ");
            // int number = int.Parse(Console.ReadLine());


            // Console.WriteLine("Enter a positive number: ");
            // int number = int.Parse(Console.ReadLine());
            // FibonnicNumber(number);

            // TrianglePattern(number);

                    // Console.WriteLine("Enter a positive number: ");
            // int number = int.Parse(Console.ReadLine());
            // FibonnicNumber(number);
            // PyramidPattern(number);



        }

        public static void MultiplicationTable(int input)
        {
             /* Write a program in C# Sharp to display the multiplication table of a given integer upto 10.
            e.g.
            Input the number : 15
            15 X 1 = 15
            ...
            ...
            15 X 10 = 150 */

            for (int i = 1; i <= 10; i++)
            {
                    System.Console.WriteLine($" {input} X {i} = {i*input}");
            }
        }

        public static void Cube(int to)
        {
             /* Write a program in C# Sharp to display the cube of the number up to given an integer. Ask user for the input.
            e.g.  Input a number : 3
            Number is : 1 and cube of the 1 is :1
            Number is : 2 and cube of the 2 is :8
            Number is : 3 and cube of the 3 is :27 */

            for (int i = 1; i <= to; i++)
            {
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{i*i*i}");
            }

        }
    
        public static void FibonnicNumber(int number)
        {
            // Print n Fibonacci Numbers where user inputs n.
            // Hint: start from 1. Next number = current number + previous.
            // 1, 1+0=1, 1+1=2, 2+1=3, 3+2=5.... 
            // e.g.
            // Enter a number: 10
            // 1,1,2,3,5,8,13,21,34

           int a = 0, b = 1;
            Console.Write($"{b}");
            for (int i = 2; i < number; i++)  
            {
                int c = a + b;
                Console.Write($" {c}");  
                a = b;  
                b = c;  
            }  
        }



        public static void TrianglePattern(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {   
                    System.Console.Write(i);
                }
                    System.Console.Write("\n");

            }
        }


        public static void PyramidPattern(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                    
               for (int k = 1; k <= number - i / 2; k++)
               Console.Write(" ");
                

                for (int j = 1; j <= i; j++)
                {   
                    System.Console.Write(j);
                }
                    System.Console.WriteLine("");

            }
        }
    }
}
