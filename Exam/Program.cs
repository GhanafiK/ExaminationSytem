using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject s1 = new Subject(10, "c#");
            s1.CreateExam();

            char startExam;
            bool checkflag;

            do
            {
                Console.Write("Do you want to Start Exam (Y|N): ");
                checkflag=char.TryParse(Console.ReadLine(), out startExam);
            }while (!checkflag || !(char.ToLower(startExam) is 'y' or 'n')) ;

            if(char.ToLower(startExam) == 'y')
            {
                Stopwatch sw = new Stopwatch();

                sw.Start();

                s1.Exam.ShowExam();

                sw.Stop();

                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }

        }
    }
}
