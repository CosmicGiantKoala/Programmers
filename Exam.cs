using System.Collections.Generic;

namespace CodingTestIDE
{
    public abstract class Exam
    {
        public static Dictionary<int,Exam> Exams = new Dictionary<int, Exam>();
        public static void AddExam(int id, Exam exam)
        {
            Exams.Add(id,exam);
        }

        public abstract void Run();
    }
}