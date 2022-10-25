using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{
    public partial class musicFormSP : Form
    {

        int score;
        int questionNumber = 1;
        int correctAnswer;
        int totalQuestions;

        public musicFormSP()
        {
            InitializeComponent();

            askMusicQuestions(questionNumber);

            totalQuestions = 5;
        }

        private void askMusicQuestions(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    richTextBoxQuestionBox.Text = "Who had the number 1 hit \"Can't Buy Me Love\" in 1964?";
                    button1.Text = "Rolling Stones";
                    button2.Text = "The Animals";
                    button3.Text = "The Monkees";
                    button4.Text = "The Beatles";

                    correctAnswer = 4;
                    break;

                case 2:
                    richTextBoxQuestionBox.Text = "Who had the number 1 hit \"Bridge Over Troubled Water\" in 1970?";
                    button1.Text = "Simon and Garfunkel";
                    button2.Text = "Bee Gees";
                    button3.Text = "Dolly Parton and Kenny Rogers";
                    button4.Text = "The Eagles";

                    correctAnswer = 1;
                    break;

                case 3:
                    richTextBoxQuestionBox.Text = "Who had the number 1 hit \"Don't Go Breaking My Heart\" in 1976?";
                    button1.Text = "Simon and Garfunkel";
                    button2.Text = "Sting";
                    button3.Text = "Elton John and Kiki Dee";
                    button4.Text = "The Eagles";

                    correctAnswer = 3;
                    break;

                case 4:
                    richTextBoxQuestionBox.Text = "Who had the number 1 hit \"I'll Be Missing You\" in 1997?";
                    button1.Text = "Madonna";
                    button2.Text = "Pink";
                    button3.Text = "Michael Jackson";
                    button4.Text = "Puff Daddy and Faith Evans";

                    correctAnswer = 4;
                    break;

                case 5:
                    richTextBoxQuestionBox.Text = "Who had the number 1 hit \"We Can Work It Out\" in 1967?";
                    button1.Text = "The Animals";
                    button2.Text = "Rolling Stones";
                    button3.Text = "The Monkees";
                    button4.Text = "The Beatles";

                    correctAnswer = 4;
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
            askMusicQuestions(questionNumber);
        }
    }
}
