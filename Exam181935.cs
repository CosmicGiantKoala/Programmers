using System;

namespace CodingTestIDE
{
    public class Exam181935 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            var input = int.Parse(Console.ReadLine());
            var result = 0;
            result = input % 2 == 0 ? Even(input) : Odd(input);
            Console.Write(result);
        }
        
        private int Even(int n){
            var result = 0;
            while (n>0){
                result += n*n;
                n -= 2;
            }
            return result;
        }
    
        private int Odd(int n){
            var result = 0;
            while (n>0){
                result += n;
                n -= 2;
            }
            return result;
        }
    }
}