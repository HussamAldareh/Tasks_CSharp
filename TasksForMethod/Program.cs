using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksForMethod
{
    internal class Program
    {

       
        static int CalculatAverge(int number1, int number2, int number3)
        {
            int average = (number1 + number2 + number3) / 3;
            return average;}


        static void Task2()
        {

            List<string> names = new List<string>() { "Hussam", "Ahmad", "Hala", "Ibrahem", "Khaled" };

            foreach (string n in names)
            {


                Console.WriteLine(n);


            }
            Console.WriteLine("after Remove");
            names.Remove("Ahmad");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

        }



        static void Task3()
        {

            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Ali");
            students.Add(2, "Omar");
            students.Add(3, "Hussam");
                
            foreach (var item in students)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }


        }



        static void task4()
        {

            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };
            var numbersgreaterthan15 = numbers.Where(x => x > 15);
            Console.WriteLine(string.Join(", ", numbersgreaterthan15));
            var evennum=numbers.Where(x => x%2==0); 
            Console.WriteLine(string.Join(", ", evennum));
            var sortNum= numbers.OrderBy(x => x);
            Console.WriteLine(string.Join(", ", sortNum));

            var sortnumdescending=numbers.OrderByDescending(x => x);
            Console.WriteLine(string.Join(", ", sortnumdescending));

            var nameswitha=names.Where(x => x.StartsWith("A"));
            
            foreach (var item in nameswitha)
            {
                Console.WriteLine(item);
            }




        }


        static void task51()
        {

            Console.WriteLine("Welcome");
        }
        



        static void task52(string name )
        {
            Console.WriteLine("Welcome" + name);
        }



        static void task53(int age =25)
        {
            Console.WriteLine("Your age is " + age);
        }



        static int task54()
        {

            int num1 = 10;
            int num2 = 20;
                        int sum = num1 + num2;

            return sum;
        }





        static void task55(int[] arr )
        {
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }




        static void Main(string[] args)
        {

            int [] numbers = { 5, 10, 15 };

            Console.WriteLine(CalculatAverge(5, 10, 15));

            Task2();
            Task3();
            task4();
            task51();
            task52("Husam");
            task53();
            task54();
            task55(numbers);


        }
    }
}
