using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class FinalExam:BaseExam
    {
        public FinalExam(int _Time, int _NumOfQuestions)
        {
            Time = Time;
            NumberOfQuestion = _NumOfQuestions;
        }

        public override void CreateExam()
        {
            QuestionArr = new Question[NumberOfQuestion];
            for (int i = 0; i < QuestionArr.Length; i++)
            {
                Console.WriteLine($"(Question{i + 1})");
                bool QFlag;
                int QType;
                do
                {
                    Console.Write($"Please Choose the Type of Question Number {i+1} (1 For True or False | 2 For MCQ ): ");
                    QFlag = int.TryParse(Console.ReadLine(), out QType);
                } while (!QFlag || !(QType is 1 or 2));

                if (QType == 1)
                {
                    QuestionArr[i] = new TFQ();
                    QuestionArr[i].ShowQuestion();
                }
                else
                {
                    QuestionArr[i] = new MCQ();
                    QuestionArr[i].ShowQuestion();
                }
            }
        }
        public override void ShowExam()
        {
            if (QuestionArr?.Length > 0)
            {
                int grade = 0;
                int AllQuestionsGrade = 0;
                int[] userAns = new int[QuestionArr.Length];
                for (int i = 0; i < QuestionArr.Length; i++)
                {
                    AllQuestionsGrade += QuestionArr[i].mark;
                    Console.WriteLine($"{QuestionArr[i].Header}     Mark({QuestionArr[i].mark})");
                    Console.WriteLine(QuestionArr[i].Body);

                    for (int j = 0; j < QuestionArr[i].AnswersList.Length; j++)
                    {
                        Console.Write($"{j + 1}- {QuestionArr[i].AnswersList[j]}         ");
                    }

                    Console.WriteLine("\n-----------------------------------------------");

                    int ansId;
                    bool validAns;
                    do
                    {
                        validAns = int.TryParse(Console.ReadLine(), out ansId);
                    } while (!validAns || !(ansId is 1 or 2 or 3));

                    userAns[i] = ansId - 1;

                    if (ansId == QuestionArr[i].correctAnswer.AnsId)
                        grade += QuestionArr[i].mark;
                }

                Console.Clear();
                Console.WriteLine("Your Exam Demo Answers:\n");

                for (int i = 0; i < QuestionArr.Length; i++)
                {
                    Console.WriteLine($"Q{i + 1})  {QuestionArr[i].Body}");
                    if(QuestionArr[i].AnswersList[userAns[i]].AnsId==QuestionArr[i].correctAnswer.AnsId)
                    {
                        Console.WriteLine($"Your Answer: {QuestionArr[i].AnswersList[userAns[i]]} is correct\n");
                    }
                    else
                    {
                        Console.WriteLine($"Your Answer: {QuestionArr[i].AnswersList[userAns[i]]} , Correct Answer: {QuestionArr[i].correctAnswer}\n");
                    }
                }

                Console.WriteLine($"\nYour Exam Grade is {grade} From {AllQuestionsGrade}");
            }
        }
    }
}
