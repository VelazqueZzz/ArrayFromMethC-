using System;
using System.Diagnostics.SymbolStore;

class ArrayFromMethDemo
{
    static int[] fibs(int n)
    {
        int[] nums = new int[n];
        nums[0] = 1;
        if (nums.Length == 1) return nums;
        nums[1] = 1;
        for(int k = 2; k < nums.Length; k++)
        {
            nums[k] = nums[k - 1] + nums[k - 2];
        }
        return nums;
    }
    static char[] rands(int n)
    {
        Random rnd = new Random();
        char[] symbs = new char[n];
        for(int k = 0; k<symbs.Length; k++)
        {
           symbs[k] = (char)('A' + rnd.Next(26));
        }
        return symbs;
    }
    static int[,] odds(int m,int n)
    {
        int[,] nums = new int[m, n];
        int val = 1;
        for(int i = 0; i < nums.GetLength(0); i++)
        {
            for(int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = val;
                val += 2;
            }
        }
        return nums;
    }
    static void Main()
    {
        int[] A;
        char[] B;
        int[,] C;
        A = fibs(20);
        Console.WriteLine("Chisla Fibbonachi:");
        foreach(int s in A)
        {
            Console.Write("| {0}", s);

        }
        Console.WriteLine("|");
        B = rands(8);
        Console.WriteLine("Sluchinie simvoli:");
        foreach(char s in B)
        {
            Console.Write("| {0}", s);

        }
        Console.WriteLine("|");
        C = odds(6, 6);
        Console.WriteLine("Dvumernii massiv:");
        for(int i = 0; i < C.GetLength(0); i++)
        {
            for(int j=0; j < C.GetLength(1); j++)
            {
                Console.Write("{0,4}", C[i, j]);

            }
            Console.WriteLine();
        }
    }
}