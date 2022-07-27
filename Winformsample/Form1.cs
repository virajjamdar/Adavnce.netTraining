using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winformsample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (textuserid.Text == "abc" && textpassward.Text == "123")
            {
                MessageBox.Show("sucessfully login");
            }
            else
            {
                MessageBox.Show("failed to login");
            } 

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textuserid.Clear();
            textpassward.Clear();

        }
    }
}
