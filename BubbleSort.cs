
using System;

public class HelloWorld
{
    // Pseudo code for Bubble Sort
    // BUBBLE_SORT(a, n):
    //     FOR i = 0 TO n-1 DO:
    //         FOR j = 0 TO n-i-1 DO:
    //              IF a[j] < a[j+1] THEN:
    //                 continue
    //              Swap(a[j] ,a[j+1])
    //     END FOR
    // END FOR

    public static void BubbleSort(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                int t = 0;
                if (a[j] < a[j + 1]) continue;
                t = a[j];
                a[j] = a[j + 1];
                a[j + 1] = t;
            }
        }
    }

    public static void Main(string[] args)
    {
        int n = 100;
        int[] a = new int[100];
        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            a[i] = r.Next(0, 1000);
        }

        BubbleSort(a, n);

        foreach (int i in a)
            Console.WriteLine(i);

    }
}