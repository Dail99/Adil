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
            this.radical = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ButtonDegree = new System.Windows.Forms.Button();
            this.ButtonDegreeFraction = new System.Windows.Forms.Button();
            this.ButtonLog = new System.Windows.Forms.Button();
            this.ButtonSin = new System.Windows.Forms.Button();
            this.ButtonCos = new System.Windows.Forms.Button();
            this.ButtonTan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(309, 27);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlus.TabIndex = 7;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.Click += new System.EventHandler(this.ClickMain);
            // 
            // ButtonMin
            // 
            this.ButtonMin.Location = new System.Drawing.Point(309, 114);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Size = new System.Drawing.Size(75, 23);
            this.ButtonMin.TabIndex = 3;
            this.ButtonMin.Text = "-";
            this.ButtonMin.UseVisualStyleBackColor = true;
            this.ButtonMin.Click += new System.EventHandler(this.ClickMain);
            // 
            // ButtonDel
            // 
            this.ButtonDel.Location = new System.Drawing.Point(309, 85);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(75, 23);
            this.ButtonDel.TabIndex = 4;
            this.ButtonDel.Text = "/";
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ClickMain);
            // 
            // ButtonUmn
            // 
            this.ButtonUmn.Location = new System.Drawing.Point(309, 56);
            this.ButtonUmn.Name = "ButtonUmn";
            this.ButtonUmn.Size = new System.Drawing.Size(75, 23);
            this.ButtonUmn.TabIndex = 5;
            this.ButtonUmn.Text = "*";
            this.ButtonUmn.UseVisualStyleBackColor = true;
            this.ButtonUmn.Click += new System.EventHandler(this.ClickMain);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // radical
            // 
            this.radical.Location = new System.Drawing.Point(138, 210);
            this.radical.Name = "radical";
            this.radical.Size = new System.Drawing.Size(75, 23);
            this.radical.TabIndex = 8;
            this.radical.Text = "Sqrt";
            this.radical.UseVisualStyleBackColor = true;
            this.radical.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 213);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // ButtonDegree
            // 
            this.ButtonDegree.Location = new System.Drawing.Point(402, 27);
            this.ButtonDegree.Name = "ButtonDegree";
            this.ButtonDegree.Size = new System.Drawing.Size(75, 23);
            this.ButtonDegree.TabIndex = 10;
            this.ButtonDegree.Text = "^";
            this.ButtonDegree.UseVisualStyleBackColor = true;
            this.ButtonDegree.Click += new System.EventHandler(this.ClickMain);
            // 
            // ButtonDegreeFraction
            // 
            this.ButtonDegreeFraction.Location = new System.Drawing.Point(402, 56);
            this.ButtonDegreeFraction.Name = "ButtonDegreeFraction";
            this.ButtonDegreeFraction.Size = new System.Drawing.Size(75, 23);
            this.ButtonDegreeFraction.TabIndex = 11;
            this.ButtonDegreeFraction.Text = "^1/y";
            this.ButtonDegreeFraction.UseVisualStyleBackColor = true;
            this.ButtonDegreeFraction.Click += new System.EventHandler(this.ClickMain);
            // 
            // ButtonLog
            // 
            this.ButtonLog.Location = new System.Drawing.Point(402, 85);
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Size = new System.Drawing.Size(75, 23);
            this.ButtonLog.TabIndex = 12;
            this.ButtonLog.Text = "logx(y)";
            this.ButtonLog.UseVisualStyleBackColor = true;
            this.ButtonLog.Click += new System.EventHandler(this.ClickMain);
            // 
            // ButtonSin
            // 
            this.ButtonSin.Location = new System.Drawing.Point(233, 210);
            this.ButtonSin.Name = "ButtonSin";
            this.ButtonSin.Size = new System.Drawing.Size(75, 23);
            this.ButtonSin.TabIndex = 13;
            this.ButtonSin.Text = "arcsin(x)";
            this.ButtonSin.UseVisualStyleBackColor = true;
            this.ButtonSin.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // ButtonCos
            // 
            this.ButtonCos.Location = new System.Drawing.Point(324, 210);
            this.ButtonCos.Name = "ButtonCos";
            this.ButtonCos.Size = new System.Drawing.Size(75, 23);
            this.ButtonCos.TabIndex = 14;
            this.ButtonCos.Text = "arccos(x)";
            this.ButtonCos.UseVisualStyleBackColor = true;
            this.ButtonCos.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // ButtonTan
            // 
            this.ButtonTan.Location = new System.Drawing.Point(411, 210);
            this.ButtonTan.Name = "ButtonTan";
            this.ButtonTan.Size = new System.Drawing.Size(75, 23);
            this.ButtonTan.TabIndex = 15;
            this.ButtonTan.Text = "arctan(x)";
            this.ButtonTan.UseVisualStyleBackColor = true;
            this.ButtonTan.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 298);
            this.Controls.Add(this.ButtonTan);
            this.Controls.Add(this.ButtonCos);
            this.Controls.Add(this.ButtonSin);
            this.Controls.Add(this.ButtonLog);
            this.Controls.Add(this.ButtonDegreeFraction);
            this.Controls.Add(this.ButtonDegree);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.radical);
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
        private System.Windows.Forms.Button radical;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button ButtonDegree;
        private System.Windows.Forms.Button ButtonDegreeFraction;
        private System.Windows.Forms.Button ButtonLog;
        private System.Windows.Forms.Button ButtonSin;
        private System.Windows.Forms.Button ButtonCos;
        private System.Windows.Forms.Button ButtonTan;
    }
}

