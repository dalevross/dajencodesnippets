using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeSnippets
{
    class Program
    {

        static List<Tuple<int, string>> Divisor_FizzBuzzTuples = new List<Tuple<int, string>>();
            
        static void Main(string[] args)
        {
            int rangeStart = 1;
            int rangeEnd = 300;
            Divisor_FizzBuzzTuples.Add(new Tuple<int,string>(3,"Fizz"));
            Divisor_FizzBuzzTuples.Add(new Tuple<int, string>(5, "Buzz"));
            Divisor_FizzBuzzTuples.Add(new Tuple<int, string>(7, "Pi"));            
            Divisor_FizzBuzzTuples.Add(new Tuple<int, string>(15, "FizzBuzz"));
            Divisor_FizzBuzzTuples.Add(new Tuple<int, string>(21, "FizzPi"));
            Divisor_FizzBuzzTuples.Add(new Tuple<int, string>(35, "BuzzPi"));
            Divisor_FizzBuzzTuples.Add(new Tuple<int, string>(105, "FizzBuzzPi"));

            Func<int, string> FizzBuzzify = i => GetFizzBuzzFromNumber(i);
            var fizzBuzzList = Enumerable.Range(rangeStart, rangeEnd).Select(FizzBuzzify);
            Console.Write(String.Join("\n", fizzBuzzList).TrimEnd("\n".ToCharArray()));

        }

        static string GetFizzBuzzFromNumber(int number)
        {
            string fizzbuzzornah = number.ToString();

            var list = Divisor_FizzBuzzTuples.OrderByDescending(i => i.Item1);
            foreach (var tuple in list)
            { 
                if(number % tuple.Item1 == 0)
                {
                    fizzbuzzornah = tuple.Item2;
                    break;
                }
            
            }

            return fizzbuzzornah;
        
        }
    }
}
