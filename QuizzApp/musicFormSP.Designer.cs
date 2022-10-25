namespace QuizzApp
{
    partial class musicFormSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxScore = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxQuestionBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(587, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score";
            // 
            // richTextBoxScore
            // 
            this.richTextBoxScore.Location = new System.Drawing.Point(652, 2);
            this.richTextBoxScore.Name = "richTextBoxScore";
            this.richTextBoxScore.Size = new System.Drawing.Size(118, 40);
            this.richTextBoxScore.TabIndex = 4;
            this.richTextBoxScore.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.richTextBoxQuestionBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 401);
            this.panel1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(415, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 95);
            this.button4.TabIndex = 5;
            this.button4.Tag = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 95);
            this.button3.TabIndex = 4;
            this.button3.Tag = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 95);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 95);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(345, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question";
            // 
            // richTextBoxQuestionBox
            // 
            this.richTextBoxQuestionBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxQuestionBox.Location = new System.Drawing.Point(203, 71);
            this.richTextBoxQuestionBox.Name = "richTextBoxQuestionBox";
            this.richTextBoxQuestionBox.Size = new System.Drawing.Size(382, 42);
            this.richTextBoxQuestionBox.TabIndex = 0;
            this.richTextBoxQuestionBox.Text = "";
            // 
            // musicFormSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxScore);
            this.Controls.Add(this.panel1);
            this.Name = "musicFormSP";
            this.Text = "Music Quiz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox richTextBoxScore;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private RichTextBox richTextBoxQuestionBox;
    }
}