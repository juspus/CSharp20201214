﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210107Skaiciuotuvas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string str = "afasfasf";
            str = str.Remove(str.Length - 1);
            MessageBox.Show(str);
        }
    }
}
