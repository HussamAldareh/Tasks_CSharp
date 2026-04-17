using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksInDiscord
{
    internal class Program
    {

        static void converttoSecond() {
        
        
        Console.WriteLine("Enter the number of minutes:");

            int minutes= int.Parse(Console.ReadLine());


            int seco= minutes * 60;

            Console.WriteLine("The number of seconds is: " + seco);

        }




        static int task2increment()
        {

            Console.WriteLine("Enter the number:");

            int number = int.Parse(Console.ReadLine());

            number++;
            return number ;

        }




        static void task3Array()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < numbers.Length; i++)
            {

                if (i==0)

                {
                    Console.WriteLine("The first element is: " + numbers[i]);
                }



            }



        }



        static int task4Area() {

            Console.WriteLine("Enter the base :");

            int baseValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height :");

            int height = int.Parse(Console.ReadLine());



            int area = (baseValue * height) / 2;
            
            Console.WriteLine("The area of the triangle is: " + area);



            return area;



        }




        static void evenNumberEvenIndex() { 
        
        int[] num = { 2, 2, 4, 4, 6, 6, 8, 8, 9, 10 };
            int[] evenNumbersAtEvenIndices = new int[num.Length ];
            int count = 0;
            for (int i =0;i< num.Length; i++)
            {
                if (i % 2 == 0 && num[i] % 2 == 0)
                {

                    evenNumbersAtEvenIndices[count] = num[i];
                    count++;

                }
           
            }



            Console.Write("Even numbers at even indices: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(evenNumbersAtEvenIndices[i] + " ");
            }


        }



        static void evenIndexOddLength()
        {

            string[] names= { "Alice", "Bob", "Charlie", "David", "Eve" };
            string[] newname= new string[names.Length];

            for(int i =0; i<names.Length; i++)
            {

                if(i%2==0 && names[i].Length % 2 != 0)
                {
                    newname[i] = names[i];
                    Console.WriteLine("The name at even index with odd length is: " + newname[i]);
                }



            }





        }



        static void powerElementIndex()
        {

            int[] num = { 44, 5, 4, 3, 2, 10 };
            double[] poweredNumbers = new double[num.Length];


            for(int i = 0; i < num.Length; i++)
            {
                poweredNumbers[i] = Math.Pow(num[i], i);
            }

            Console.WriteLine("Numbers raised to the power of their indices: "
                + string.Join(", ", poweredNumbers));



        }




        static int multiplication2(int a, int b)
        {
            int result = 0;

            for (int i = 0; i < b; i++)
            {
                result += a;
            }

            return result;
        }



        static int muti2(int start, int end)
        {
            int result = 1;

            for (int i = start; i <= end; i++)
            {
                result *= i;
            }

            return result;
        }

        static double aveArray(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return (double)sum / arr.Length;
        }





        static int dates2()
        {


           Console.WriteLine("Enter the first date (yyyy-MM-dd):");

             DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second date (yyyy-MM-dd):");
            DateTime date2 = DateTime.Parse(Console.ReadLine());


                TimeSpan difference = date2 - date1;
                Console.WriteLine("The difference in days is: " + Math.Abs(difference.TotalDays));





            return (int)Math.Abs(difference.TotalDays);

        }


        static string[] StringsWithNumbers(string[] arr)
        {
            List<string> result = new List<string>();

            foreach (string str in arr)
            {
                foreach (char c in str)
                {
                    if (char.IsDigit(c))
                    {
                        result.Add(str);
                        break; // عشان ما يضيفها أكثر من مرة
                    }
                }
            }

            return result.ToArray();
        }



        static void reverseall()
        {



            string[] words = { "Hello", "World", "CSharp", "Programming" };
            
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {

                    words[i] = new string(words[i].Reverse().ToArray());
                }

            }
            Console.WriteLine("Reversed words with odd length: " + string.Join(", ", words));



        }



        static bool IsPandigital(long number)
        {
            string numStr = number.ToString();

            for (char c = '0'; c <= '9'; c++)
            {
                if (!numStr.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }


        static Func<int, int> AddN(int n)
        {
            return (int z) => z + n;
        }




        static string removeLeadingTrailing(string n)
        {
            double num = double.Parse(n);
            return num.ToString();
        }



        static int secondLargest(int[] arr)
        {
            int max = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondMax && arr[i] != max)
                {
                    secondMax = arr[i];
                }
            }

            return secondMax;
        }



        static bool isRepdigit(int num)
        {
            if (num < 0)
                return false;

            string str = num.ToString();

            char first = str[0];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != first)
                    return false;
            }

            return true;
        }



        static string reverseWords(string str)
        {
            var words = str.Split(' ');

            List<string> cleaned = new List<string>();

            foreach (var word in words)
            {
                if (word != "")
                {
                    cleaned.Add(word);
                }
            }

            cleaned.Reverse();

            return string.Join(" ", cleaned);
        }



        static string sevenBoom(int[] arr)
        {
            foreach (int num in arr)
            {
                if (num.ToString().Contains('7'))
                {
                    return "Boom!";
                }
            }

            return "there is no 7 in the array";
        }




        static string insertWhitespace(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result += str[i];

                if (i < str.Length - 1 &&
                    char.IsLower(str[i]) &&
                    char.IsUpper(str[i + 1]))
                {
                    result += " ";
                }
            }

            return result;
        }



        static int countTrue(bool[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    count++;
                }
            }

            return count;
        }




        static string capToFront(string str)
        {
            string upper = "";
            string lower = "";

            foreach (char c in str)
            {
                if (char.IsUpper(c))
                    upper += c;
                else
                    lower += c;
            }

            return upper + lower;
        }






        static bool matchLastItem(object[] arr)
        {
            string combined = "";

            for (int i = 0; i < arr.Length - 1; i++)
            {
                combined += arr[i].ToString();
            }

            string last = arr[arr.Length - 1].ToString();

            return combined == last;
        }




        static int findNaN(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (double.IsNaN(arr[i]))
                {
                    return i;
                }
            }

            return -1;
        }



        static object[] removeDups(object[] arr)
        {
            List<object> result = new List<object>();

            foreach (var item in arr)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

        static string convertTime(string time)
        {
            string period = time.Substring(time.Length - 2); 
            string[] parts = time.Substring(0, 8).Split(':');

            int hour = int.Parse(parts[0]);
            string minutes = parts[1];
            string seconds = parts[2];

            if (period == "AM")
            {
                if (hour == 12)
                    hour = 0;
            }
            else 
            {
                if (hour != 12)
                    hour += 12;
            }

            return hour.ToString("D2") + ":" + minutes + ":" + seconds;
        }



        static string removeLastVowel(string sentence)
        {
            string vowels = "aeiouAEIOU";
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    if (vowels.Contains(words[i][j]))
                    {
                        words[i] = words[i].Remove(j, 1);
                        break;
                    }
                }
            }

            return string.Join(" ", words);
        }






        static int sumOfCubes(int[] arr)
        {
            int sum = 0;

            foreach (int num in arr)
            {
                sum += num * num * num;
            }

            return sum;
        }






        static void SumAndAverage()
        {


            int s=0;
            double avg = 0;

            Console.WriteLine("Enter 10 numbers:");
            for(int i = 0; i < 10; i++)
            {

                Console.Write("Number-" + i + " : ");
int num = int.Parse(Console.ReadLine());
                s += num;

            }

            avg = (double)s / 10;

            Console.WriteLine("The sum of 10 no is : " + s);
            Console.WriteLine("The Average is : " + avg);
        }



        static void cubeNumbers()
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            
            for(int i=1; i <= num; i++)
            {


                Console.WriteLine($"Number is : {i} and cube of {i} is : {i * i * i}");


            }

        }


        static void greaterThan1950()
        {

            int[] years = { 1945, 1950, 1955, 1960, 1970, 1980, 1990, 2000 };


            for(int i = 0; i < years.Length; i++)
            {
                if (years[i] > 1950)
                {
                    Console.WriteLine(years[i]);
                }
            }


        }



        static int AgeInDays(int age)
        {
            return age * 365;
        }



        static int CountLegs(int chickens, int cows, int pigs)
        {
            if (chickens < 0 || cows < 0 || pigs < 0)
            {
                Console.WriteLine("Invalid input!");
                return -1;
            }

            return (chickens * 2) + (cows * 4) + (pigs * 4);
        }





        static string login(string username, string password)
        {
            string[] users = { "hussam", "admin", "user" };
            string[] passwords = { "1234", "admin123", "pass" };

            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] == username && passwords[i] == password)
                {
                    return "pass";
                }
            }

            return "failed";
        }




        static double Power(int baseNumber, int exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }





        static bool IsLeapYear(int year)
        {
            if (year < 1900 || year > 2024)
                return false;

            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }






        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }








        static int CountWords(string sentence)
        {
            sentence = sentence.Trim();

            if (sentence == "")
                return 0;

            int count = 1;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ' && sentence[i - 1] != ' ')
                {
                    count++;
                }
            }

            return count;
        }





       static void comp()
        {


            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2= int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine(num1 + " is greater than " + num2);
            }
            else if (num2 > num1)
            {
                Console.WriteLine(num2 + " is greater than " + num1);
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }


        }






        static void sign()
        {

            Console.WriteLine( "Enter the number " );
        int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("The number is positive (+)  .");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is negative (-)  .");
            }
            else
            {
                Console.WriteLine("The number is zero (0) .");
            }



        }







        static void ascending() {

            Console.WriteLine("Enter the number 1 ");
            int num1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter the number 2 ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number 3 ");
            int num3 = int.Parse(Console.ReadLine());


            if(num1 >num2 && num1> num3 && num2>num3)
            {

                Console.WriteLine("The numbers in ascending order are: " + num3 + ", " + num2 + ", " + num1);
            }
            else if (num1 > num2 && num1 > num3 && num3 > num2)
            {
                Console.WriteLine("The numbers in ascending order are: " + num2 + ", " + num3 + ", " + num1);
            }
            else if (num2 > num1 && num2 > num3 && num1 > num3)
            {
                Console.WriteLine("The numbers in ascending order are: " + num3 + ", " + num1 + ", " + num2);
            }
            else if (num2 > num1 && num2 > num3 && num3 > num1)
            {
                Console.WriteLine("The numbers in ascending order are: " + num1 + ", " + num3 + ", " + num2);
            }
            else if (num3 > num1 && num3 > num2 && num1 > num2)
            {
                Console.WriteLine("The numbers in ascending order are: " + num2 + ", " + num1 + ", " + num3);
            }
            else
            {
                Console.WriteLine("The numbers in ascending order are: " + num1 + ", " + num2 + ", " + num3);
            }


        }




        static void maxNum()
        {

            Console.WriteLine("Enter the number 1 ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number 2 ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number 3 ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number 4 ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number 5 ");
            int num5 = int.Parse(Console.ReadLine());



            if(num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            {
                Console.WriteLine("The maximum number is: " + num1);
            }
            else if(num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
            {
                Console.WriteLine("The maximum number is: " + num2);
            }
            else if(num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
            {
                Console.WriteLine("The maximum number is: " + num3);
            }
            else if(num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
            {
                Console.WriteLine("The maximum number is: " + num4);
            }
            else
            {
                Console.WriteLine("The maximum number is: " + num5);
            }
        }




        static void convertFromKtoMil()
        {

            Console.WriteLine("Enter the number in kilometers: ");
            int Kilo = int.Parse(Console.ReadLine());


            double miles = Kilo * 0.621371;



            Console.WriteLine(Kilo + " kilometers is equal to " + miles + " miles.");
        }





        static void minute()
        {
            Console.WriteLine("Enter the number of houre: ");
            int houre = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of muinte: ");
            int muinte = int.Parse(Console.ReadLine());



            int totalMinutes = (houre * 60) + muinte;

            Console.WriteLine("The total number of minutes is: " + totalMinutes);
        }




        static void convertToHours()
        {
            Console.WriteLine("Enter the number of minutes: ");
            int minutes = int.Parse(Console.ReadLine());
            double hours = (double)minutes / 60;
            Console.WriteLine(minutes + " minutes is equal to " + hours + " hours.");
        }



        static void PrintFixedSentences()
        {
            string[] sentences =
            { "Hello world","I love CSharp","Programming is fun","AI is powerful","Keep learning"};

            foreach (string s in sentences)
            {
                Console.WriteLine(s.PadRight(25, '.'));
            }
        }


        static string reverseOdd(string sentence)
        {
            string[] words = sentence.Split(' ');
            string result = "";

            foreach (string word in words)
            {
                if (word.Length % 2 != 0)
                {
                    char[] chars = word.ToCharArray();
                    Array.Reverse(chars);
                    result += new string(chars) + " ";
                }
                else
                {
                    result += word + " ";
                }
            }

            return result.Trim();
        }







        class MyClass
        {
            public void ShowMessage()
            {
                Console.WriteLine("MyClass class has initialized!");
            }
        }




        class Intro
        {
            public void Show(string name)
            {
                Console.WriteLine("Hello All, I am " + name);
            }
        }





        class Factorial
        {
            public int Calculate(int n)
            {
                int result = 1;

                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }

                return result;
            }
        }


        class ArraySorter
        {
            public void SortArray(int[] arr)
            {
                Array.Sort(arr);

                Console.WriteLine("Sorted array: " + string.Join(", ", arr));
            }
        }





        class DateDifference
        {
            public void Calculate(DateTime d1, DateTime d2)
            {
                int years = d2.Year - d1.Year;
                int months = d2.Month - d1.Month;
                int days = d2.Day - d1.Day;

                if (days < 0)
                {
                    months--;
                    days += DateTime.DaysInMonth(d2.Year, d2.Month);
                }

                if (months < 0)
                {
                    years--;
                    months += 12;
                }

                Console.WriteLine($"Difference: {years} years, {months} months, {days} days");
            }
        }





 
   /// </summary>
class Program1  
    {
        static void Main()
        {
            string dateString = "12-08-2004";

            DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Converted Date: " + date.ToString("yyyy-MM-dd"));
        }
}

        /*


        string[] arr = { "1", "7", "9", "45" };
        string[] arr2 = { "Str", "alex", "moh" };
        string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

        string[] fruits = { "Tomato", "Banana", "Watermelon" };

        Console.WriteLine(Array.IndexOf(fruits, "Tomato")); // 0
Console.WriteLine(Array.IndexOf(fruits, "Banana"));  // 1





        string[] food = { "Pizza", "Burger", "Pasta", "Rice", "Chicken" };
string[] sport = { "Football", "Basketball", "Tennis" };
string[] movies = { "Inception", "Titanic", "Joker", "Avatar" };

Console.WriteLine("Food:");
foreach (var f in food)
    Console.WriteLine(f);

Console.WriteLine("Sports:");
foreach (var s in sport)
    Console.WriteLine(s);

Console.WriteLine("Movies:");
foreach (var m in movies)
    Console.WriteLine(m);








        */

        static void SumThreeNumbers()
        {
            Console.Write("Enter three numbers separated by comma: ");
            string input = Console.ReadLine();

            string[] parts = input.Split(',');

            int sum = int.Parse(parts[0]) +
                      int.Parse(parts[1]) +
                      int.Parse(parts[2]);

            Console.WriteLine("The sum of three numbers: " + sum);
        }



        static void OddNumbers()
        {
            int sum = 0;

            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine("Sum of odd numbers: " + sum);
        }



        static void StarTriangle()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }





        static void NumberTriangle()
        {
            int num = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }
















        static void Main(string[] args)
        {
                string[] inputStrings = { "Hello", "World123", "Test", "Example456" };
            reverseall();


            var add5 = AddN(5);

            Console.WriteLine(add5(3));  
            Console.WriteLine(add5(10));
            Console.WriteLine(secondLargest(new int[] { 10, 40, 30, 20, 50 }));
            Console.WriteLine(isRepdigit(66));
            Console.WriteLine(reverseWords(" the sky is blue"));

            Console.WriteLine(sevenBoom(new int[] { 1, 2, 3, 4, 5, 6, 7 }));
            Console.WriteLine(insertWhitespace("SheWalksToTheBeach"));
            Console.WriteLine(countTrue(new bool[] { true, false, false, true, false }));
            Console.WriteLine(capToFront("moveMENT"));
            Console.WriteLine(matchLastItem(new object[] { "rsq", "6hi", "g", "rsq6hig" }));
            Console.WriteLine(findNaN(new double[] { 1, 2, double.NaN })); 
            Console.WriteLine(string.Join(", ", removeDups(new object[] { 1, 0, 1, 0 })));

            Console.WriteLine(convertTime("07:05:45PM"));
            Console.WriteLine(removeLastVowel("Love is a serious mental disease."));
            Console.WriteLine(sumOfCubes(new int[] { 1, 5, 9 }));
            SumAndAverage();
            cubeNumbers();
            greaterThan1950();
            Console.WriteLine(AgeInDays(10));
            Console.WriteLine(CountLegs(2, 3, 5));
            Console.WriteLine(login("hussam", "1234"));
            Console.WriteLine(Power(2, 3));

            int[] array = { 11, -2, 4, 35, 0, 8, -9 };

            ArraySorter obj = new ArraySorter();
            obj.SortArray(array);



            Factorial obj11 = new Factorial();
            Console.WriteLine(obj11.Calculate(5)); // 120


            Intro obj1 = new Intro();
obj1.Show("Scott");



            MyClass obj2 = new MyClass();
            obj2.ShowMessage();


        }
    }
}
