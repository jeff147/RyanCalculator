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
            // Initialize variables  
            double stitchCount = 0;
            double quantity = 0;
            double numColors = 0;
            double numPlacements = 0;

            double price = 0;

            // Try to get numbers from text fields
            try
            {
                stitchCount = double.Parse(txtStitchCount.Text);
                quantity = double.Parse(txtQuantity.Text);
                numColors = double.Parse(txtNumColors.Text);
                numPlacements = double.Parse(txtNumPlacements.Text);
                //txtResult.Text = (stitchCount + quantity + numColors + numPlacements).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input numbers only.");
                txtResult.Text = "ERROR";
            }

            // There are about to be a lot of if and switch statements
            if (quantity >= 12 && quantity <= 24)
            {
                switch (numColors)
                {
                    case 1:
                        price = 1.20;
                        break;
                    case 2:
                        price = 1.85;
                        break;
                    case 3:
                        price = 2.40;
                        break;
                    case 4:
                        price = 3.60;
                        break;
                    case 5:
                        price = 4.20;
                        break;
                    case 6:
                        price = 4.80;
                        break;
                }
            }
            else if (quantity >= 25 && quantity <= 48)
            {
                switch (numColors)
                {
                    case 1:
                        price = 1.10;
                        break;
                    case 2:
                        price = 1.65;
                        break;
                    case 3:
                        price = 2.20;
                        break;
                    case 4:
                        price = 2.70;
                        break;
                    case 5:
                        price = 3.20;
                        break;
                    case 6:
                        price = 3.70;
                        break;
                }
            }
            else if (quantity >= 49 && quantity <= 96)
            {
                switch (numColors)
                {
                    case 1:
                        price = 1.00;
                        break;
                    case 2:
                        price = 1.50;
                        break;
                    case 3:
                        price = 2.00;
                        break;
                    case 4:
                        price = 2.50;
                        break;
                    case 5:
                        price = 3.00;
                        break;
                    case 6:
                        price = 3.50;
                        break;
                }
            }
            else if (quantity >=97 && quantity <= 144)
            {
                switch (numColors)
                {
                    case 1:
                        price = .95;
                        break;
                    case 2:
                        price = 1.35;
                        break;
                    case 3:
                        price = 1.80;
                        break;
                    case 4:
                        price = 2.20;
                        break;
                    case 5:
                        price = 2.60;
                        break;
                    case 6:
                        price = 3.00;
                        break;
                }
            }
            else if (quantity >= 145 && quantity <= 249)
            {
                switch (numColors)
                {
                    case 1:
                        price = .80;
                        break;
                    case 2:
                        price = 1.10;
                        break;
                    case 3:
                        price = 1.40;
                        break;
                    case 4:
                        price = 1.70;
                        break;
                    case 5:
                        price = 2.00;
                        break;
                    case 6:
                        price = 2.30;
                        break;
                }
            }
            else if (quantity >= 250 && quantity <= 499)
            {
                switch (numColors)
                {
                    case 1:
                        price = .70;
                        break;
                    case 2:
                        price = .80;
                        break;
                    case 3:
                        price = .92;
                        break;
                    case 4:
                        price = 1.10;
                        break;
                    case 5:
                        price = 1.25;
                        break;
                    case 6:
                        price = 1.40;
                        break;
                }
            }
            else if (quantity >= 500 && quantity <= 999)
            {
                switch (numColors)
                {
                    case 1:
                        price = .57;
                        break;
                    case 2:
                        price = .75;
                        break;
                    case 3:
                        price = .87;
                        break;
                    case 4:
                        price = .96;
                        break;
                    case 5:
                        price = 1.06;
                        break;
                    case 6:
                        price = 1.15;
                        break;
                }
            }
            else if (quantity >= 1000 && quantity <= 1999)
            {
                switch (numColors)
                {
                    case 1:
                        price = .51;
                        break;
                    case 2:
                        price = .62;
                        break;
                    case 3:
                        price = .75;
                        break;
                    case 4:
                        price = .84;
                        break;
                    case 5:
                        price = .93;
                        break;
                    case 6:
                        price = 1.05;
                        break;
                }
            }
            txtResult.Text = price.ToString();



            /*int added = 0;
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
            */
        }
    }
}
