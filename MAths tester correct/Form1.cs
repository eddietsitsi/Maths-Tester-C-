using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAths_tester_correct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void Form1_Load(object sender, EventArgs e)
        {

            lblResult.Visible = false;
        }
             
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Value1 = txtValue1.Text;
            string Value2 = txtValue2.Text;

            int isNum1;
            int isNum2;
            Double AddR;

            if (int.TryParse(Value1, out isNum1) && int.TryParse(Value2, out isNum2))
            {
                AddR = (isNum1+isNum2);
                lblResult.Visible = true;

                if (isNum1 > 0 && isNum2 > 0)
                {
                    lblResult.ForeColor = Color.Purple;
                    lblResult.Text = AddR.ToString();
                }
                else
                {
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = AddR.ToString();
                    MessageBox.Show("Value must be numeri and >0");

                }
            }
          

            
            
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string Value1 = txtValue1.Text;
            string Value2 = txtValue2.Text;
            
            lblResult.ForeColor = Color.Purple;
            int isNum1;
            int isNum2;
            Double MulR;

            if (int.TryParse(Value1, out isNum1) && int.TryParse(Value2, out isNum2))
            {
                MulR = (isNum1*isNum2);
                lblResult.Visible = true;

                if (isNum1>0 && isNum2>0)
                {
                  lblResult.ForeColor = Color.Purple;
                  lblResult.Text = MulR.ToString();
                }
                else
                {
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = MulR.ToString();
                    MessageBox.Show("Value must be numeri and >0");

                }
                

            }
           
        }

        private void txtValue1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValue2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            
            txtValue1.Clear();
            txtValue2.Clear();
            lblResult.ForeColor = Color.Yellow;
            lblResult.Text = "0";            
        }

        private void txtValue1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter numeric values only");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Enter numeric values only");
            }
        }

        private void txtValue2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Value must be numeri and >0");
                
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Value must be numeri and >0");
            }

        }

       
    }
}
