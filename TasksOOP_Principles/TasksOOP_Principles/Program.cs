using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTest
{


    static class MathUtilities
    {



        public static int squar(int a)
        {


            return a * a;


        }



        public static double sqrtRot(double a)
        {


            return Math.Sqrt(a);


        }



        public static int Maximum(int a, int b)
        {



            int ma = Math.Max(a, b);

            return ma;
        }

    }
    //// ////////////////////////////////////////////////////////////////////////////////////////////////






    class Converter
    {




        public static int Convert(int Celsius)
        {

            int fher = (Celsius * 9 / 5) + 32;

            return fher;


        }




        public static double convertKilo(double Kilo)
        {

            double mile = Kilo * 0.621371;


            return mile;



        }


    }

    ///////////////////////////////////////////////////////////////////////////////////////


    class VisitorCounter
    {


        public static int counter = counter++;
    }

    /// ///////////////////////////////////////////////////////////////////////////////////////


    class Company
    {
        public static string CompanyName { get; set; }

        public string EmployeeName { get; set; }

        public Company(string employeeName)
        {
            EmployeeName = employeeName;
        }

        public void Print()
        {
            Console.WriteLine($"{EmployeeName} works at {CompanyName}");
        }
    }




    /// //////////////////OOP Principles/////////////////////////////////////////////////////////////////////

    public static class MathHelper
    {


        public static int add(int a, int b)
        {
            return a + b;


        }



        public static int add(int a, int b, int c)
        {

            return a + b + c;
        }


    }




    abstract class Anmail
    {


        public abstract void Speak();

    }


    class Cats : Anmail
    {
        public override void Speak()
        {

            Console.WriteLine("The cat meows ");


        }

    }


    class Person
    {

        private int id;
        private string name;

        public int Id
        {

            get
            {
                return id;
            }

            set
            {
                if (value > 0)
                    id = value;


            }

        }

        public string Name
        {


            get { return name; }
            set { name = value; }



        }




    }



    abstract class Shape
    {



        public abstract double GetArea();

    }

    class Rectangle : Shape
    {



        public double w;
        public double h;

        public override double GetArea()
        {

            return w * h;


        }

    }

    /// ///////////////////////////////////////////////////////////////////////////////////////



    class Calculator
    {


        public int add(int a, int b)
        {


            return a + b;


        }




        public int add(int a, int b, int c)
        {


            return a + b + c;


        }



        public decimal add(decimal a, decimal b)
        {


            return a + b;


        }




    }

    abstract class Animals
    {
        public abstract void MakeSound();
    }

    class Dog : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }


    class Cat : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("cats meuw");
        }




    }



    /// /////////////////////////////////////////////////////////////
    /// 




    abstract class Appliance
    {

        public string Brand { get; set; }


        public abstract void TurnOn();

        public abstract void TurnOFf();


    }



    class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine($"{Brand}  Washing machine is turning on");





        }



        public override void TurnOFf()
        {
            Console.WriteLine($" {Brand} Washing machine is Off now");

        }



    }



    class AirConditioner : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine($" {Brand} AirConditioner is turning on");





        }



        public override void TurnOFf()
        {
            Console.WriteLine($"{Brand} AirConditioner is Off now");

        }




    }
    //    ///////////////////////////////////////////////////////////




    class BankAccount
    {


        private double balance;

        public double Balance
        {

            get { return balance; }

        }




        public void Deposit(double amount)
        {
            if (amount > 0)
            {

                balance += amount;

                Console.WriteLine("Done deposet ");

            }
            else
            {


                Console.WriteLine("Invalid amount");

            }
        }


        public void Withdraw(double amount)
        {


            if (amount > 0)
            {

                balance -= amount;


                Console.WriteLine("Withdraw successful");
            }

            else
            {


                Console.WriteLine("Insufficient balance or invalid amount");
            }
        }
    }

    // ////////////////////////////////////////////////////////


    abstract class Employee
    {



        public string name { get; set; }

        public abstract int CalculateSalary();

    }





    class FullTimeEmployee : Employee
    {

        public int MonthlySalary { get; set; }

        public override int CalculateSalary()
        {




            return MonthlySalary;

        }




    }



    class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public int HourRate { get; set; }

        public override int CalculateSalary()
        {
            return HoursWorked * HourRate;
        }
    }







    internal class Program
    {


        static void Main(string[] args)
        {

            Converter.Convert(30);
            Converter.convertKilo(50);

            MathUtilities.sqrtRot(1);




            int resulte = MathHelper.add(1, 2);
            Console.WriteLine(resulte);


            VisitorCounter.counter++;
            VisitorCounter.counter++;

            Console.WriteLine(VisitorCounter.counter);

            Company.CompanyName = "Google";

            Company emp1 = new Company("Hussam");
            Company emp2 = new Company("Ahmad");

            emp1.Print();
            emp2.Print();

            Calculator calculator = new Calculator();
            calculator.add(1, 2);
            calculator.add(1, 2, 5);
            calculator.add(1.1m, 2.5m);

            Dog d = new Dog();
            d.MakeSound();


            WashingMachine wm = new WashingMachine();
            wm.Brand = "LG";




            AirConditioner ac = new AirConditioner();
            ac.Brand = "Samsung";

            wm.TurnOn();
            wm.TurnOFf();

            ac.TurnOn();
            ac.TurnOFf();



            BankAccount acc = new BankAccount();

            acc.Deposit(100);
            acc.Withdraw(30);

            Console.WriteLine(acc.Balance);



            FullTimeEmployee emp = new FullTimeEmployee();
            emp.name = "Hussam";
            emp.MonthlySalary = 1000;

            PartTimeEmployee emp22 = new PartTimeEmployee();
            emp22.name = "Ahmad";
            emp22.HoursWorked = 5;
            emp22.HourRate = 10;

            Console.WriteLine(emp.CalculateSalary());
            Console.WriteLine(emp22.CalculateSalary());








        }

    }
}


