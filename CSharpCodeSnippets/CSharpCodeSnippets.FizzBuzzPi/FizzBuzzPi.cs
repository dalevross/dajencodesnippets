using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeSnippets.FizzBuzzPi
{
    public class FizzBuzzPi
    {
        List<Tuple<int, string>> Divisor_FizzBuzzTuples { get; set; }
        public Int32 Start { get; set; }
        public Int32 End { get; set; }
        public IEnumerable<string> FizzBuzzList { get; set; }
        public FizzBuzzPi(List<Tuple<int, string>> divisor_FizzBuzzTuples, Int32 start, Int32 end)
        {
            Divisor_FizzBuzzTuples = divisor_FizzBuzzTuples;
            Start = start;
            End = end;
        
        }

        public void GenerateFizzBuzzPi()
        { 
            Func<int, string> FizzBuzzify = i => GetFizzBuzzFromNumber(i);
            FizzBuzzList = Enumerable.Range(Start, End).Select(FizzBuzzify);
        }

        public override string ToString()
        {
            return (FizzBuzzList == null)?"No list has been generated":String.Join("\n", FizzBuzzList).TrimEnd("\n".ToCharArray());
        }
        
        public string GetFizzBuzzFromNumber(int number)
        {
            StringBuilder fizzbuzzbuilder = new StringBuilder();

            var list = Divisor_FizzBuzzTuples.OrderBy(i => i.Item1).Distinct();
            foreach (var tuple in list)
            {
                if (number % tuple.Item1 == 0)
                {
                    fizzbuzzbuilder.Append(tuple.Item2);
                }

            }

            string fizzbuzzornah = String.IsNullOrEmpty(fizzbuzzbuilder.ToString()) ? number.ToString() : fizzbuzzbuilder.ToString();

            return fizzbuzzornah;

        }
    }
}
