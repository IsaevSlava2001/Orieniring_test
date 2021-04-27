using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orientiring_test
{
    public partial class trener_dostyp : Form
    {
        public trener_dostyp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //переход на нужную форму
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            //-----------------------
        }

        private void test_create_Click(object sender, EventArgs e)
        {
            //переход на нужную форму
            test_create_settings f = new test_create_settings();
            f.Show();
            this.Hide();
            //---------------------
        }

        private void trener_dostyp_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(1556, 864);
            FormBorderStyle = FormBorderStyle.None;
        }
    }
}
