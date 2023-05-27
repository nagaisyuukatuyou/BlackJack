namespace BlackJack
{
    partial class title
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(346, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "戦績";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(346, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 75);
            this.button2.TabIndex = 0;
            this.button2.Text = "ゲーム開始";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(346, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 75);
            this.button3.TabIndex = 0;
            this.button3.Text = "闇金";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.Location = new System.Drawing.Point(790, 488);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 39);
            this.button4.TabIndex = 1;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(879, 551);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "title";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.title_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}