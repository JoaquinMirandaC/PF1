﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF1
{
    public partial class FormLog : Form
    {
        public FormLog ( )
        {
            InitializeComponent();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            SingletonLog singleton = SingletonLog.GetInstance();

        }
    }
}