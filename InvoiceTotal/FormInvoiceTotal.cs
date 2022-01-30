using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal {

    public partial class FormInvoiceTotal : Form {

        public FormInvoiceTotal() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            string customerType = txtCustomerType.Text;
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

            decimal discountPercent = 0.0m;
            if (customerType == "R" || customerType == "r") {

                if (subtotal < 100)
                    discountPercent = .0m;
                else if (subtotal >= 100 && subtotal < 250)
                    discountPercent = .1m;
                else if (subtotal >= 250 && subtotal < 500)
                    discountPercent = .25m;
                else
                    discountPercent = .3m;

            } else if(customerType == "C" || customerType == "c") {

                discountPercent = .2m;

            } else if (customerType == "T" || customerType == "t") {

                if (subtotal < 500)
                    discountPercent = .4m;
                else
                    discountPercent = .5m;

            } else {
                discountPercent = .1m;
            }

            decimal disountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - disountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = disountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCustomerType.Focus();
        }
    }
}
