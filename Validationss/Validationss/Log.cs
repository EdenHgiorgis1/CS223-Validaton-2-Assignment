using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validationss
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            //label8.Text = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String username = textBox1.Text;
            String pass = textBox2.Text;

            if(username=="Admin" && pass == "123")
            {
                Form1 f = new Form1(username);
                f.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Input");
            }

           
        }
    }
}
