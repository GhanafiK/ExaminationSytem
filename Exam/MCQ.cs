using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class MCQ:Question
    {
        public MCQ()
        {
            Header = "\nChoose One Answer Question";
            correctAnswer = new Answer();
            AnswersList = new Answer[3];
        }

        public override void ShowQuestion()
        {
            Console.WriteLine(Header);
            do
            {
                Console.WriteLine("Please Enter The Body Of Question: ");
                Body = Console.ReadLine();
            }while(Body == null||Body=="");

            bool flag;
            int _mark;

            do
            {
                Console.Write("Please Enter the Marks of the Question: ");
                flag = int.TryParse(Console.ReadLine(), out _mark);
            } while (!flag || _mark <= 0);
            mark = _mark;

            Console.WriteLine("The Choices of Question:");
            for(int i = 0;i<AnswersList.Length;i++)
            {
                AnswersList[i] = new Answer();
                AnswersList[i].AnsId = i + 1;
                do
                {
                    Console.Write($"Please Enter The Choice Number {i+1}: ");
                    AnswersList[i].AnsText = Console.ReadLine();
                }while(AnswersList[i].AnsText == null || AnswersList[i].AnsText=="");
            }

            int CorrectAnswerId;
            bool flagAns;
            do
            {
                Console.Write("Please Specify The Right Choice of Question: ");
                flagAns = int.TryParse(Console.ReadLine(),out CorrectAnswerId);
            } while (!flagAns || !(CorrectAnswerId is 1 or 2 or 3));

            correctAnswer.AnsId= CorrectAnswerId;
            correctAnswer.AnsText = AnswersList[CorrectAnswerId - 1].AnsText;

            Console.Clear();
        }
    }
}
