using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Students { 

    class stud
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        private string Birthday;
        private double ball;





        public double Mark
        {
            get { return ball; }
            set
            {
                if (value >=0 && value <=5)
                {
                    ball = value;
                } 
                else
                {
                    Console.WriteLine("Incorrect data intered");
                   ball = 0.0;
                }
            }
        }

        public string Birth
        {
            get
            { return Birthday;}
            set
            {
                string[] dateformat = value.Split(new string[] { "/", " ", "-" }, StringSplitOptions.RemoveEmptyEntries);//12/11/2000; ==> {"12", "11", "2000"}
                if (dateformat.Length == 3)
                {
                    Birthday = String.Join("/", dateformat);
                }
                else
                {
                    Console.WriteLine("Incorrect date format!");
                    Birthday = "";
                }
            }
        }

        public void PrintInformation()
        {
            Console.WriteLine("Full name: " + Surname + " " + Name + " "+ Patronymic + "   " + Birth + " " + Mark);


        }
    }
}

