﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cezar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k,n,index;
            string str1;
            str1 = textBox1.Text;
            if (textBox3.Text != "")
            {
                index = Convert.ToInt32(textBox3.Text);
                if (index < 26 & index > 0)
                {

                    n = str1.Length;
                    //textBox1.Text = "";
                    textBox2.Text = "";
                    for (int i = 0; i < n; i++)
                    {
                        k = (int)str1[i];
                        k = k + index;
                        if (k > 122) k = k - 26;
                        textBox2.Text = textBox2.Text + ((char)(k)).ToString();
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k, n, index;
            string str1;
            str1 = textBox1.Text;
            if (textBox3.Text != "")
            {
                index = Convert.ToInt32(textBox3.Text);
                if (index < 26 & index > 0)
                {

                    n = str1.Length;
                    //textBox1.Text = "";
                    textBox2.Text = "";
                    for (int i = 0; i < n; i++)
                    {
                        k = (int)str1[i];
                        k = k - index;
                        if (k < 97) k = k + 26;
                        textBox2.Text = textBox2.Text + ((char)(k)).ToString();
                    }

                }
            }
        }
    }
}
