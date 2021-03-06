﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCodeSnippets.FizzBuzzPi;

namespace CSharpCodeSnippets
{
    class Program
    {

            
        static void Main(string[] args)
        {
            List<Tuple<int,string>> fbpTuples = new List<Tuple<int,string>>();
            fbpTuples.Add(new Tuple<int,string>(3,"Fizz"));
            fbpTuples.Add(new Tuple<int,string>(5,"Buzz"));
            fbpTuples.Add(new Tuple<int,string>(7,"Pi"));
            FizzBuzzPi.FizzBuzzPi fbp = new FizzBuzzPi.FizzBuzzPi(fbpTuples, 1, 300);
            fbp.GenerateFizzBuzzPi();
            Console.WriteLine(fbp);
            Console.ReadKey();          

        }

        
    }
}
