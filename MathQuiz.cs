using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    class MathQuiz : Quiz
    {
        private string[] questions;
        private string[] answers;
        private int questNum;
        public MathQuiz(string[] Questions ,string[] Answers, int QuestNum)
        {
            questions = Questions;
            answers = Answers;
            questNum = QuestNum;
        }
       
        override public void RunQuiz()
        {
           ReturnScore(questions, answers, questNum);            
        }

    }
}
