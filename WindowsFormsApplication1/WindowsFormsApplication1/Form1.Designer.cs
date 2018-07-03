namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMin = new System.Windows.Forms.Button();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.ButtonUmn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(307, 98);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlus.TabIndex = 7;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.Click += new System.EventHandler(this.ClickMain);
            // 
            // ButtonMin
            // 
            this.ButtonMin.Location = new System.Drawing.Point(184, 166);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Size = new System.Drawing.Size(75, 23);
            this.ButtonMin.TabIndex = 3;
            this.ButtonMin.Text = "-";
            this.ButtonMin.UseVisualStyleBackColor = true;
            this.ButtonMin.Click += new System.EventHandler(this.ClickMain);
            // 
            // ButtonDel
            // 
            this.ButtonDel.Location = new System.Drawing.Point(277, 147);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(75, 23);
            this.ButtonDel.TabIndex = 4;
            this.ButtonDel.Text = "/";
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ClickMain);
            // 
            // ButtonUmn
            // 
            this.ButtonUmn.Location = new System.Drawing.Point(52, 147);
            this.ButtonUmn.Name = "ButtonUmn";
            this.ButtonUmn.Size = new System.Drawing.Size(75, 23);
            this.ButtonUmn.TabIndex = 5;
            this.ButtonUmn.Text = "*";
            this.ButtonUmn.UseVisualStyleBackColor = true;
            this.ButtonUmn.Click += new System.EventHandler(this.ClickMain);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 386);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ButtonUmn);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.ButtonMin);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonMin;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.Button ButtonUmn;
        private System.Windows.Forms.TextBox textBox3;
    }
}

