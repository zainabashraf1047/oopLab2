using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLab2task
{
    class Program
    {
  
        class students
        {
            public string name;
            public int rollNo;
            public float cgpa;
            public char isHostelide;
            public string department;
        }
        static int menu()
        {
            Console.Clear();
            int choice;
            Console.WriteLine("1. Add a student");
            Console.WriteLine("2. View Student");
            Console.WriteLine("3. View Top Three Students");
            Console.WriteLine("4. Exit");
            choice = int.Parse(Console.ReadLine());
            return choice;

        }
        static void viewStudents(students[] stuArray,int count)
        {
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("Name: {0} Roll_No: {1} Cgpa: {2} Is Hostelite: {3} Department: {4}", stuArray[i].name, stuArray[i].rollNo, stuArray[i].cgpa, stuArray[i].isHostelide, stuArray[i].department);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        static students addStudents()
        {
            students stu1 = new students();
            Console.WriteLine("Enter Name ");
            stu1.name = Console.ReadLine();
            Console.WriteLine("Enter Roll_No: ");
            stu1.rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA: ");
            stu1.cgpa = float.Parse(Console.ReadLine());   
            Console.WriteLine("Is Hostelite y||n: ");
            stu1.isHostelide = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department Name: ");
            stu1.department = (Console.ReadLine());
            return stu1;
        }
      
        static void topStu(students[] stuArray,int count )
        {
            for(int i=0;i<count;i++)
            {
                for(int j=i+1;j<count;j++)
                {
                    if(stuArray[i].cgpa<stuArray[j].cgpa)
                    {
                        /*float temp = stuArray[i].cgpa;
                        stuArray[i].cgpa = stuArray[j].cgpa;
                        stuArray[j].cgpa = temp;*/

                        students tempArr = stuArray[i];
                        stuArray[i] = stuArray[j];
                        stuArray[j] = tempArr;
                    }
                }
            }
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No result found");

            }
            else if (count == 1)
            {
                viewStudents(stuArray, 1);
            }
            else if (count == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Name: {0} Roll_No: {1} Cgpa: {2} Is Hostelite: {3} Department: {4}", stuArray[i].name, stuArray[i].rollNo, stuArray[i].cgpa, stuArray[i].isHostelide, stuArray[i].department);
                }

            }
            else
            {
                for (int i = 0; i < 3; i++)
                {

                    Console.WriteLine("Name: {0} Roll_No: {1} Cgpa: {2} Is Hostelite: {3} Department: {4}", stuArray[i].name, stuArray[i].rollNo, stuArray[i].cgpa, stuArray[i].isHostelide, stuArray[i].department);
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            students[] stuArray = new students[10];
            int option;
            int count = 0;
            do
            {
                option = menu();
                if (option == 1)
                {
                    stuArray[count] = addStudents();
                    count++;
                }
                else if (option == 2)
                {
                    viewStudents(stuArray, count);
                }
                else if (option == 3)
                {
                    topStu(stuArray, count);
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            while (option != 4);
            {
                Console.WriteLine("Enter choice");
            }
        }
    }
}
