using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
    internal class Program
    {

        static void Task1()
        {
            int sum = 0;
            int count = 0;
            int count2 = 0;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {

                    count++;
                }
                else
                {
                    count2++;
                }


                sum += arr[i];

            }


            int avg = sum / arr.Length;
            int[] arr2 = new int[arr.Length];


            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > avg)
                {
                    arr2[i] = arr[i];
                }


            }


            Console.WriteLine("Sum of all elements in the array: " + sum);
            Console.WriteLine("Count of even numbers in the array: " + count);
            Console.WriteLine("Count of odd numbers in the array: " + count2);
            Console.WriteLine("Average of all elements in the array: " + avg);
            Console.WriteLine("Elements greater than the average: " + string.Join(", ", arr2));


        }




        static void Task2()
        {



            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            Console.WriteLine("Max element in the array: " + max);

        }



        static void Task3()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i]);
                }



            }



        }


        static void Task4()
        {

            Console.WriteLine("Enter the Full Name ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Age ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height");
            Double Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Are You Employed (yes/no)");
            string input = Console.ReadLine().ToLower();

            bool Employed = input == "yes";


            Console.WriteLine("--- User Profile ---");
            Console.WriteLine("Full Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Is Employed: " + Employed);



        }


        static void Task5()
        {
            Console.WriteLine("Enter the Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter the Age");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name :" + Name.ToUpper());
            Console.WriteLine("Age :" + Age);

            Console.WriteLine("Name :" + Name.ToLower());

            Console.WriteLine(Name[0]);


        }




        static void Task6()
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 1; i < arr.Length; i++)
            {

                Console.WriteLine(arr[i]);

                if (arr[i] % 3 == 0)
                {
                    Console.WriteLine(arr[i]);
                    continue;
                }

                else if (arr[i] == 8)
                {

                    Console.WriteLine(arr[i]);

                    break;
                }

            }



        }


        static void Main(string[] args)
        {
            Task1();
            
        }
    }
}
