using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
    internal class Program


    {



        static void Rotate(int[] arr, int k)
        {
            int n = arr.Length;
            k = k % n; // لو k أكبر من طول المصفوفة

            Reverse(arr, 0, n - 1);      // 1. عكس الكل
            Reverse(arr, 0, k - 1);      // 2. عكس أول k
            Reverse(arr, k, n - 1);      // 3. عكس الباقي
        }

        static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }







        static int FindMissing(int[] arr)
        {
            int n = arr.Length + 1; // لأنه في رقم ناقص

            int expectedSum = n * (n + 1) / 2;

            int actualSum = 0;
            foreach (int num in arr)
            {
                actualSum += num;
            }

            return expectedSum - actualSum;
        }





        static int ShortestDistance(int[] arr)
        {
            Dictionary<int, int> lastSeen = new Dictionary<int, int>();

            int minDistance = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (lastSeen.ContainsKey(arr[i]))
                {
                    int distance = i - lastSeen[arr[i]];
                    minDistance = Math.Min(minDistance, distance);
                }

                lastSeen[arr[i]] = i;
            }

            return minDistance == int.MaxValue ? -1 : minDistance;
        }






        static int[] Reorder(int[] arr)
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    evens.Add(num);
                else
                    odds.Add(num);
            }

            evens.AddRange(odds);

            return evens.ToArray();
        }



        static List<int> FindPeaks(int[] arr)
        {
            List<int> peaks = new List<int>();

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    peaks.Add(arr[i]);
                }
            }

            return peaks;
        }





        static (int, int) TwoSum(int[] arr, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];

                if (map.ContainsKey(complement))
                {
                    return (complement, arr[i]);
                }

                map[arr[i]] = i;
            }

            return (-1, -1); // إذا ما في حل
        }




        static void MoveZeros(int[] arr)
        {
            int pos = 0; // مكان وضع الأرقام غير صفر

            // نحط كل القيم غير صفر بالبداية
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[pos] = arr[i];
                    pos++;
                }
            }

            // نعبّي الباقي أصفار
            for (int i = pos; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }





        static int[] MergeAlternate(int[] arr1, int[] arr2)
        {
            int n1 = arr1.Length;
            int n2 = arr2.Length;

            int[] result = new int[n1 + n2];

            int i = 0, j = 0, k = 0;

            // دمج بالتناوب
            while (i < n1 && j < n2)
            {
                result[k++] = arr1[i++];
                result[k++] = arr2[j++];
            }

            // لو في عناصر زيادة
            while (i < n1)
                result[k++] = arr1[i++];

            while (j < n2)
                result[k++] = arr2[j++];

            return result;
        }





        static void CountFreq(int[] arr)
        {
            bool[] visited = new bool[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (visited[i])
                    continue;

                int count = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        visited[j] = true;
                    }
                }

                Console.WriteLine($"{arr[i]} → {count}");
            }
        }






        static int SecondMax(int[] arr)
        {
            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int num in arr)
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

            return secondMax == int.MinValue ? -1 : secondMax;
        }





        static bool SubarraySum(int[] arr, int target)
        {
            int left = 0;
            int sum = 0;

            for (int right = 0; right < arr.Length; right++)
            {
                sum += arr[right];

                while (sum > target)
                {
                    sum -= arr[left];
                    left++;
                }

                if (sum == target)
                {
                    Console.WriteLine($"Found from index {left} to {right}");
                    return true;
                }
            }

            return false;
        }





        static void ReversePart(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }








        static int MinSwaps(int[] arr)
        {
            int n = arr.Length;

            // ربط القيمة مع index
            var indexed = arr
                .Select((value, index) => new { value, index })
                .OrderBy(x => x.value)
                .ToArray();

            bool[] visited = new bool[n];

            int swaps = 0;

            for (int i = 0; i < n; i++)
            {
                // إذا مرتب أو انزار قبل
                if (visited[i] || indexed[i].index == i)
                    continue;

                int cycleSize = 0;
                int j = i;

                while (!visited[j])
                {
                    visited[j] = true;
                    j = indexed[j].index;
                    cycleSize++;
                }

                if (cycleSize > 0)
                    swaps += (cycleSize - 1);
            }

            return swaps;
        }



        static int[] ReorderMinMax(int[] arr)
        {
            Array.Sort(arr);

            int n = arr.Length;
            int[] result = new int[n];

            int left = 0;
            int right = n - 1;
            int i = 0;

            while (left <= right)
            {
                if (left <= right)
                    result[i++] = arr[left++];

                if (left <= right)
                    result[i++] = arr[right--];
            }

            return result;
        }




        static int LongestRepeatedPattern(int[] arr)
        {
            int n = arr.Length;
            int maxLen = 0;

            for (int len = 1; len <= n / 2; len++) // طول الباترن
            {
                for (int i = 0; i + 2 * len <= n; i++) // نقطة البداية
                {
                    int count = 0;

                    while (i + (count + 1) * len <= n)
                    {
                        bool match = true;

                        for (int j = 0; j < len; j++)
                        {
                            if (arr[i + j] != arr[i + count * len + j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (!match) break;
                        count++;
                    }

                    if (count > 1)
                        maxLen = Math.Max(maxLen, len);
                }
            }

            return maxLen;
        }






        static void Main(string[] args)
        {











            int[] arr34 = { 1, 2, 3, 4, 5 };
            Rotate(arr34, 2);

            Console.WriteLine(string.Join(", ", arr34));




            int[] arr7 = { 1, 2, 4, 5 };

            Console.WriteLine(FindMissing(arr7));




            int[] arr33 = { 1, 2, 3, 1, 4, 2, 1 };

            Console.WriteLine(ShortestDistance(arr33));




            int[] arr22 = { 3, 1, 2, 4, 7, 6 };

            var result = Reorder(arr22);

            Console.WriteLine(string.Join(", ", result));




            int[] arr11 = { 1, 3, 2, 4, 1 };

            var result11 = FindPeaks(arr11);

            Console.WriteLine(string.Join(", ", result));





            int[] arr55 = { 2, 7, 11, 15 };
            int target = 9;

            var result2 = TwoSum(arr55, target);

            Console.WriteLine($"{result2.Item1}, {result2.Item2}");




            int[] arr10 = { 0, 1, 0, 3, 12 };

            MoveZeros(arr10);

            Console.WriteLine(string.Join(", ", arr10));





            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };

            var res = MergeAlternate(a, b);

            Console.WriteLine(string.Join(", ", res));




            int[] arr9 = { 1, 2, 1, 3, 2, 1 };
            CountFreq(arr9);






            int[] arr8 = { 5, 1, 9, 3, 9, 7 };

            Console.WriteLine(SecondMax(arr8));





            int[] arr4 = { 1, 2, 3, 7, 5 };
            SubarraySum(arr4, 12);


            int[] arr5 = { 1, 2, 3, 4, 5 };

            ReversePart(arr5, 1, 3);

            Console.WriteLine(string.Join(", ", arr5));





            int[] arr2= { 4, 3, 2, 1 };

            Console.WriteLine(MinSwaps(arr2));




            int[] arr = { 1, 2, 3, 4, 5, 6 };

            var res1 = ReorderMinMax(arr);

            Console.WriteLine(string.Join(", ", res1));


            int[] arr1 = { 1, 2, 1, 2, 1, 2, 3 };

            Console.WriteLine(LongestRepeatedPattern(arr1));
        }
    }
}
