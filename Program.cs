using System;

namespace CodingTestIDE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Install();
            
            Console.Write("ExamNumber ?");
            var id = int.Parse(Console.ReadLine() ?? string.Empty);
            Exam.Exams[id].Run();
        }

        private static void Install()
        {
            var exam181952 = new Exam181952();
            Exam.AddExam(181952, exam181952);
            
            var exam181951 = new Exam181951();
            Exam.AddExam(181951, exam181951);
            
            var exam181950  = new Exam181950();
            Exam.AddExam(181950, exam181950);
            
            var exam181949 = new Exam181949();
            Exam.AddExam(181949, exam181949);
            
            var exam181948 = new Exam181948();
            Exam.AddExam(181948, exam181948);
            
            var exam181947 = new Exam181947();
            Exam.AddExam(181947, exam181947);
            
            var exam181946 = new Exam181946();
            Exam.AddExam(181946, exam181946);
            
            var exam181945 = new Exam181945();
            Exam.AddExam(181945, exam181945);
            
            var exam181944 = new Exam181944();
            Exam.AddExam(181944, exam181944);
            
            var exam181943 = new Exam181943();
            Exam.AddExam(181943, exam181943);
            
            var exam181942 = new Exam181942();
            Exam.AddExam(181942, exam181942);
            
            var exam181941 = new Exam181941();
            Exam.AddExam(181941, exam181941);
            
            var exam181935 = new Exam181935();
            Exam.AddExam(181935, exam181935);
            
            var exam181934 = new Exam181934();
            Exam.AddExam(181934, exam181934);
            
            var exam135808 = new Exam135808();
            Exam.AddExam(135808, exam135808);
            
            var exam12909 = new Exam12909();
            Exam.AddExam(12909, exam12909);
            
            var exam181932 = new Exam181932();
            Exam.AddExam(181932, exam181932);
            
            var exam181931 = new Exam181931();
            Exam.AddExam(181931, exam181931);
            
            var exam468371 = new Exam468371();
            Exam.AddExam(468371, exam468371);
        }
    }
}