using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Tasks___Methods_List_LINQ_LinkedList_
{
    internal class Program
    {


        static void TaskEvenNumbersFilter()
        {

            List <int > numbers= new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            Console.WriteLine(string.Join(", ", evenNumbers));
        }



        static void TaskRemoveDuplicates()
        {
        
          List <int> numbers = new List<int>() { 1, 2, 5, 4, 5, 5, 2, 2, 8, 9, 10 };
            var uniqueNumbers = numbers.Distinct().ToList();
            Console.WriteLine(string.Join(", ", uniqueNumbers));

        }





        static void TaskFindMaximumNumber()
        {

            List<int> numbers = new List<int>() { 1, 2, 5, 4, 5, 5, 2, 2, 8, 9, 10 };


            int Maximum=numbers.Max();

            foreach(int i in numbers)
            {
                               if (i == Maximum)
                {
                    Console.WriteLine(i);
                }
            }

        }




        static void ReverseList()
        {

            List<int> numbers = new List<int>() { 1, 2, 5, 4, 5, 5, 2, 2, 8, 9, 10 };

            numbers.Reverse();
            Console.WriteLine(string.Join(", ", numbers));
        }




        static void CountNumbersGreaterThanX()

        { 
        
        List <int>  numbers= new List<int>() { 1, 2, 5, 4, 100, 250, 10 };
            int count = 0;
            int counts=numbers.Count(n => n > 50);

foreach (int i in numbers)
{
    if (i > 50)
    {
                    count++;
    }

            }
             Console.WriteLine(counts);


        }




        static void task6() {

            Dictionary< string,int > students = new Dictionary<string, int>();
            students.Add("Alice", 85);
            students.Add("Bob", 92);
            students.Add("Charlie", 50);
             students.Add("David", 79);

            var topStud = students.Where( x=> x.Value >80);
            foreach (var student in topStud)
            {
                Console.Write(student.Key + ""); Console.WriteLine(student.Value);
            }
        }



        static  void task7()
        {
            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Alice", 85);
            students.Add("Bob", 92);
            students.Add("Charlie", 50);
            students.Add("David", 79);


            Console.WriteLine("Enter Youre Name ");
                        string name = Console.ReadLine();

            if(students.ContainsKey(name))
            {
                Console.WriteLine("Your Score is " + students[name]);
            }
            else
            {
                Console.WriteLine("Name not found in the dictionary.");
            }
        }



        static void task8() {

            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Alice", 85);
            students.Add("Bob", 92);
            students.Add("Charlie", 50);
            students.Add("David", 79);


            int sum = students.Sum(x => x.Value);
            Console.WriteLine(sum);
        }





        static void task9() {

            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Alice", 85);
            students.Add("Bob", 92);
            students.Add("Charlie", 35);
            students.Add("David", 79);


            var removelow=students.Where(x => x.Value < 50).ToList();

            foreach (var student in removelow)
            {
                students.Remove(student.Key);
            }

            Console.WriteLine("Students with scores 50 or above:" + string.Join(", ", students.Keys));
        }



        static void task10() {

            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Alice", 85);
            students.Add("Bob", 92);
            students.Add("Charlie", 35);
            students.Add("David", 79);


            var highestscore=students.Where(x => x.Value == students.Max(s => s.Value));

            foreach (var student in highestscore)
            {
                Console.WriteLine("Student with the highest score: " + student.Key + " - " + student.Value);
            }

        }




        static void task11() {
          LinkedList <int> numbers = new LinkedList<int>();
            numbers.AddFirst(1);
            numbers.AddLast(2);
            numbers.AddLast(3);
            numbers.AddFirst(4);
            numbers.AddLast(5);
            Console.WriteLine("Linked List: " + string.Join(", ", numbers));
        }


        static void task12() {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(1);
            numbers.AddLast(2);
            numbers.AddLast(3);
            numbers.AddFirst(4);


            int count = numbers.Count;
            int middleIndex = count / 2;
            var current = numbers.First;
            int index = 0;
            while (current != null)


            {
                if(index == middleIndex)
                {
                    numbers.Remove(current);
                    break;
                }

                current = current.Next;
                index++;

            }

                Console.WriteLine (string.Join(", ", numbers));

        }




        static void task13() {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(1);
            numbers.AddLast(2);
            numbers.AddLast(3);
            numbers.AddFirst(4);

            var current = numbers.First;
            int index = 0;
            while (current != null)
            {
                if (index == 2)
                {
                   numbers.AddBefore(current, 5);
                }
                else
                {
                    current = current.Next;
                }
                index++;
            }


            Console.WriteLine(string.Join(", ", numbers));


        }



        static void task14() {


            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(1);
            numbers.AddLast(2);
            numbers.AddLast(3);
            numbers.AddFirst(4);


            foreach (var number in numbers)
            {
                Console.Write(number);
            }




        }





        static void task15() {

            Console.WriteLine("");


            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(1);
            numbers.AddLast(2);
            numbers.AddLast(3);
            numbers.AddFirst(4);
            Console.WriteLine(numbers.First.Value);
            Console.WriteLine(numbers.Last.Value);

        }



        static void task16()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var oddNumbers = numbers.Where(n => n % 2 != 0);

            Console.WriteLine(string.Join(", ", oddNumbers));
        
        
        
        }


        static void task17() {


            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var multipliedNumbers = numbers.Select(n => n * 2);

            Console.WriteLine(string.Join(", ", multipliedNumbers));
        }


        static void task18() {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var sort = numbers.OrderByDescending(n => n);

            Console.WriteLine(string.Join(", ", sort));
        }



        static void task19() {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(220);
            numbers.AddLast(100);
            numbers.AddLast(150);
            numbers.AddFirst(4);
           var firstGreater=numbers.FirstOrDefault(n=> n > 100);
            if (firstGreater != 0)
            {
                 Console.WriteLine(firstGreater);
            }
            else
            {
                Console.WriteLine(numbers.First.Value);
                }
            }



        static  void task20() {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(220);
            numbers.AddLast(100);
            numbers.AddLast(150);
            numbers.AddFirst(4);
           var average = numbers.Average();
            Console.WriteLine(average);
        }




        static void task21() {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            List<int> numbers2 = new List<int> { 6, 7, 8, 9, 10 };


            numbers = numbers.Concat(numbers2).ToList();


            Console.WriteLine(string.Join(", ", numbers));

        }






        static void task22()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> numbers2 = new List<int> { 6, 7, 2, 9, 5 };



            var commonNumbers = numbers.Intersect(numbers2);

            Console.WriteLine(string.Join(", ", commonNumbers));

        }





        static void task23() {

            List<int> numbers2 = new List<int> { 6,2, 2, 2, 9, 5 };


            var ss= numbers2.Distinct().ToList();
            Console.WriteLine(string.Join(", ", ss));
        }











        static void task24()
        {

            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Alice", 85);
            students.Add("Bob", 92);
            students.Add("Charlie", 35);
            students.Add("David", 79);


            List<string> studentNames = students.Keys.ToList();


            var mex=studentNames.Concat(students.Values.Select(v => v.ToString())).ToList();

            Console.WriteLine(string.Join(", ", mex));
        }




        static  void task25() {
            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("Alice", 125);
            students.Add("Bob", 92);
            students.Add("Charlie", 500);
            students.Add("David", 79);
            var filter = students
     .Where(s => s.Value > 100)
     .ToList();

            foreach (var item in filter)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }



        static void Task26()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            Console.Write("Enter number: ");
            int target = int.Parse(Console.ReadLine());

            bool found = false;

            foreach (var num in numbers)
            {
                if (num == target)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("Found");
            else
                Console.WriteLine("Not found");
        }




        static void task27() {
            List<int> numbers = new List<int> { 1, 2, 8, 4, 10};


            int count = 0;
            foreach(var n in numbers)
            {
                if (n % 2 ==0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }



        static void task28()
        {
            List<int> numbers = new List<int> { 1, 2, 8, 4, 10 };

            int re;

            do
            {
                Console.Write("Enter number to remove (0 to exit): ");
                re = int.Parse(Console.ReadLine());

                if (re == 0)
                    break;

                if (numbers.Contains(re))
                {
                    numbers.Remove(re);
                    Console.WriteLine("Removed");
                }
                else
                {
                    Console.WriteLine("Not found");
                }

            } while (true);
        }



        static void Task29()
        {
            List<int> numbers = new List<int> { 10, 5, 20, 8, 15 };

            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (var num in numbers)
            {
                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }
                else if (num > secondMax && num != max)
                {
                    secondMax = num;
                }
            }

            Console.WriteLine($"Second largest: {secondMax}");
        }


        static void Task30()
        {

            int[] numbers = new int[] { 1, 3, 3, 4, 3 };

            int mostFrequent = numbers[0];
            int maxCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {

                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                        mostFrequent = numbers[i];
                    }

                }




            }
            Console.WriteLine($"Most frequent: {mostFrequent} ( {maxCount} times)");


        }





       static void task35()
        {

            int [] numbers = new int[] { 1, 3, 3, 4, 3 };

            int index = 0;

            int sumLeft = 0;
            int sumRight = 0;
            int deff = 0;
            int minDeff = int.MaxValue;

            for (int i =0;i<numbers.Length-1; i++)
            {
               
                for(int j=0; j <= i; j++)
                {
                    sumLeft += numbers[j];

                }

                for(int k=i+1;k< numbers.Length; k++)
                {
                    sumRight += numbers[k];
                }

                deff= Math.Abs(sumLeft - sumRight);
                if (deff <minDeff)
                {
                    index = i;
                    minDeff = deff;
                }

                sumLeft = 0;
                sumRight = 0;

            }

                        Console.WriteLine($"Index with minimum difference: {index}");
        }




        static void task36() { 
        
        
        
        
        
        
        
        
        }





        static void Main(string[] args)
        {
            TaskEvenNumbersFilter();
            TaskRemoveDuplicates();
            TaskFindMaximumNumber();
            ReverseList();
            CountNumbersGreaterThanX();
            task6();
            task7();
            task8();
            task9();
            task10();
            task11();
            task12();
            task13();
            task14();
            task15();
            task16();
            task17();
            task18();
            task19();
            task20();
            task21();
            task22();
            task23();
            task24();
            task25();
                Task26();
            task27();
            task28();
            Task29();
            Task30();
            task35();
        }

    }
}
