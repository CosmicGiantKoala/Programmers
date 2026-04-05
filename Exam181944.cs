using System;

namespace CodingTestIDE
{
    public class Exam181944 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            var input = Console.ReadLine();
            var value = int.Parse(input);
            
            // %2만 해도 다 나눠짐
            while (value > 1)
            {
                value = value % 2;
            }

            if (value == 1)
            {
                Console.WriteLine($"{input} is odd");
            }
            else
            {
                Console.WriteLine($"{input} is even");
            }
        }
    }
}