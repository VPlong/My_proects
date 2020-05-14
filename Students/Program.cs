using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of students: ");
            int numberStudent = Convert.ToInt32(Console.ReadLine());

            stud[] students = new stud[numberStudent];// создали массив типа с именем students

            for (int i =0; i < numberStudent; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Student: " + (i+1));
                students[i] = new stud();//cозлаём поля из stud для каждого i

                Console.Write("Surname: ");
                students[i].Surname = Console.ReadLine();

                Console.Write("Name: ");
                students[i].Name = Console.ReadLine();

                Console.Write("Patronymic: ");
                students[i].Patronymic = Console.ReadLine();

                Console.Write("Birthday: ");
                students[i].Birth = Console.ReadLine();

                Console.Write("Mark: ");
                students[i].Mark = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("");//стые строки
            Console.WriteLine("Student List:");
            for (int i = 0; i < numberStudent; i++)
            {
                students[i].PrintInformation();
            }



            Console.ReadKey();
        }
    }
}
