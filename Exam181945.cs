using System;

namespace CodingTestIDE
{
    public class Exam181945 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            var input = Console.ReadLine();
            var inputLength = input.Length;

            for (int i = 0; i < inputLength; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}