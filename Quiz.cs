using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    abstract class Quiz
    {
        private int questNum;
        private string[] answers;
        private double correctedScore;
        private int posCorrector = 0;
        private List<int> IncorrectQuestions = new List<int> { 0, 1, 2, 3};
        private bool mistake = false;
        private int numberOfQuestions;

        public double Score { get; set; } = 0.0;
        public abstract void RunQuiz();

        private void PrintQuestionAndCallToCheck(string[] questions, string[] Answers, int QuestionNum)
        {                
            Console.WriteLine(questions[QuestionNum]);
            Console.WriteLine("");
            Console.WriteLine("enter answer: ");
            Console.WriteLine("");
            string answer = Console.ReadLine();
            questNum = QuestionNum;
            answers = Answers;
            CheckAnswerAndCallScore(answer);
        }

        private void CheckAnswerAndCallScore(string answer)
        {
            
            if(answers[questNum].ToLower() == answer.ToLower())
            {
                Console.WriteLine("correct");
                IncorrectQuestions.Remove(questNum);
                if (mistake == false)
                {
                    Score += 100 / numberOfQuestions;
                }
                else
                {
                    correctedScore += 100 / numberOfQuestions;
                }
                posCorrector++;
            }
            else
            {
                Console.WriteLine("incorrect");
             
            }
            
        }


        protected void ReturnScore(string[] questions, string[] answers, int NumOQuest)
        {
            numberOfQuestions = NumOQuest;
            
            for (int i = 0; i < numberOfQuestions; i++)
            {
                PrintQuestionAndCallToCheck(questions, answers, IncorrectQuestions[i-posCorrector]);
            }
            


            if (IncorrectQuestions.Count > 0) 
            {
                correctedScore = Score;
                
                Console.WriteLine("try the questions that were wrong?(enter y/n)");

                string correctMistakes = Console.ReadLine();

                while (correctMistakes == "y")
                {
                    mistake = true;
                    posCorrector = 0;
                    int incorrectListLength = IncorrectQuestions.Count;
                    for (int j = 0; j < incorrectListLength; j++)
                    {
                        PrintQuestionAndCallToCheck(questions, answers, IncorrectQuestions[j - posCorrector]);
                    }
                    if (IncorrectQuestions.Count > 0)
                    {
                        Console.WriteLine("try the questions that were wrong?(enter y/n)");

                        correctMistakes = Console.ReadLine();
                    }
                    else
                    {
                        correctMistakes = "no";
                    }
  
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"your score is : {Score}");
            
            if (mistake == true)
            {
                Console.WriteLine($"your corrected score {correctedScore}");
            }


        }

    }
}
