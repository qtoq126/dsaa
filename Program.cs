﻿using DataStructure.Chapter1.Week2;
using DataStructure.Chapter1.Week4;
using DataStructure.Chapter2.Week5;
using DataStructure.Chapter2.Week6;
using DataStructure.Leetcode;
using DataStructure.Test;
using System;
using static DataStructure.Leetcode.ReverseList;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 72, 93, 40, 76, 35 };


            var arr1 = ArrayTestHelper.GeneratorArray(100000, 100000);
            var arr2 = (int[])arr1.Clone();

            ArrayTestHelper.SortTest("MergeSort", arr1);
            ArrayTestHelper.SortTest("QuickSort", arr2);

            //Console.WriteLine(arr1[0]);



            //QuickSort.Partition(ref arr1, 0, arr1.Length - 1);

            //DateTime afterDT = System.DateTime.Now;

            ////Console.WriteLine(string.Join(",", arr));

            //var ts = afterDT.Subtract(startTime);
            //Console.WriteLine($"bobo: n={arr1.Length}, 总耗时={ts.TotalSeconds}s.");
            //Console.WriteLine(string.Join(",", arr1));



            //startTime = System.DateTime.Now;


            //QuickSort.Partition2(ref arr2, 0, arr2.Length - 1);

            // afterDT = System.DateTime.Now;

            ////Console.WriteLine(string.Join(",", arr));

            // ts = afterDT.Subtract(startTime);
            //Console.WriteLine($"myself: n={arr2.Length}, 总耗时={ts.TotalSeconds}s.");
            //Console.WriteLine(string.Join(",", arr2));




            //var listNode = new ListNode(nums);
            //var obj = new ReverseList();
            //obj.Head = listNode;
            //Console.WriteLine(obj.ToString());
            //obj.Head = ReverseByRecursion(listNode);
            //Console.WriteLine(obj.ToString());
            //SelectionSort.Sort(ref nums);
            //MergeSort.Sort(ref nums);
            //Console.WriteLine(string.Join(",", nums));

            //var arr1 = ArrayTestHelper.GeneratorArray(1000, 1000);
            //var arr2 = (int[])arr1.Clone();

            // ArrayTestHelper.SortTest("InsertSort", arr1);
            //ArrayTestHelper.SortTest("MergeSort", arr1);
            //ArrayTestHelper.SortTest("MergeSortBU", arr2);
        }

        ////测试使用q运行opCount个进队和出队操作所需要的时间，单位：秒
        //public static double testQueue(iQueue<int> q, int count)
        //{
        //    Random r = new Random();
        //    var startTime = System.DateTime.Now;

        //    for (int i = 0; i < count; i++)
        //    {
        //        q.Enqueue(r.Next(int.MaxValue));
        //    }
        //    for (int i = 0; i < count; i++)
        //    {
        //        q.Dequeue();
        //    }

        //    var endTime = System.DateTime.Now;
        //    var ts = endTime - startTime;
        //    return ts.Milliseconds;
        //}
    }
}