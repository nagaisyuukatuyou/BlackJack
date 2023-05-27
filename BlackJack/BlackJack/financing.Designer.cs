namespace BlackJack
{
    partial class financing
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("ＭＳ 明朝", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(325, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "融資";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ 明朝", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(253, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "闇金へようこそ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("ＭＳ 明朝", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(325, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "返済";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // financing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "financing";
            this.Text = "financing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}