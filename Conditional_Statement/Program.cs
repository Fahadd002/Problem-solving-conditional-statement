using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem1();
            //Problem2();
            //Problem3();
            //Problem6();
            //Problem8();
            //Problem9();
            Problem10();
            Console.ReadLine();
        }
        //Write a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria:
        //Marks in Maths >=65
        //Marks in Phy >=55
        //Marks in Chem>=50
        //Total in all three subject >=180 or Total in Math and Subjects >=140
        public static void Problem10()
        {
            int m; int p; int c;
            Console.Write("Eligibility Criteria :\n"); 
            Console.Write("Marks in Maths atleast 65\n");
            Console.Write("Marks in Physics atleast 55\n");
            Console.Write("Marks in Chemistry atlest 50\n");
            Console.Write("Total Marks in all three subject should be 180 and more\n");
            Console.Write("or Total in Maths and Physics >=140\n");
            Console.Write("-------------------------------------\n");

            Console.Write("Number in Math: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Number in Physics: ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Number in Chymistry: ");
            c = int.Parse(Console.ReadLine());
            if (m >= 65)
            {
                if (p >= 55)
                {
                    if (c >= 50)
                    {
                        if (m + p + c >= 180 || (m + p >= 140))
                        {
                            Console.WriteLine("The candidate is eligible for admission.");
                        }
                        else
                            Console.WriteLine("You are not eligible for admission");
                    }
                    else
                        Console.WriteLine("You are not eligible for admission");
                }
                else
                    Console.WriteLine("You are not eligible for admission");
            }
            else
            {
                Console.WriteLine("You are not eligible for admission");
            }
            Console.WriteLine($"Total Number = {m + p + c}");
        }


            //Write a C program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            public static void Problem9()
        {
            int co1; int co2;
            Console.Write("Enter Your first coordinate point: ");
            co1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Second coordinate point: ");
            co2 = int.Parse(Console.ReadLine());
            if (co1 > 0 && co2 > 0)
            {
                Console.WriteLine($"The coordinate point ({co1} {co2}) lies in the First quadrant");
            }
          else if (co1 < 0 && co2 > 0)
            {
                Console.WriteLine($"The coordinate point ({co1} {co2}) lies in the Second quadrant");
            }
            else if (co1 < 0 && co2 < 0)
            {
                Console.WriteLine($"The coordinate point ({co1} {co2}) lies in the 3rd quadrant");
            }
            else if (co1 > 0 && co2 < 0)
            {
                Console.WriteLine($"The coordinate point ({co1} {co2}) lies in the 4th quadrant");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({co1} {co2}) lies in the Center");
            }

        }

            //8. Write a C# Sharp program to find the largest of three numbers.
            public static void Problem8()
        {
            int a; int b; int c;
            Console.Write("Enter Your first Number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Second Number: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter Your 3rd Number: ");
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine("The 1st Number is the greatest among three");
                }
                else
                {
                    Console.WriteLine("The 3rd Number is the greatest among three.");
                }
            }
            else if (b > c)              {
                Console.WriteLine("The 2nd Number is the greatest among three ");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three "); 
            }

        }


            //Write a C# Sharp program to read the value of an integer m
            // and display the value of n is 1 when m is larger than 0, 0 when m is 0
            // and -1 when m is less than 0.
            public static void Problem6()
        {
            int m; int n;
            Console.Write("Enter Your Number: ");
            m = int.Parse(Console.ReadLine());
            if (m != 0)
            {
                if (m > 1)
                    n = 1;
                else
                    n = -1;
            }
            else n = 0;
            Console.Write("The value of m = {0} \n", m);
            Console.Write("The value of n = {0} \n\n", n);

            //if (m > 0)
            //{
            //    n = 1;
            //    Console.WriteLine($"The value Of m is {m}");
            //    Console.WriteLine($"The value Of n is {n}");
            //}
            //else if (m == 0)
            //{
            //    n = 0;
            //    Console.WriteLine($"The value Of m is {m}");
            //    Console.WriteLine($"The value Of n is {n}");
            //}
            //else if (m < 0)
            //{
            //    n = -1;
            //    Console.WriteLine($"The value Of m is {m}");
            //    Console.WriteLine($"The value Of n is {n}");
            //}
            //else
            //{
            //    Console.WriteLine("Value is terminated");
            //}
        }




        public static void Problem3()
        {
            int a;
            Console.WriteLine("Enter Your Number: ");
            a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("The number is Positive");
            }
            else if (a < 0)
            {
                Console.WriteLine("the Number is Negetive");
            }
            else
            {
                Console.WriteLine("The Number is 0");
            }
        }
        public static void Problem2()
        {
            int a;
            Console.WriteLine("Enter Your Number :");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("the Number is Odd");
            }

        }
        public static void Problem1()
        {
            int int1, int2;
            Console.WriteLine("Enter Your First Number: ");
            int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your 2nd Number: ");
            int2 = int.Parse(Console.ReadLine());
            if (int1 == int2)  // Checking if int1 is equal to int2
                Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
        }
    }
}
