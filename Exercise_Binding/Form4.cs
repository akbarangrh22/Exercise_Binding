﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.adventureWorksDataSet.Employee);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 fm = new Form3();
            fm.Show();


        }
    }
}
