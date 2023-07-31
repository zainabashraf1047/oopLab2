using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace signInSignUp
{
    class Program
    {
        class students
        {
            public string name;
            public string password;
        }
        static void Main(string[] args)
        {            
            string path = "userdata.txt";
            List<students> stuList = new List<students>();
            int option;
            readData(path, stuList);
            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                  
                    stuList.Add(signUp());
                    storeInFile(path,stuList);
                }

                else if (option == 2)
                {
                    Console.WriteLine("Enter name: ");
                    string nameEnter = Console.ReadLine();
                    Console.WriteLine("Enter password: ");
                    string passwordEnter = Console.ReadLine();
                    signIn(nameEnter, passwordEnter, stuList);
                }
            }
            while (option < 3);
            Console.ReadKey();
        }
        static students signUp()
        {
            students temp2 = new students();
            Console.WriteLine("Enter New name: ");
            temp2.name = Console.ReadLine();
            Console.WriteLine("Enter New password: ");
            temp2.password = Console.ReadLine();
            return temp2;
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. Sign Up");
            Console.WriteLine("2. Sign In");
            Console.WriteLine("Enter Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record == ",")
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void readData(string path, List<students> stuList)
        {           
            path = "userdata.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                   students temp2 = new students();

                    if (record == "" || record == " ")
                    {
                        continue;

                    }
                    temp2.name = parseData(record, 1);
                    temp2.password = parseData(record, 2);
                    stuList.Add(temp2);

                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        static void signIn(string nameEnter, string passwordEnter, List<students> stuList)
        {
            bool flag = false;
            for (int x = 0; x < stuList.Count; x++)
            {
                if (nameEnter == stuList[x].name && passwordEnter == stuList[x].password)
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;

                }
               
            }
            if (flag == false)
            {
                Console.WriteLine("InValid User");
            }
            Console.ReadKey();
        }
        static void storeInFile(string path, List<students> stuList)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < stuList.Count; i++)
            {
                file.WriteLine(stuList[i].name + "," + stuList[i].password);
            }
            file.Flush();
            file.Close();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
