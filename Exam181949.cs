using System;

namespace CodingTestIDE
{
    public class Exam181949 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            var s = Console.ReadLine();
            var result = string.Empty;
            var stringLength = s.Length;
            var c = s.ToCharArray();
        
            for (var i=0;i<stringLength;i++){
                if (char.IsUpper(c[i])){
                    result += char.ToLower(c[i]);
                } else
                {
                    result += char.ToUpper(c[i]);
                }
            }
        
            Console.WriteLine(result);
        }
    }
}