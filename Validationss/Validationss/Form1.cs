using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validationss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            do
            {
                if (!string.IsNullOrEmpty(txt_Number.Text) && 
                    !string.IsNullOrEmpty(txt_In.Text)&&
                    !string.IsNullOrEmpty(txt_ObjectName.Text) && 
                    !string.IsNullOrEmpty(txt_PhoneNo.Text) && 
                    !string.IsNullOrEmpty(txt_Count.Text) && 
                    !string.IsNullOrEmpty(txt_Price.Text))
                {
                    
                    p.Count = Convert.ToInt32(txt_Count.Text);
                    p.ObjectName = txt_ObjectName.Text;
                    p.Number =Convert.ToInt32( txt_Number.Text);
                    p.Date = dtp_datepicker1.Value;
                    p.price = Convert.ToInt32(txt_Price.Text);
                    p.InventoryNo = txt_In.Text;
                    Regex r = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{3}$");
                    if (r.IsMatch(txt_PhoneNo.Text))
                    {
                        p.Phoneno = txt_PhoneNo.Text;
                    }
                    else
                    {
                        errorProvider1.SetError(txt_ObjectName, "Phone NUmber invalid format");
                    }
                    p.save();
                    dgvShowProducts.DataSource = null;
                    dgvShowProducts.DataSource = Product.getAllProduct();
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(txt_ObjectName, "Name is required!");
                    errorProvider1.SetError(txt_Count, " Count is required!");
                    MessageBox.Show("Can't insert null values. Try again please");
                }
            } while (txt_Count.Text == null || 
                    txt_ObjectName.Text == null ||
                    txt_Number.Text == null ||
                    dtp_datepicker1.Text == null || 
                    txt_Price.Text == null || 
                    txt_In.Text == null ||
                    txt_PhoneNo==null);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
