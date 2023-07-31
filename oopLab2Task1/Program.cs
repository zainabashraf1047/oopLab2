using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLab2ProductTask
{
    class Program
    {
        class product
        {

            public string id;
            public string name;
            public int price;
            public string category;
            public string brandName;
            public string country;

        }
        static int menu()
        {
            int choice;
            Console.WriteLine("1. Add Products");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Total Store Worth");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your Choice");
            choice=int.Parse(Console.ReadLine());
            return choice;
        }
        static product addProducts()
        {
            product pro = new product();
            Console.WriteLine("Enter product ID");
            pro.id=Console.ReadLine();
            Console.WriteLine("Enter product name");
            pro.name=Console.ReadLine();
            Console.WriteLine("Enter product price");
            pro.price=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product category");
            pro.category=Console.ReadLine();
            Console.WriteLine("Enter product Brand Name");
            pro.brandName=Console.ReadLine();
            Console.WriteLine("Enter product country");
            pro.country=Console.ReadLine();
            return pro;
        }
        static void showProducts(product[] proArr,int count)
        {
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("Id: {0} Name: {1} Price: {2} Category: {3} Brand Name: {4} Country: {5}", proArr[i].id, proArr[i].name, proArr[i].price, proArr[i].category, proArr[i].brandName, proArr[i].country);
            }
        }
        static void viewWorth(product[] proArr,int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
               
                sum = sum + proArr[i].price;

            }
            Console.WriteLine("The total worth is: {0}" , sum);
        }
        static void Main(string[] args)
        {
            product[] proArr = new product[20];
            int count = 0;
            int option = 0;
            do
            {
                 option = menu();
                if (option == 1)
                {
                    proArr[count]= addProducts();
                    count++;
                }
                else if (option == 2)
                {
                    showProducts(proArr, count);
                }   
                else if(option==3)
                {
                    viewWorth(proArr, count);
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                    break;
                }
            }
            while (option != 4);
            Console.WriteLine("Enter Choice");

        }
    }
}
