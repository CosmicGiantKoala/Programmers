using System;

namespace CodingTestIDE
{
    public class Exam181951 : Exam
    {
        public override void Run()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            Console.WriteLine($"a = {s[0]}");
            Console.WriteLine($"b = {s[1]}");
        }
    }
}