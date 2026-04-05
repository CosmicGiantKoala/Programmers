using System;

namespace CodingTestIDE
{
    public class Exam181947 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            var value = Console.ReadLine().Split(' ');
            
            var a = int.Parse(value[0]);
            var b = int.Parse(value[1]);
            
            Console.WriteLine($"{a} + {b} = {a+b}");
            
        }
    }
}