using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinh_tien_nuoc
{
    internal class Program
    {
        private static int price;

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

                string name = Name();
                    int num1 = Numberwater("Enter water that month:");
                    Console.WriteLine("Water that month: " + num1);
                    int num2 = Numberwater("Enter water this month:");
                    Console.WriteLine("Water this month: " + num2);

                if (num1 > num2)
                {
                    Console.WriteLine("Vui long nhap lai");
                    continue;
                }
                int price;
                if (choice == "1")
                {
                    int num_people = Numberwater("Enter number people: ");
                    price = (num2 - num1) * num_people;
                }
                else
                {
                    price = num2 - num1;
                }
                    Console.WriteLine("Luong nuoc tieu thu la: " + price);
                    double waterPrice = GetWaterPrice(choice, price );
                    Console.WriteLine("Total water bill is: " + waterPrice);
            }
            

        }
        static void Menu()
        {
            Console.WriteLine("-----Menu-----");
            Console.WriteLine("1. Household");
            Console.WriteLine("2. Administrative agency, public services");
            Console.WriteLine("3. Production units");
            Console.WriteLine("4. Business services");
            Console.WriteLine("5. Exit");
        }
        static string Getchoice()
        {
            Console.WriteLine("Nhap loai khach hang: ");
            string choice = Console.ReadLine();

            while (choice != "1" &&  choice != "2" && choice != "3" && choice != "4" && choice != "5") 
            {
                Console.WriteLine("Vui long nhap lai");
                choice = Console.ReadLine();
            }
            
            return choice;
        }
        static string Name()
        {
            Console.WriteLine("Nhap ten khach hang");
            string name = Console.ReadLine();
            return name;
        }
        static int Numberwater(string message)
        {
           Console.Write(message);
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            return num;
        }
        static double GetWaterPrice(string choice, int price)
        {
            double waterPrice = 0;
            switch (choice)
            {
                case "1":
                    if (price <= 10)
                    {
                        waterPrice = 5.973 * price;
                    }
                    else if (price <= 20)
                    {
                        waterPrice = 7.052 * price;
                    }
                    else if (price <= 30)
                    {
                        waterPrice = 8.699 * price;
                    }
                    else
                    {
                        waterPrice = price * 15.929;
                    }
                    break;
                case "2":
                    waterPrice = price * 9.955;
                    break;
                case "3":
                    waterPrice = price * 11.615;
                    break;
                case "4":
                    waterPrice = price * 22.068;
                    break;
                case "5":
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
            }
            return waterPrice;
        }
      
            
            




    }
}
