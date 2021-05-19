using System;

namespace Algos3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // int[] a = {1,2,3};
            // int[] b = {3,2,1};
            // ArrAdd();
            // ArrCompare();
            // Console.WriteLine(BinDec("1100011001"));
            // Console.WriteLine(BinDec("100"));
            // Console.WriteLine(BinZero("1100011001"));
            // Console.WriteLine(DecToBin(102));
            // Console.WriteLine(BinDec("110110001"));
            Console.WriteLine(BinaryGap(1162));
            Console.WriteLine("****BREAK****");
            Console.WriteLine(BinaryGap(80270300));


        }

        public static int BinaryGap(int num)
        {
            int[] p = new int[100];
            string pa = "";
            // int count = 0;
            for (int ii = 0; ii <= 99; ii = ii + 1)
            {
                p[99 - ii] = num % 2;
                num = num / 2;
            }
            for (int ii = 0; ii <= 99; ii = ii + 1)
            {
                if (pa.Length == 0){
                    if(p[ii] == 1){
                        pa += p[ii].ToString();
                    }
                }
                else{
                    pa += p[ii].ToString();
                }
            }

            Console.WriteLine(pa);

            char[] array = pa.ToCharArray();
            // Array.Reverse(array);
            int count = 0;
            // int count1 = 0;
            // int count2 = 0;
            int final = 0;

            for (int i = 0; i < array.Length; i++)
            {
                // Console.WriteLine(array[i]);
                if (array[i] == '1' && count == 0)
                {
                    
                    // Console.WriteLine(count);
                }
                else if(array[i] == '0')
                {
                    count += 1;
                    
                }
                else if(array[i] == '1' && count > 0){
                    Console.WriteLine($"Binaray length is {count}");
                    if(count > final){
                        final = count;
                    }
                    count = 0;
                }
            }
            Console.WriteLine($"Largest binary gap is {final}");
            return final;
        }
        

        //Convert Binary to Decimal:
        static int BinDec(string input){
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            int sum = 0;

            for(int i = 0; i < array.Length; i++){
                if(array[i] == '1'){
                    if(i == 0){
                        sum += 1;
                    }
                    else {
                        sum += (int)Math.Pow(2, i);
                    }
                }
            }
            return sum;
        }

        // Count Binary Gap.
        static int BinZero(string input){
            char[] array = input.ToCharArray();
            // Array.Reverse(array);
            int count = 0;
            // int count1 = 0;
            // int count2 = 0;
            int final = 0;

            for (int i = 0; i < array.Length; i++)
            {
                // Console.WriteLine(array[i]);
                if (array[i] == '1' && count == 0)
                {
                    
                    // Console.WriteLine(count);
                }
                else if(array[i] == '0')
                {
                    count += 1;
                    
                }
                else if(array[i] == '1' && count > 0){
                    Console.WriteLine($"Binaray length is {count}");
                    if(count > final){
                        final = count;
                    }
                    count = 0;
                }
            }
            return final;
        }
        //Codility Code( 
//             using System;
// // you can also use other imports, for example:
// // using System.Collections.Generic;

// // you can write to stdout for debugging purposes, e.g.
// // Console.WriteLine("this is a debug message");

// class Solution
//     {
//         public int solution(int N)
//         {
//             int[] p = new int[20];
//             string pa = "";

//             for (int ii = 0; ii <= 19; ii++)
//             {
//                 p[19 - ii] = N % 2;
//                 N = N / 2;
//             }
//             for (int ii = 0; ii <= 19; ii++)
//             {
//                 if (pa.Length == 0)
//                 {
//                     if (p[ii] == 1)
//                     {
//                         pa += p[ii].ToString();
//                     }
//                     else
//                     {
//                         pa += p[ii].ToString();
//                     }
//                 }
//             }

//             char[] array = pa.ToCharArray();
//             int count = 0;
//             int count1 = 0;
//             int count2 = 0;
//             int final = 0;

//             for (int i = 0; i < array.Length; i++)
//             {
//                 if (array[i] == '1' && count == 0)
//                 {

//                 }
//                 else if (array[i] == '0')
//                 {
//                     count += 1;
//                 }
//                 else if (array[i] == '1' && count > 0)
//                 {
//                     if (count1 == 0)
//                     {
//                         count1 = count;
//                     }
//                     else
//                     {
//                         count2 = count;
//                     }
//                     count = 0;
//                 }
//             }
//             if (count1 > count2)
//             {
//                 final = count1;
//             }
//             else
//             {
//                 final = count2;
//             }

                // return final;
//             // write your code in C# 6.0 with .NET 4.5 (Mono)
//         }
//     }
//         )

        // static void ArrAdd()
        // {
        //     int[] numArr = { 9, 20, 5, 18, 3 };
        //     int sum = 0;
        //     foreach (int i in numArr)
        //     {
        //         sum += i;
        //     }
        //     Console.WriteLine(sum);
        // }

        // static void ArrCompare()
        // {
        //     int[] a = { 1,2,3 };
        //     int[] b = { 3,2,1 };
        //     int[] c = { 0,0 };
        //     for(int i = 0; i < a.Length; i++){
        //         if(a[i] > b[i])
        //         {
        //             c[0] += 1;
        //             Console.WriteLine(c[0]);
        //         }
        //         else if (a[i] == b[i])
        //         {
        //             Console.WriteLine("draw");
        //         }
        //         else {
        //             if(a[i] < b[i]){
                
        //             c[1] += 1;
        //             Console.WriteLine(c[1]);
        //             }
        //         }
                
                
        //     }
        //     Console.Write(c[0]);
        //     Console.Write("," + c[1]);
        //     return;
        // }

        //How do I find the index number of a letter? - 
        // 1. LocalDataStoreSlot Alphabet in string & loop through
        // 2. Array of letters 0-25 (A-Z).
        // 3. Use Binary for each letter.
        // 4. Dictionary. "A':0, "B":1
        // 5. Children[26] for characters
        // 6. ASCII - 
    }
}


// static List compareTriplets(List a, List b)
// {
//     List score = new List(new int[] { 0, 0 }); int i = 0;

//     for (i = 0; i < count(a); i++)
//     {
//         if (a[i] > b[i])
//         {
//             score[0] += 1;
//         }
//         else if (a[i] == b[i])
//         {
//             score[0] += 0;
//             score[1] += 0;
//         }
//         else
//         {
//             score[1] += 1;
//         }
//     }
//     return score;

// }

// static int count(List<int> aList)
// {
//     int counter = 0;
//     foreach (var item in aList)
//     {
//         counter++;
//     }
//     return counter;
// }