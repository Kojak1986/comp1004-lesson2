using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1004_lesson2
{
    public partial class Invoicetotalform : Form
    {
        public Invoicetotalform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Invoicetotalform_Load(object sender, EventArgs e)
        {

        }

        private void discountPercentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Calculate button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Local Variables
            //Discount amount is equal to subtotal x 0.1
            const double DiscountPercent = 0.1;
            double SubTotal;
            double DiscountAmount;
            double Total;

            try
            {
                //Convert string values to doubles
                SubTotal = Convert.ToDouble(SubTotalTextBox.Text);
                DiscountAmount = SubTotal * DiscountPercent;
                Total = SubTotal - DiscountAmount;

                DiscountAmountTextBox.Text = DiscountAmount.ToString("C2");
                TotalTextBox.Text = Total.ToString("C2");
            }
            catch (Exception exception)
            {

                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                SubTotalTextBox.Focus();
                SubTotalTextBox.SelectAll();
            }

            
            

            

            //Total is equal to the subtotal minus discount amount

            //Display discount amount to related text box

            //Display total to related text box
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
