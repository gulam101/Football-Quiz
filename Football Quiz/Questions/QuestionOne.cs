using Football_Quiz.Questions;
using System;
using System.Windows.Forms;

namespace Football_Quiz
{
    public partial class Start_Game : Form
    {
        public Start_Game(int score)
        {
            InitializeComponent();

            int correctA = 3;
            int Total = correctA + score;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public static bool CloseCancel()
        {
            const string message = "Are you sure you want to exit the application?";
            const string caption = "Exit application";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_awnserOne_Click(object sender, EventArgs e)
        {
            Hide();
            var nextQuestion = new QuestionTwo();
            nextQuestion.Show();
        }

    }
}
