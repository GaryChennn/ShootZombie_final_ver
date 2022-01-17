﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootZombie
{
    public partial class Form6 : Form
    {
        private string string1, string2;

        public string String1
        {
            set
            {
                string1 = value;
            }
        }

        public string String2
        {
            set
            {
                string2 = value;
            }
        }

        public void SetValue()
        {
            this.label1.Text = string1;
            this.label2.Text = string2;
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
