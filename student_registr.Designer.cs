﻿namespace orientiring_test
{
    partial class student_registr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_registr));
            this.button1 = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(734, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "готово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nametextBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.nametextBox.Location = new System.Drawing.Point(734, 294);
            this.nametextBox.Multiline = true;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(206, 67);
            this.nametextBox.TabIndex = 1;
            this.nametextBox.Text = "введите имя и фамилию";
            this.nametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nametextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            this.nametextBox.Enter += new System.EventHandler(this.textBox1_Enter);
            this.nametextBox.Leave += new System.EventHandler(this.nametextBox_Leave);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(734, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // student_registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1540, 825);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "student_registr";
            this.Text = "Вход для студента";
            this.Load += new System.EventHandler(this.student_registr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Button button2;
    }
}