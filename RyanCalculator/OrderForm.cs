using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyanCalculator
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int added = 0;
            try
            {
                added = int.Parse(txtStitchCount.Text) + int.Parse(txtQuantity.Text);
                txtResult.Text = added.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input numbers only.");
                txtResult.Text = "ERROR";
            }
        }
    }
}
