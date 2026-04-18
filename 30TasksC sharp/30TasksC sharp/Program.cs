using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30TasksC_sharp
{
    internal class Program
    {
        //1/////////////////////////

        static void Task1()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }

                Console.WriteLine();
            }
        }


        /// <summary>
        /// //////////////////////////////2////////////////////////
        /// </summary>


        static void Task2()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                for (int k = 1; k <= 2 * (n - i); k++)
                {
                    Console.Write(" ");
                }

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }



        /// <summary>
        /// //////////////////////3/////////////////////////
        /// </summary>

        static void Task3()
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                for (int j = 1; j <= i; j++)
                    Console.Write(j);

                for (int j = i - 1; j >= 1; j--)
                    Console.Write(j);

                Console.WriteLine();
            }

        }



        /// <summary>
        /// /////////////////////////////////////////////
        /// </summary>

        static void Task1String()
        {

            string str = "aAbBcC";

            for (int i = 0;i< str.Length-1; i++)

            {

                if (char.ToLower (str[i]) ==char.ToLower( str[i+1]))
                {
                    str = str.Remove(i, 2);
                    i = -1;
                }



            }


            Console.WriteLine(str);


        }



   // static  void Task2String()
//        {


            //string str ="banana";

         //   for (int i = 0; i < str.Length; i++) { 
            
           // if (str[i]==)
            
            
            
         //   }
    //


       // }


        /// <summary>
        /// //////////////////////////////////////////////////////
        /// </summary>


        static void Task3String()
        {


            string str = "aabBcc";
            char[] arr = str.ToCharArray(); 


            for (int i=str.Length-2;i>=0; i--)
            {
                if (char.IsLower(arr[i]))
                {
                    arr[i + 1] = char.ToUpper(arr[i + 1]);
                }
                else if (char.IsUpper(arr[i]))
                {
                    arr[i + 1] = char.ToLower(arr[i + 1]);
                }
            }
            str = new string(arr); 
            Console.WriteLine(str);
        }


        /// <summary>
        /// ////////////////////////////////////////////////////////
        /// </summary>
        static void task10String() {




            string str = "LRLRLLRR";

            int countl= 0;
            int countR = 0;
            int Allcoount = 0;
            for(int i =0;i< str.Length;i++)
            {


                if (str[i] == 'L')
                {
                    countl++;
                }

                else if (str[i]=='R')
                {
                    countR++;


                }


                if(countl==countR)
                {

                    Allcoount++;
                    
                }
            }
            Console.WriteLine(Allcoount);
        }

        // //////////////////////////////////////////////////////////

        static void task9String() {


            string str = "abca";
            int index = 0;

 

            int def=0;
            for (int i = 0; i < str.Length; i++) {

                char current = str[i];

                int first = -1;
                int last = -1;

                for(int j= 0; j < str.Length; j++)
                {
                    if (str[j] == current)
                    {
                        if (first == -1)
                        {
                            first = j;
                        }
                        last = j;
                    }

                    if (first !=last)
                    {
                        int diff = last - first;
                        Console.WriteLine($"Character: {current}, First Index: {first}, Last Index: {last}, Difference: {diff}");
                    }

                }




            }

            
        
        
        }


        // //////////////////////////////////////////////////////////

        static bool IsPalindrome(string str, int left, int right)
        {
            while (left < right)
            {
                if (str[left] != str[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }


        static void Task8string()
        {



            string str = "abca";
            int left = 0; int right = str.Length - 1;
            while (left < right)
            {

                if (str[left] == str[right])
                {
                    left++; right--;

                }

                else { 
                
                
                
                if(IsPalindrome(str,left+1,right) || IsPalindrome(str,left,right-1))
                {
                    Console.WriteLine("Yes");
                }
                    else
                    {
                        Console.WriteLine("No");
                    }
                    return;
                }
            }

            Console.WriteLine("Yes");



        }
        // //////////////////////////////////////////////////////////

        static void task6String()
        {





            string str = "aaabbccccd";
            int count=1;

            int longestCount = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {

                if(str[i] == str[i + 1]){


                    count++;


                }
                else 
                {
                    if(count> longestCount)
                        longestCount = count;
                       count = 1;
                }
               

            }
            if (count > longestCount)
                longestCount = count;

            Console.WriteLine(longestCount);


        }


        // //////////////////////////////////////////////////////////

        static void task7String()
        {

            string str = "abc";
        
            for (int i = 0; i < str.Length; i++)
            {
                char next = (char)(str[i] + 1);
                Console.Write(next);
            }

        }




        // //////////////////////////////////////////////////////////
        static void task4String()
        {
            Console.WriteLine("");


            int total = 0;
            string str = "0101";
            int count0 = 0;
            int count1 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count0 = 0;
                count1 = 0;
                for (int j = i; j < str.Length; j++)
                {

                    if (str[j] == '0')
                    {
                        count0++;
                    }
                    else if (str[j] == '1')
                    {
                        count1++;
                    }
                    if (count0 == count1)
                    {
                        total++;
                       
                    }
                }

               
            }
            Console.WriteLine(total);

        }


        // //////////////////////////////////////////////////////////


        static void task1string()
        {

            string str = "aAbBcC";
             
            for(int i = 0; i < str.Length; i++)
            {

                if (str[i] != str[i + 1])
                {
                    str = str.Remove(i, 2);
                    i -= 1;
                }



            }
            Console.WriteLine(str);

        }

        // //////////////////////////////////////////////////////////

        static void task1Array()
        {
            int[] arr = { 1, 2, 1, 3, 4 };

            for (int i = 0; i < arr.Length; i++)
            {
                List<int> temp = new List<int>();

                for (int j = i; j < arr.Length; j++)
                {
                    if (temp.Contains(arr[j]))
                    {
                        break;
                    }

                    temp.Add(arr[j]);

                    if (temp.Count >= 2)
                    {
                        Console.WriteLine(string.Join(", ", temp));
                        return;
                    }
                }
            }
        }


        // //////////////////////////////////////////////////////////


        static void task2Array()
        {
            int[] arr = { 1, 2, 1, 2, 1, 2 };

            for (int i = 0; i < arr.Length; i++)
            {
                int firstDiff = -1;
                bool valid = true;
                bool seenFirst = false;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        int diff = j - i;

                        if (!seenFirst)
                        {
                            firstDiff = diff;
                            seenFirst = true;
                        }
                        else if (diff != firstDiff)
                        {
                            valid = false;
                            break;
                        }
                    }
                }

                if (seenFirst && valid)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }


        // //////////////////////////////////////////////////////////       

        static void taskAlmostSorted()
        {
            int[] arr = { 1, 3, 2, 4 };

            List<int> bad = new List<int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    bad.Add(i);
                }
            }

            if (bad.Count == 0)
            {
                Console.WriteLine("Yes");
                return;
            }

            if (bad.Count > 2)
            {
                Console.WriteLine("No");
                return;
            }

            int i1 = bad[0];
            int i2 = bad.Count == 2 ? bad[1] + 1 : bad[0] + 1;

            Swap(arr, i1, i2);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }









        static void Main(string[] args)
        {
            Task1();

            Task2();
            Task3();



            Task1String();
            Task3String();
            task10String();
                task9String();
                Task8string();
                task6String();
                task7String();
            task4String();
            task1Array();
        }
    }
}
