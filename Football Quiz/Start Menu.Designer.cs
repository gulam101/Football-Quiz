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
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Location = new System.Drawing.Point(236, 159);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(100, 47);
            this.btn_StartGame.TabIndex = 0;
            this.btn_StartGame.Text = "Start Game";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // btn_ExitApp
            // 
            this.btn_ExitApp.Location = new System.Drawing.Point(236, 237);
            this.btn_ExitApp.Name = "btn_ExitApp";
            this.btn_ExitApp.Size = new System.Drawing.Size(100, 47);
            this.btn_ExitApp.TabIndex = 1;
            this.btn_ExitApp.Text = "Exit Button";
            this.btn_ExitApp.UseVisualStyleBackColor = true;
            this.btn_ExitApp.Click += new System.EventHandler(this.btn_ExitApp_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(204, 33);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(169, 29);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Football Quiz";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 401);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_ExitApp);
            this.Controls.Add(this.btn_StartGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Button btn_ExitApp;
        private System.Windows.Forms.Label lbl_title;
    }
}

