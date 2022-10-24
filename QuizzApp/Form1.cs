using QuizzApp.data;

namespace QuizzApp
{
    public partial class Form1 : Form
    {
        Questions questions = new Questions();
        public Form1()
        {
            InitializeComponent();

            //Load all questions
            questions.setup();


        }
    }
}