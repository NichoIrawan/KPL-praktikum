using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPL_praktikum
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text = "Halo, " + name_field.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void name_field_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
