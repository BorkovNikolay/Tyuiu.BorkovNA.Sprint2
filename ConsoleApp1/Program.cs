﻿using System;





namespace Tyuiu.BorkovNA.Sprint2.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 4;

            int y = 7;

            if (a > 3 * b) y++;

            else y += a - 2 * b;

            Console.WriteLine(y);
        }
    }

}