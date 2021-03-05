namespace orientiring_test
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
            this.logintextBox = new System.Windows.Forms.TextBox();
            this.passworrdtextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.enterbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.enterstudentbutton = new System.Windows.Forms.Button();
            this.passwordforgetbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logintextBox
            // 
            this.logintextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logintextBox.HideSelection = false;
            this.logintextBox.Location = new System.Drawing.Point(16, 5);
            this.logintextBox.Margin = new System.Windows.Forms.Padding(4);
            this.logintextBox.Name = "logintextBox";
            this.logintextBox.Size = new System.Drawing.Size(196, 26);
            this.logintextBox.TabIndex = 0;
            this.logintextBox.Text = "введите логин";
            this.logintextBox.Enter += new System.EventHandler(this.logintextBox_Enter);
            this.logintextBox.Leave += new System.EventHandler(this.logintextBox_Leave);
            // 
            // passworrdtextBox
            // 
            this.passworrdtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passworrdtextBox.Location = new System.Drawing.Point(16, 37);
            this.passworrdtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passworrdtextBox.Name = "passworrdtextBox";
            this.passworrdtextBox.Size = new System.Drawing.Size(196, 26);
            this.passworrdtextBox.TabIndex = 1;
            this.passworrdtextBox.Text = "введите пароль";
            this.passworrdtextBox.Enter += new System.EventHandler(this.passworrdtextBox_Enter);
            this.passworrdtextBox.Leave += new System.EventHandler(this.passworrdtextBox_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(16, 70);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // enterbutton
            // 
            this.enterbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterbutton.Location = new System.Drawing.Point(16, 97);
            this.enterbutton.Margin = new System.Windows.Forms.Padding(4);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(197, 28);
            this.enterbutton.TabIndex = 3;
            this.enterbutton.Text = "войти";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitbutton.Location = new System.Drawing.Point(16, 130);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(197, 28);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.Text = "закрыть программу";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // enterstudentbutton
            // 
            this.enterstudentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterstudentbutton.Location = new System.Drawing.Point(17, 224);
            this.enterstudentbutton.Margin = new System.Windows.Forms.Padding(4);
            this.enterstudentbutton.Name = "enterstudentbutton";
            this.enterstudentbutton.Size = new System.Drawing.Size(196, 66);
            this.enterstudentbutton.TabIndex = 5;
            this.enterstudentbutton.Text = "вход для обучаемого";
            this.enterstudentbutton.UseVisualStyleBackColor = true;
            this.enterstudentbutton.Click += new System.EventHandler(this.enterstudentbutton_Click);
            // 
            // passwordforgetbutton
            // 
            this.passwordforgetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordforgetbutton.Location = new System.Drawing.Point(16, 165);
            this.passwordforgetbutton.Margin = new System.Windows.Forms.Padding(4);
            this.passwordforgetbutton.Name = "passwordforgetbutton";
            this.passwordforgetbutton.Size = new System.Drawing.Size(197, 52);
            this.passwordforgetbutton.TabIndex = 6;
            this.passwordforgetbutton.Text = "забыли пароль?";
            this.passwordforgetbutton.UseVisualStyleBackColor = true;
            this.passwordforgetbutton.Click += new System.EventHandler(this.passwordforgetbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 582);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "v1.1.1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::orientiring_test.Properties.Resources.asCMil0GiQ0;
            this.pictureBox1.Location = new System.Drawing.Point(240, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(429, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "© Dictus Games 2020";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 86);
            this.button1.TabIndex = 10;
            this.button1.Text = "прочитать пользовательские правила";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 601);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordforgetbutton);
            this.Controls.Add(this.enterstudentbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.passworrdtextBox);
            this.Controls.Add(this.logintextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "вход";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logintextBox;
        private System.Windows.Forms.TextBox passworrdtextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button enterbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button enterstudentbutton;
        private System.Windows.Forms.Button passwordforgetbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

