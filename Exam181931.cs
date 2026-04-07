using System;
using System.Linq;

namespace CodingTestIDE
{
    public class Exam181931 : Exam
    {
        public override void Run()
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            var input3 = Console.ReadLine();
            var array = input3.Split(',');

            int a = int.Parse(input1);
            int d = int.Parse(input2);
            bool[] included = array.Select(value => value == "t" || value == "true").ToArray();

            int answer = 0;
            int additive = a;
            foreach (var value in included)
            {
                if (value) answer = answer + additive;
                additive = additive + d;
            }
            
            
            Console.WriteLine(answer);

        }
    }
}