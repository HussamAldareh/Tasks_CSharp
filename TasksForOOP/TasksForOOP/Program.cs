using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TasksForOOP
{
     class Person
    {

        public string name {  get; set; }

        private int age;

public int Age
        {

            get { return age; } set { age = value; }


        }

        public void printInfi()
        {


            Console.WriteLine("Nmae" +name);
            Console.WriteLine( "Age : "+ Age );


        }


    }


     class student : Person
    {





        public void printInfi()
        {


            Console.WriteLine("Nmae" + name);
            Console.WriteLine("Age : " + Age);


        }





    }


    class Car
    {
        public string Make { get; set; }

        public int year { get; set; }
        public string type;
        public int model;
        public int paletNo { get; set; }
        public string Color;

        public int price;
        private bool isengine;

        
        public Car(string make, int year, string type, int price, int model, int palletNo, string color)
        {
            this.Make = make;
            this.year = year;
            this.type = type;
            this.model =model ;
            this.paletNo = palletNo;
            this.Color = color;
            this.price=price;
        }
        public void startEngine()
        {
            isengine = true;
            Console.WriteLine("Engine started");                    
            }



        public void endEngine()
        {


            isengine=false;
            Console.WriteLine("Engine end");



        }

        public void print() {



            Console.WriteLine("Make :" +Make);
            Console.WriteLine("Year :" +year);
            Console.WriteLine("type :" +type);
            Console.WriteLine("Price :" +price);
            Console.WriteLine("model :" +model);
            Console.WriteLine("paletNo :" +paletNo);
            Console.WriteLine("color :" +Color);





        }




    }





internal class Program
    {
        static void Main(string[] args)
        {

            Person per=new Person();
            per.name = "Hussam";
            per.Age = 15;
            per.printInfi();

            Car c = new Car("Kia", 2020, "SUV", 15000, 2020, 11025, "Red");

            c.print();



        }
    }
}
