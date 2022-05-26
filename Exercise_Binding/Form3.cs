using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Binding
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 mnu = new Form4();
            mnu.Show();
            this.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 ths = new Form5();
            ths.Show();
            this.Show();
        }
    }
}
    
