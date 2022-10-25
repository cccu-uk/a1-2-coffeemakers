namespace QuizzApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new topicsForm();
            myForm.FormClosed += (s, args) => this.Close();
            myForm.Show();
        }
    }
}