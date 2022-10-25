using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{
    public partial class SinglePlayerForm : Form
    {
        //game variables

        int score;
        int questionNumber = 1;
        int correctAnswer;
        int totalQuestions;
        



        public SinglePlayerForm()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private protected void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private protected void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    richTextBoxQuestionBox.Text = "What is the main component of the sun?";
                    button1.Text = "Liquid Lava";
                    button2.Text = "Gas";
                    button3.Text = "Molten Iron";
                    button4.Text = "Rock";

                    correctAnswer = 2;
                    break;

                case 2:
                    richTextBoxQuestionBox.Text = "What was the first country to use tanks in combat during World War I?";
                    button1.Text = "France";
                    button2.Text = "Japan";
                    button3.Text = "Britain";
                    button4.Text = "Germany";

                    correctAnswer = 3;
                    break;

                case 3:
                    richTextBoxQuestionBox.Text = "Goulash is a type of beef soup in which country?";
                    button1.Text = "Hungary";
                    button2.Text = "Czech Republic";
                    button3.Text = "Slovakia";
                    button4.Text = "Ireland";

                    correctAnswer = 1;
                    break;

                case 4:
                    richTextBoxQuestionBox.Text = "Which of the following animals can run the fastest?";
                    button1.Text = "Cheetah";
                    button2.Text = "Leopard";
                    button3.Text = "Tiger";
                    button4.Text = "Lion";

                    correctAnswer = 1;
                    break;

                case 5:
                    richTextBoxQuestionBox.Text = "Where did the powers of Spiderman come from?";
                    button1.Text = "He was Born With Them?";
                    button2.Text = "He was bitten by a radioactive spider";
                    button3.Text = "He went through a scientific experiment";
                    button4.Text = "He woke up with them after a dream";

                    correctAnswer = 2;
                    break;
            }
        }



        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
                richTextBoxScore.Text = score.ToString();
            }

            if (questionNumber == totalQuestions)
            {
                MessageBox.Show("Quiz Ended" + Environment.NewLine + "You have scored " + score.ToString() + Environment.NewLine + " Click Okay to play again");
                score = 0;
                questionNumber = 0;
                this.Hide();
                var myForm = new topicsForm();
                myForm.FormClosed += (s, args) => this.Close();
                myForm.Show();
            }

            questionNumber++;
            askQuestion(questionNumber);

        }

    }
}
