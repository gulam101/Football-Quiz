namespace Football_Quiz
{
    partial class StartScreen
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
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.btn_ExitApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Location = new System.Drawing.Point(246, 212);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(100, 47);
            this.btn_StartGame.TabIndex = 0;
            this.btn_StartGame.Text = "Start Game";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            // 
            // btn_ExitApp
            // 
            this.btn_ExitApp.Location = new System.Drawing.Point(246, 290);
            this.btn_ExitApp.Name = "btn_ExitApp";
            this.btn_ExitApp.Size = new System.Drawing.Size(100, 47);
            this.btn_ExitApp.TabIndex = 1;
            this.btn_ExitApp.Text = "Exit Button";
            this.btn_ExitApp.UseVisualStyleBackColor = true;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.btn_ExitApp);
            this.Controls.Add(this.btn_StartGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Button btn_ExitApp;
    }
}

