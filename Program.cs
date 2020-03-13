using System;

namespace Trivia
{
    class Program
    {

        private static string[][] Questions(string quizName)
        {
            string Mathquest1 = "5X/3 - X/9 = 7? \n \n find X ";
            string Mathquest2 = "what is the integral of : 2X^2 + 23X - 22 ? \n \n A. (2x^3)/3 + 11.5x^2 -22x + c  B. (2x^3)/3 + 11.5x^2 -22x  C. x^3 + 23x^2 -22x";
            string Mathquest3 = "what is the Derivative(nigzeret) of : 5X^3 + 8X^2 + 9X +3 ? \n \n A. 13X^2 + 16X + 9  B. 15X^2 + 15X + 9  C. 15X^2 + 16X + 9 ";
            string Mathquest4 = "20 % of 2 is equal to \n \n  A. 20  B. 4  C. 0.4  D. 0.04";
            

            string Historyquest1 = "who was the first president of israel? \n \n  A. David Ben Gurion  B. Theodor Herzl  C. Menahem Begin";
            string Historyquest2 = "who was the first president of the USA? \n \n   A. Abraham Lincoln  B. George washington  C. John Kennedy";
            string Historyquest3 = "who was the firstLeader of the 'Tzionot' group? \n \n  A.Theodor Herzl  B. Eliezer Ben Yehuda C. Rothschild ";
            string Historyquest4 = "when has the first world war satrted? \n \n A. 1913  B. 1918  C. 1915  D. 1914";

            string MathAnswer1 = "4.5";
            string MathAnswer2 = "a";
            string MathAnswer3 = "c";
            string MathAnswes4 = "c";

            string HistoryAnswer1 = "a";
            string HistoryAnswer2 = "b";
            string HistoryAnswer3 = "a";
            string HistoryAnswer4 = "d";

            string[] mathAns = new string[4] { MathAnswer1, MathAnswer2 , MathAnswer3 , MathAnswes4}; 
            string[] mathQuest = new string[4] { Mathquest1, Mathquest2, Mathquest3 , Mathquest4};

            string[] historyQuest = new string[4] { Historyquest1, Historyquest2, Historyquest3 , Historyquest4};
            string[] historyAns = new string[4] { HistoryAnswer1, HistoryAnswer2, HistoryAnswer3 , HistoryAnswer4};

            string[][] HistoryArr = new string[2][] { historyQuest, historyAns };
            string[][] MathArr = new string[2][] { mathQuest, mathAns };
            
            if (quizName == "a") { return MathArr; }

            if (quizName == "b") { return HistoryArr; }

            return null; // does't understand that it went thru tests
        }

        static void Main(string[] args)
        {

            string quiz = GetQuizAndCheck();
            int NumOQuizQuest = 4;

            while (quiz != "c")
            {
                Quiz q=null;
                string[][] dataArray = Questions(quiz);
                if (quiz == "a")
                {
                    q = new MathQuiz(dataArray[0], dataArray[1], NumOQuizQuest);
                }
                if (quiz == "b")
                {
                   q = new HistoryQuiz(dataArray[0], dataArray[1] ,NumOQuizQuest); 
                }
                q.RunQuiz();
                quiz = GetQuizAndCheck();

            }
        }

        private static string GetQuizAndCheck()
        {
            string quiz;
            while (true)
            {
                Console.WriteLine("welcome, choose a quiz(type it  the letter) :");
                Console.WriteLine("A. Math     B.History   C.Exit");
                quiz = Console.ReadLine().ToLower();
                if (quiz == "a" || quiz == "b" || quiz == "c")
                {
                    return quiz;
                }
                else
                {
                    ErrorMessage();
                }
                
            }

            
        }
        private static void ErrorMessage()
        {
            Console.WriteLine("enter one of the options not anything else" );
        }

    }
}
