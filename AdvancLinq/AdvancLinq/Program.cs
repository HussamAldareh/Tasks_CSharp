using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancLinq
{
    internal class Program
    {




        static void Rotat()
        {

         
            int[] arr = { 1, 2, 3, 4, 5, };
            int len = arr.Length;
            Console.WriteLine("Enter the n");
            int n = Console.ReadLine().Length;

            for (int i = 0; i < n; i++)
            {

                int last = arr[len - 1];
                for (int j = len - 1; j > 0; j--)
                {
                    arr[j]=arr[j-1];
                
                }
                arr[0] = last;

            }
            Console.WriteLine(string.Join("",arr));
        }













        static void Main(string[] args)
        {
            Rotat();


        }
    }
}
