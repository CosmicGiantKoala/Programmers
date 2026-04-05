using System;
using System.Linq;

namespace CodingTestIDE
{
    public class Exam12909 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            var input = Console.ReadLine().ToCharArray();
            
            var result = false;
            if (input[0] == '(' && input[input.Length-1] == ')')
            {
                int counter = 0;
                foreach (var value in input)
                {
                    if (value == '(') counter++;
                    else counter--;

                    if (counter < 0) break;
                }
                
                if (counter == 0) result = true;
            }
            
            Console.WriteLine(result);
        }
    }
}