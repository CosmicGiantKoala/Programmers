using System;

namespace CodingTestIDE
{
    public class Exam181941 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            var arr = Console.ReadLine().Split(',');
            var result = string.Empty;

            result = string.Join("", arr);
            Console.WriteLine(result);
        }
    }
}