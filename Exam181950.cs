using System;

namespace CodingTestIDE
{
    public class Exam181950 :Exam
    {
        public override void Run()
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            String s1 = input[0];
            int a = Int32.Parse(input[1]);
        
            String result = "";
            for (int i = 0; i < a; i++){
                result = result + s1;
            };
        
            Console.WriteLine(result);
        }
    }
}