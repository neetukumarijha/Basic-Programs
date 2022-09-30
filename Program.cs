using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasicPrograms
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            //Print your name in a separate line in console application or window form
            Console.WriteLine("Neetu");

            //Swap two numbers in console application or window form

            /* 
             int num1, num2, temp;
             Console.WriteLine("enter the first number");
             num1 = int.Parse(Console.ReadLine());
             Console.WriteLine("enter the second number");
             num2 = int.Parse(Console.ReadLine());
             temp = num1;
             num1 = num2;
             num2 = temp;
             Console.WriteLine("after swapping");
             Console.Write("\nFirst Number : " + num1);
             Console.Write("\nSecond Number : " + num2);
             Console.Read();

            */

            // Write a input as upper and Lower case

            /*  string coder = "Akshay";
              string ucaseCoder=coder.ToUpper();
              Console.WriteLine(ucaseCoder);  
              string lcaseCoder=coder.ToLower();  
              Console.WriteLine(lcaseCoder);
            */

            //check if a given string starts with 'C#' or not. And return true or false
            /*
             Console.WriteLine(test("sharp C#"));
             Console.WriteLine(test("C#"));
             Console.WriteLine(test("C++"));
             Console.ReadLine();
         }
         public static bool test(string str)
         {
             return (str.Length < 3 && str.Equals("C#")) || (str.StartsWith("C#") && str[2] == ' ');
         }
            */
            //Read Roll No, Name and Marks of three subject and print Roll No, Name and Percentage

            double roll, m1, m2, m3, total, per;
            string name;
            Console.Write("\n\n");
            Console.Write("Calculate the total marks of three subjects:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input the Roll Number of the student :");
            roll = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Name of the Student :");
            name = Console.ReadLine();
            Console.WriteLine("Roll number of student {0}", roll);
            Console.WriteLine("Name of student {0}", name);
            Console.WriteLine("Input  the marks of one subject: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input  the marks of  second subject : ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input  the marks of third subject : ");
            m3 = Convert.ToInt32(Console.ReadLine());
            total = m1 + m2 + m3;
            per = total / 3;
            Console.WriteLine("total marks of subject {0}", total);
            Console.WriteLine("percentage {0}", per);
        }


    }
}


