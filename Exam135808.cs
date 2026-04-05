using System;
using System.Linq;

namespace CodingTestIDE
{
    public class Exam135808 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            var k = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var score = Console.ReadLine().Split(',').Select(value => int.Parse(value)).ToArray();
            
            var result = 0;
            Array.Sort(score);
            Array.Reverse(score);
            int count = score.Count()/m;
            for (int i = 1; i <= count; i++)
            {
                var index = i * m - 1;
                result += score[index]*m;
            }
            
            Console.WriteLine(result);
        }
    }
}