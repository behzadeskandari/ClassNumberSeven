using System;
using System.Collections.Generic;
using OOPClass;

namespace ClassNumberSeven
{
    //public class Test5
    //{
    //    //public int age { get; set; }
    //    //public string name { get; set; }
    //    private string _name;

    //    public string Name
    //    {
    //        get { return _name; }
    //        set { _name = value; }
    //    }


    //    private int _age;

    //    public int Age
    //    {
    //        get { return _age; }
    //        set { _age = value; }
    //    }

    //    public Test5(int Age , string Name) 
    //    {
    //        //age = Age;
    //        //name = Name;
    //        this._age = Age;
    //        this._name = Name; 
    //    }
    //    ~Test5()
    //    {

    //    }
    //}


    //public class TeacherPayment
    //{
    //    public TeacherPayment(int Salary , int Hours,int Days)
    //    {
    //        this.Salary = Salary;
    //        this.Hours = Hours;
    //        this.Days = Days;
    //    }

    //    private int _salary;

    //    public int Salary
    //    {
    //        get
    //        {
    //            if (_salary <= 0)
    //            {
    //                Console.WriteLine("The number is equal zero or less than zero ");
    //            }
    //            return _salary;
    //        }
    //        set 
    //        {
    //            if (_salary <= 0)
    //            {
    //                Console.WriteLine("The number is equal zero or less than zero ");
    //            }
    //            _salary = value; 
    //        }
    //    }

    //    private int _hours;

    //    public int Hours
    //    {
    //        get { return _hours; }
    //        set { _hours = value; }
    //    }

    //    private int _days;

    //    public int Days
    //    {
    //        get { return _days; }
    //        set { _days = value; }
    //    }


    //    public int CalculationForPayment()
    //    {
    //        if (Salary <= 0)
    //        {
    //            Console.WriteLine("The Number is Zero or Smaller");
    //        }
    //        int Total = Salary * Hours; //* Days;
    //        return Total;
    //    }

    //}
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lstPrs = new List<Person>();
            for (int i = 0; i < lstPrs.Count; i++)
            {
                Console.WriteLine("Enter Salary");
                int salary = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Working hours");
                int workinghours = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Working name");
                string name = Console.ReadLine();

                Person prs = new Person(salary, workinghours, name);

                string Holder = prs.getResult();

                Console.WriteLine(Holder);

                lstPrs.Add(prs);
                lstPrs.Sort();

                foreach (var item in lstPrs)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Salary);
                    Console.WriteLine(item.WorkingHours);
                }


            }
            //string ReturnValue = Salary + WorkingHours + Name;



            //Console.WriteLine("Enter The Salary");
            //int Salary =  Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Enter The Hours");
            //int Hours = Convert.ToInt32(Console.ReadLine());



            //Console.WriteLine("Enter The days");
            //int Days = Convert.ToInt32(Console.ReadLine());

            //TeacherPayment teacherPayment = new TeacherPayment(Salary, Hours, Days);
            //int Holder = teacherPayment.CalculationForPayment();

            //Console.WriteLine(Holder);




            ///OP TEST
            //oopClass oopClass = new oopClass();

            //oopClass.Id = 1;





        }


    }
    //Soal Ostad   یک لیست داریم که درون این لیست  موارد انگلیسی نوشته شده رو داریم با متد گت ریزالت که میخواییم کلاسمون رو در یک لیستی دخیره کنیم و نشان بدهیمName , workingHours , Salary 

    public class Person
    {
        private int _salar;
        private int _workingHours;
        private string _name;
        public Person(int Salary ,int WorkingHours, string Name)
        {
            this.Salary = Salary;
            this.WorkingHours = WorkingHours;
            this.Name = Name;

        }
        public int Salary
        {
            get { return _salar; }
            set { _salar = value; }
        }


        public int WorkingHours
        {
            get { return _workingHours; }
            set { _workingHours = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public string getResult()
        {
            var Total = Salary + WorkingHours + Name;
            return Total;
        }
    }
}
