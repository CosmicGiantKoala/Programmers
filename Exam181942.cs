using System;

namespace CodingTestIDE
{
    public class Exam181942 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            var result = string.Empty;
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            for (int i = 0; i < str1.Length; i++)
            {
                result += str1.Substring(i, 1) + str2.Substring(i,1);
            }
            
            Console.WriteLine(result);
        }
    }
}