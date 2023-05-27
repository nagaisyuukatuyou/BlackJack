namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(467, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(467, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "You";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(528, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 61);
            this.button3.TabIndex = 4;
            this.button3.Text = "start";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(720, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "stand";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(324, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 61);
            this.button2.TabIndex = 4;
            this.button2.Text = "hit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(466, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "startを押してね";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(899, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(899, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(115, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 33);
            this.button4.TabIndex = 7;
            this.button4.Text = "↑";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(222, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 33);
            this.button5.TabIndex = 7;
            this.button5.Text = "↓";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Fuchsia;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(156, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "bed 100";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(115, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "money 1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "×2or×10";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.Location = new System.Drawing.Point(445, 625);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(292, 58);
            this.button6.TabIndex = 11;
            this.button6.Text = "タイトル画面に戻る";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 25);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Fuchsia;
            this.button7.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button7.Location = new System.Drawing.Point(117, 361);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 39);
            this.button7.TabIndex = 13;
            this.button7.Text = "bed";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1309, 766);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BlackJack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
    }
}

