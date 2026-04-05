using System;

namespace CodingTestIDE
{
    public class Exam181946 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            var input = Console.ReadLine().Split(' ');
            
            var a = input[0];
            var b = input[1];
            
            Console.WriteLine(a+b);
        }
    }
}