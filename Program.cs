﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Generics.FindMaxGenericsClass1;
using static Generics.FindMaxParameter;

namespace Generics
{
     public class Program
    {
        public static void Main(string[] args)
        {
            FindMaximum Number = new FindMaximum();
            Console.WriteLine("Welcome to the Generics Problem : ");
            Console.WriteLine("Please choose the option in below");
            Console.WriteLine("1:- Find Maximum Number\n" + "2:- Find Maximum Using Generics");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindMaximum.FindMaxValue(20, 40, 50);
                    FindMaximum.FindMaxValue(20.5f, 10.3f, 11.3f);
                    FindMaximum.FindMaxValue("zya", "zzz", "rew");
                    break;

                case 2:
                    GenericsFindMax<int>.FindMaxValue(14, 23, 12);
                    break;

                case 3:
                    new FindMaxGenericsClass<int>(20, 40, 50).TestMaximum();
                    new FindMaxGenericsClass<float>(20.5f, 10.3f, 11.3f).TestMaximum();
                    new FindMaxGenericsClass<string>("Apple", "Peach", "Banana").TestMaximum();
                    break;

                case 4:
                    FindMaxParams.MaxValue(45, 23, 54, 6, 23, 43);
                    FindMaxParams.MaxValue(45, 6, 23, 43);
                    break;


                default:
                    Console.WriteLine("Please choose the number given range");
                    break;
            }
            Console.ReadLine();
        }

    }
}

