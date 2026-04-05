using System;

namespace CodingTestIDE
{
    public class Exam181934 : Exam
    {
        public override void Run()
        {
            Console.Clear();
            int answer = 0;
            var ineq = Console.ReadLine();
            var eq = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var oper = ineq + eq;
            switch (oper){
                case ">=" : 
                    answer = EqualLarger(n,m);
                    break;
                case "<=" :
                    answer = EqualLess(n,m);
                    break;
                case ">!" :
                    answer = Larger(n,m);
                    break;
                case "<!" :
                    answer = Less(n,m);
                    break;
            }
            
            Console.WriteLine(answer);
        }
        
        private int Larger(int n, int m){
            return n>m ? 1: 0;
        }
    
        private int Less(int n, int m){
            return n<m ? 1:0;
        }
    
        private int EqualLarger(int n, int m){
            return n>=m ? 1:0;
        }
    
        private int EqualLess(int n, int m){
            return n<=m ? 1:0;
        }
    }
}