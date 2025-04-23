// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static int FindMinPositive(int[] a)
    {
        HashSet<int> s = new HashSet<int>(a); // time , space :O(n) 
        int smallest = 1;// time , space :O(1)
        while (s.Contains(smallest))// truong hop xau nhat O(n)
        {
            smallest++;
        }
        return smallest;//O(1)
    }
    /// <summary>
    /// vay do phuc tap thoi gian :O(n)
    /// vay do phuc tap khong gian :O(n)
    /// </summary>
    public static void Main(string[] args)
    {
        int[] a = { -3, 0, 5, 3, 5, 1, 3, 2, -1, 1, 4, 8, 6, 10 };

        Console.WriteLine(FindMinPositive(a));
    }
}