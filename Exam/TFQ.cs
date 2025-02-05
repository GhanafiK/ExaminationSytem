using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class TFQ:Question
    {
        public TFQ()
        {
            Header = "\nTrue | False Question";
            correctAnswer = new Answer();
            AnswersList = new Answer[2];
            AnswersList[0]=new Answer(1,"True");
            AnswersList[1]=new Answer(2,"False");
        }

        public override void ShowQuestion()
        {
            Console.WriteLine(Header);

            do
            {
                Console.WriteLine("Please Enter The Body Of Question: ");
                Body = Console.ReadLine();
            } while (Body == null || Body == "");

            bool flag;
            int _mark;

            do
            {
                Console.Write("Please Enter the Marks of the Question: ");
                flag = int.TryParse(Console.ReadLine(), out _mark);
            } while (!flag || _mark < 0);

            mark = _mark;

            bool flagAns;
            int CorrectAnswer;
            do
            {
                Console.Write("Please Enter The Right Answer Of Question (1 for True , 2 for false ): ");
                flagAns=int.TryParse(Console.ReadLine(),out CorrectAnswer); 
            }while(!flagAns||!(CorrectAnswer is 1 or 2));

            correctAnswer.AnsId = CorrectAnswer;
            correctAnswer.AnsText = AnswersList[CorrectAnswer - 1].AnsText;

            Console.Clear();
        }
    }
}
