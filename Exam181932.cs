using System;

namespace CodingTestIDE
{
    public class Exam181932 :Exam
    {
        public override void Run()
        {
            var code = Console.ReadLine();

            var answer = "";
            var charArray = code.ToCharArray();
            var evenMode = true;
            
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '1')
                {
                    evenMode = ToggleMode(evenMode);
                }
                else
                {
                    if (evenMode && IsEven(i)) answer = answer + charArray[i];
                    if (evenMode == false && IsOdd(i)) answer = answer + charArray[i];
                }
            }

            if (answer.Length == 0)
            {
                Console.WriteLine("EMPTY");                
            }
            else
            {
                Console.Write(answer);
            }
        }

        private bool IsEven(int idx) => idx % 2 == 0;
        private bool IsOdd(int idx) => idx % 2 != 0;
        private bool ToggleMode(bool mode) => !mode;
    }
}