﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualstudio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
                if (radioButton2.Checked) s++;
                if (checkBox1.Checked) s++;
                if (checkBox3.Checked) s++;
                if ((checkBox2.Checked) || (checkBox4.Checked)) s = 0;
                MessageBox.Show("punctaj " + s.ToString());

        }
    }
}
