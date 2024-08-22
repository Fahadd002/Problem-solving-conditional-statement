using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement_Part_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem12();
           // Problem16();
            Problem18();
            Console.ReadLine();
        }
        public static void Problem18()
        {
            string nm; int custId, conu;
            double chg, grossAmount;

            Console.Write("Customer Id: ");
            custId = int.Parse(Console.ReadLine());
           Console.Write("Input the name of the customer :"); 
            nm = Console.ReadLine(); 
            Console.Write("Input the unit consumed by the customer : ");  
            conu = Convert.ToInt32(Console.ReadLine());
            if (conu < 200)
                chg = 1.20;
            else if (conu >= 200 && conu < 400)
                chg = 1.50;
            else if (conu >= 400 && conu < 600)
                chg = 1.80;
            else
                chg = 2.00;
            Action ResultMetod = () =>
            {
                grossAmount = conu * chg;
                if (grossAmount > 0 && grossAmount <= 100)
                {
                    Console.WriteLine("The bill amount = 100");
                }
                else if (grossAmount > 100 && grossAmount < 400)
                {
                    Console.WriteLine($"The bill amount = {grossAmount}");
                }
                else
                {
                    Console.WriteLine($"The bill amount = {grossAmount + (grossAmount * .15)}");
                }
            };
                
            
            Console.WriteLine($"Name ={nm}");

            Console.WriteLine($"Bill Id ={custId}");
            ResultMetod();
              
        }

        //Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.
        public static void Problem16()
        {
            char ch;
            Console.Write("Input an Alphabet (A-Z or a-z) : ");  
            ch=char.Parse(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.WriteLine("Please input an Alphabet (A-Z or a-z)");
            }
            else {

                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The alphabet is consonent");
                        break;
                }
            }
             
            
           
        }
            public static void Problem12() 
        {
            int roll; String Name; int phy; int che; int com;
            Console.Write("Enter roll Number: ");
            roll = int.Parse(Console.ReadLine());
            Console.Write("Student's Name: ");
            Name= Console.ReadLine();
            Console.Write("Enter Marks in Physics:");
            phy=int.Parse(Console.ReadLine());
            Console.Write("Marks in Chemistry: ");
            che = int.Parse(Console.ReadLine());
            Console.Write("Marks in Computer Application:");
            com = int.Parse(Console.ReadLine());
            int totalMark= phy+che+com;
            int per = totalMark / 3;
            Console.WriteLine($"Total Marks: {totalMark}");
            Console.WriteLine($"Percentage = {per}%");
            if (per >= 80) 
            {
            Console.WriteLine("Result = First Division");
            }
            else if (per >= 60 && per<80)
            {
                Console.WriteLine("Result = Second Division");
            }
            else if (per >= 40 && per < 60)
            {
                Console.WriteLine("Result = Third Division");
            }
            else { Console.WriteLine("Fail! "); }

        }
    }
}
