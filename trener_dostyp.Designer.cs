namespace orientiring_test
{
    partial class trener_dostyp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trener_dostyp));
            this.button1 = new System.Windows.Forms.Button();
            this.test_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(1313, 674);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 141);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выйти из аккаунта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // test_create
            // 
            this.test_create.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_create.ForeColor = System.Drawing.Color.ForestGreen;
            this.test_create.Location = new System.Drawing.Point(636, 293);
            this.test_create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.test_create.Name = "test_create";
            this.test_create.Size = new System.Drawing.Size(239, 178);
            this.test_create.TabIndex = 1;
            this.test_create.Text = "создать тест";
            this.test_create.UseVisualStyleBackColor = true;
            this.test_create.Click += new System.EventHandler(this.test_create_Click);
            // 
            // trener_dostyp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::orientiring_test.Properties.Resources.Без_имени_2;
            this.ClientSize = new System.Drawing.Size(1538, 817);
            this.Controls.Add(this.test_create);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "trener_dostyp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "страница тренера";
            this.Load += new System.EventHandler(this.trener_dostyp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button test_create;
    }
}