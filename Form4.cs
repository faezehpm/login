using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Form4 : Form
    {
        string name = " ";
        public Form4( string username)
        {
            InitializeComponent();
            name = username;
            label2.Text = "hellow" + name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
