using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Quiz
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btn_ExitApp_Click(object sender, EventArgs e)
        {
            const string exitMessage = "This will leave the application, are you sure?";
            const string exitTitle = "Are You Sure?";     

            var exitMenu = MessageBox.Show(exitMessage, exitTitle,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if(exitMenu == DialogResult.Yes)
            {
                //Exits Application
                Application.Exit();
            }
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            var startgame = new Start_Game();
            startgame.ShowDialog();
       
        }
    }
}
