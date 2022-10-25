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
    public partial class KidsForm : Form
    {
        int score;
        int questionNumber = 1;
        int correctAnswer;
        int totalQuestions;

        public KidsForm()
        {
            InitializeComponent();

            askKidsQuestions(questionNumber);

            totalQuestions = 5;
        }

        private void askKidsQuestions(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    richTextBoxQuestionBox.Text = "What orange vegetable do rabbits like to eat?";
                    button1.Text = "Carrots";
                    button2.Text = "Broccoli";
                    button3.Text = "Oranges";
                    button4.Text = "Sweetcorn";

                    correctAnswer = 1;
                    break;

                case 2:
                    richTextBoxQuestionBox.Text = "What number comes after 9?";
                    button1.Text = "4";
                    button2.Text = "8";
                    button3.Text = "10";
                    button4.Text = "12";

                    correctAnswer = 3;
                    break;

                case 3:
                    richTextBoxQuestionBox.Text = "What language do people speak in Germany?";
                    button1.Text = "French";
                    button2.Text = "Russian";
                    button3.Text = "German";
                    button4.Text = "Spanish";

                    correctAnswer = 3;
                    break;

                case 4:
                    richTextBoxQuestionBox.Text = "How many sides does a square have?";
                    button1.Text = "2";
                    button2.Text = "4";
                    button3.Text = "6";
                    button4.Text = "8";

                    correctAnswer = 2;
                    break;

                case 5:
                    richTextBoxQuestionBox.Text = "What animal has a really long neck?";
                    button1.Text = "Giraffe";
                    button2.Text = "Parrot";
                    button3.Text = "Gorilla";
                    button4.Text = "Cat";

                    correctAnswer = 1;
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
            askKidsQuestions(questionNumber);
        }
    }
}
