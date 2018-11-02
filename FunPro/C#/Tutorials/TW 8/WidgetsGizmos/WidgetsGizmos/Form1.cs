using System;
using System.Windows.Forms;

namespace WidgetsGizmos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //grab the input
            var clientName = tbxName.Text;
            var product = tbxType.Text;
            var amountEntered = tbxAmount.Text;

            //validate product
            if (product != "w" && product != "g")
            {
                MessageBox.Show("Please enter proper product type");
                return;
            }

            //price and full name
            double price;
            string productName;
            if (product == "w") //widget
            {
                price = 0.25;
                productName = "Widget";
            }
            else //gizmo
            {
                price = 0.75;
                productName = "Gizmo";
            }

            //validate quantity
            if (!int.TryParse(amountEntered, out var quantity))
            {
                MessageBox.Show("Please enter proper quantity");
                return;
            }

            //check ordering policy
            if (product == "w") //widget
            {
                if (quantity <= 0 || quantity % 12 != 0 || quantity > 144)
                {
                    MessageBox.Show("Amount is not correct for widget ordering policy");
                    return;
                }
            }
            else //gizmo
            {
                if (quantity <= 0 || quantity % 8 != 0)
                {
                    MessageBox.Show("Amount is not correct for gizmo ordering policy");
                    return;
                }
            }

            //if we are here, all data is valid
            //ready to calculate
            var message = $@"
Client name: {clientName}
Product: {productName}
Quantity: {quantity:N0}
Order total: {quantity * price:C2}";
            MessageBox.Show(message);
        }
    }
}
