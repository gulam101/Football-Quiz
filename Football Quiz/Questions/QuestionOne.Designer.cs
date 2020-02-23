namespace Football_Quiz
{
    partial class Start_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Game));
            this.btn_awnserOne = new System.Windows.Forms.Button();
            this.btn_awnserTwo = new System.Windows.Forms.Button();
            this.btn_awnserThree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_awnserOne
            // 
            this.btn_awnserOne.Location = new System.Drawing.Point(53, 382);
            this.btn_awnserOne.Name = "btn_awnserOne";
            this.btn_awnserOne.Size = new System.Drawing.Size(75, 23);
            this.btn_awnserOne.TabIndex = 0;
            this.btn_awnserOne.Text = "Ronaldo";
            this.btn_awnserOne.UseVisualStyleBackColor = true;
            this.btn_awnserOne.Click += new System.EventHandler(this.btn_awnserOne_Click);
            // 
            // btn_awnserTwo
            // 
            this.btn_awnserTwo.Location = new System.Drawing.Point(357, 382);
            this.btn_awnserTwo.Name = "btn_awnserTwo";
            this.btn_awnserTwo.Size = new System.Drawing.Size(75, 23);
            this.btn_awnserTwo.TabIndex = 1;
            this.btn_awnserTwo.Text = "Messi";
            this.btn_awnserTwo.UseVisualStyleBackColor = true;
            // 
            // btn_awnserThree
            // 
            this.btn_awnserThree.Location = new System.Drawing.Point(669, 382);
            this.btn_awnserThree.Name = "btn_awnserThree";
            this.btn_awnserThree.Size = new System.Drawing.Size(75, 23);
            this.btn_awnserThree.TabIndex = 2;
            this.btn_awnserThree.Text = "Rooney";
            this.btn_awnserThree.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Who is this football player?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 243);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Start_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_awnserThree);
            this.Controls.Add(this.btn_awnserTwo);
            this.Controls.Add(this.btn_awnserOne);
            this.MaximizeBox = false;
            this.Name = "Start_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_awnserOne;
        private System.Windows.Forms.Button btn_awnserTwo;
        private System.Windows.Forms.Button btn_awnserThree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}