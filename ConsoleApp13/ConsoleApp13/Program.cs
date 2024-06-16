using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {



                Menu();
                string choice = Getchoice();
                if (choice == "5")
                {
                    break;
                }
                int num1 = Getnumber("Enter first number: ");
                Console.WriteLine("num1 is: " + num1);
                int num2 = Getnumber("Enter second number: ");
                Console.WriteLine("num2 is: " + num2);
                double result = GetCalculator(Getchoice(), num1, num2);
                Console.WriteLine("ket qua la: " + result);

                Console.WriteLine("Nhan phim bat ki de tiep tuc");
                Console.ReadLine();
                Console.Clear();
            }
        }
        
        static int Getnumber(string message)
        {
            Console.Write(message);
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            return num;

        }
        static void Menu()
        {
            Console.WriteLine("-----Menu-----");
            Console.WriteLine("1. Cong");
            Console.WriteLine("2. Tru");
            Console.WriteLine("3. Nhan");
            Console.WriteLine("4. Chia");
            Console.WriteLine("5. Exit");
        }
        static string Getchoice()
        {
            Console.WriteLine("Nhap lua chon cua ban: ");
            string choice = Console.ReadLine();

            while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5") 
            {
                Console.WriteLine("Nhap lai: ");
                choice = Console.ReadLine();    
            }
            
            return choice;
        }
        static double GetCalculator (string you_choice, int a, int b)
        {
            double result = 0;
            switch (you_choice)
            {
                case "1":
                    result = a + b; 
                    break;

                case "2":
                    result = a - b;
                    break;
                case "3":
                    result = a * b;
                    break;

                case "4":
                    if (b == 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    
                        result = a / b;
                    break;
                case "5":
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
                    
            

            }
            return result;
        }
        


        

    }
   
    
}
