using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.data
{
    internal class Question
    {
        string question { get; }
        string rightAnswer { get; }
        string[] wrongAnswers { get; }


        /// <summary>
        /// constructor to initialise the object.
        /// </summary>
        public Question(string question, string rightAnswer, string[] wrongAnswers) { 
        
            this.question = question;
            this.rightAnswer = rightAnswer; 
            this.wrongAnswers = wrongAnswers; 

        }

        /// <summary>
        /// This will return an list with all the questions randomly mixed in.
        /// </summary>
        public string[] getRandomMixedQuestions() {
            string[] allAnswers = new string[4];
            wrongAnswers.CopyTo(allAnswers, 0);
            allAnswers[3] = rightAnswer;
            

            //shuffle the questions and return them

            Random rand = new Random();
      
            return  allAnswers.OrderBy(x => rand.Next()).ToArray(); ;

        }
    }
}
