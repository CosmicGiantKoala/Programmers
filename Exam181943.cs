using System;

namespace CodingTestIDE
{
    public class Exam181943 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            var myString = Console.ReadLine();
            var overwriteString = Console.ReadLine();
            var index = Int32.Parse(Console.ReadLine());
            var result = myString.Substring(0,index);
            result = result + overwriteString;
            if (myString.Length > result.Length)
            {
                var result2 = myString.Substring(result.Length);
                result = result + result2;
            }
            Console.WriteLine(result);
        }
    }
}