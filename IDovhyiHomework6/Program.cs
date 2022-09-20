﻿using System;

namespace IDovhyiHomework6
{
    internal class Program
    {
        static int ReadNumber(int start, int end)
        {
            if ((start+1 == end) || (end < start))
            {
                Console.WriteLine("Further execution of this method is not possible");
                return start;
            }
        a1:
            Console.Write("Enter an integer in the range ({0},{1}) ", start, end);
            try
            {
                int value = int.Parse(Console.ReadLine());
                if ((value <= start) || (value >= end)) { throw new ApplicationException("This value is out of range"); }
                return value;
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
                goto a1;
            }
            catch (ApplicationException exception)
            {
                Console.WriteLine(exception.Message);
                goto a1;
            }
        }

        static void Main(string[] args)
        {
            int start, end;
        a2:
            try
            {
                Console.Write("Enter the first value of the range ");
                start = int.Parse(Console.ReadLine());
                Console.Write("Enter the last value of the range ");
                end = int.Parse(Console.ReadLine());
                if (start >= end) { throw new ApplicationException("he range entered is incorrect"); }

            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
                goto a2;
            }
            catch (ApplicationException exception)
            {
                Console.WriteLine(exception.Message);
                goto a2;
            }

            int[] a = new int[12];
            a[0] = start;
            a[11] = end;
            for (int i = 0; i < 10; i++)
            {
                start = ReadNumber(start, end);
                a[i + 1] = start;
            }
            Console.WriteLine("Sequence: ");
            for (int i = 0; i < 12; i++) Console.Write(a[i] +" ");
            Console.WriteLine();
            
        }
    }
}
