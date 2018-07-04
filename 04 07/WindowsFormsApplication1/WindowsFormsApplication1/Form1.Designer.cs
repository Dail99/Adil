namespace MainCalculator
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
            this.plusSolution = new System.Windows.Forms.Button();
            this.minSolution = new System.Windows.Forms.Button();
            this.delSolution = new System.Windows.Forms.Button();
            this.multiSolution = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radicalSolution = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.degreeSolution = new System.Windows.Forms.Button();
            this.degreeFraction = new System.Windows.Forms.Button();
            this.logSolution = new System.Windows.Forms.Button();
            this.sinSolution = new System.Windows.Forms.Button();
            this.cosSolution = new System.Windows.Forms.Button();
            this.tanSolution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // plusSolution
            // 
            this.plusSolution.Location = new System.Drawing.Point(309, 27);
            this.plusSolution.Name = "plusSolution";
            this.plusSolution.Size = new System.Drawing.Size(75, 23);
            this.plusSolution.TabIndex = 7;
            this.plusSolution.Text = "+";
            this.plusSolution.Click += new System.EventHandler(this.ClickMain);
            // 
            // minSolution
            // 
            this.minSolution.Location = new System.Drawing.Point(309, 114);
            this.minSolution.Name = "minSolution";
            this.minSolution.Size = new System.Drawing.Size(75, 23);
            this.minSolution.TabIndex = 3;
            this.minSolution.Text = "-";
            this.minSolution.UseVisualStyleBackColor = true;
            this.minSolution.Click += new System.EventHandler(this.ClickMain);
            // 
            // delSolution
            // 
            this.delSolution.Location = new System.Drawing.Point(309, 85);
            this.delSolution.Name = "delSolution";
            this.delSolution.Size = new System.Drawing.Size(75, 23);
            this.delSolution.TabIndex = 4;
            this.delSolution.Text = "/";
            this.delSolution.UseVisualStyleBackColor = true;
            this.delSolution.Click += new System.EventHandler(this.ClickMain);
            // 
            // multiSolution
            // 
            this.multiSolution.Location = new System.Drawing.Point(309, 56);
            this.multiSolution.Name = "multiSolution";
            this.multiSolution.Size = new System.Drawing.Size(75, 23);
            this.multiSolution.TabIndex = 5;
            this.multiSolution.Text = "*";
            this.multiSolution.UseVisualStyleBackColor = true;
            this.multiSolution.Click += new System.EventHandler(this.ClickMain);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // radicalSolution
            // 
            this.radicalSolution.Location = new System.Drawing.Point(138, 210);
            this.radicalSolution.Name = "radicalSolution";
            this.radicalSolution.Size = new System.Drawing.Size(75, 23);
            this.radicalSolution.TabIndex = 8;
            this.radicalSolution.Text = "Sqrt";
            this.radicalSolution.UseVisualStyleBackColor = true;
            this.radicalSolution.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 213);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // degreeSolution
            // 
            this.degreeSolution.Location = new System.Drawing.Point(402, 27);
            this.degreeSolution.Name = "degreeSolution";
            this.degreeSolution.Size = new System.Drawing.Size(75, 23);
            this.degreeSolution.TabIndex = 10;
            this.degreeSolution.Text = "^";
            this.degreeSolution.UseVisualStyleBackColor = true;
            this.degreeSolution.Click += new System.EventHandler(this.ClickMain);
            // 
            // degreeFraction
            // 
            this.degreeFraction.Location = new System.Drawing.Point(402, 56);
            this.degreeFraction.Name = "degreeFraction";
            this.degreeFraction.Size = new System.Drawing.Size(75, 23);
            this.degreeFraction.TabIndex = 11;
            this.degreeFraction.Text = "^1/y";
            this.degreeFraction.UseVisualStyleBackColor = true;
            this.degreeFraction.Click += new System.EventHandler(this.ClickMain);
            // 
            // logSolution
            // 
            this.logSolution.Location = new System.Drawing.Point(402, 85);
            this.logSolution.Name = "logSolution";
            this.logSolution.Size = new System.Drawing.Size(75, 23);
            this.logSolution.TabIndex = 12;
            this.logSolution.Text = "logx(y)";
            this.logSolution.UseVisualStyleBackColor = true;
            this.logSolution.Click += new System.EventHandler(this.ClickMain);
            // 
            // sinSolution
            // 
            this.sinSolution.Location = new System.Drawing.Point(233, 210);
            this.sinSolution.Name = "sinSolution";
            this.sinSolution.Size = new System.Drawing.Size(75, 23);
            this.sinSolution.TabIndex = 13;
            this.sinSolution.Text = "arcsin(x)";
            this.sinSolution.UseVisualStyleBackColor = true;
            this.sinSolution.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // cosSolution
            // 
            this.cosSolution.Location = new System.Drawing.Point(324, 210);
            this.cosSolution.Name = "cosSolution";
            this.cosSolution.Size = new System.Drawing.Size(75, 23);
            this.cosSolution.TabIndex = 14;
            this.cosSolution.Text = "arccos(x)";
            this.cosSolution.UseVisualStyleBackColor = true;
            this.cosSolution.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // tanSolution
            // 
            this.tanSolution.Location = new System.Drawing.Point(411, 210);
            this.tanSolution.Name = "tanSolution";
            this.tanSolution.Size = new System.Drawing.Size(75, 23);
            this.tanSolution.TabIndex = 15;
            this.tanSolution.Text = "arctan(x)";
            this.tanSolution.UseVisualStyleBackColor = true;
            this.tanSolution.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 298);
            this.Controls.Add(this.tanSolution);
            this.Controls.Add(this.cosSolution);
            this.Controls.Add(this.sinSolution);
            this.Controls.Add(this.logSolution);
            this.Controls.Add(this.degreeFraction);
            this.Controls.Add(this.degreeSolution);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.radicalSolution);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.multiSolution);
            this.Controls.Add(this.delSolution);
            this.Controls.Add(this.minSolution);
            this.Controls.Add(this.plusSolution);
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
        private System.Windows.Forms.Button plusSolution;
        private System.Windows.Forms.Button minSolution;
        private System.Windows.Forms.Button delSolution;
        private System.Windows.Forms.Button multiSolution;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button radicalSolution;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button degreeSolution;
        private System.Windows.Forms.Button degreeFraction;
        private System.Windows.Forms.Button logSolution;
        private System.Windows.Forms.Button sinSolution;
        private System.Windows.Forms.Button cosSolution;
        private System.Windows.Forms.Button tanSolution;
    }
}

