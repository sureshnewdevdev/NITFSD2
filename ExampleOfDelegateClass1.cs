﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NITFSD2
{
    
    public class ExampleOfDelegateClass1
    {
        int[] results=new int[3];
        public delegate int MyDelegateFunction(int first, int second);
        public void DoWork()
        {
            MyDelegateFunction myFunction = new MyDelegateFunction(Subtract);

            var ans = myFunction(10, 90);

            Console.WriteLine("Answer = " + ans);

        }

        private int Add(int first, int second)
        {
            return first + second;
        }
        private int Subtract(int first, int second)
        {
            return first - second;
        }
        private int Multiplication(int first, int second)
        {
            return first * second;
        }
    }
}
