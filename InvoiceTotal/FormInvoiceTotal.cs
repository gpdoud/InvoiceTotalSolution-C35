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
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

            decimal discountPercent = 0.0m;
            if(subtotal >= 500) {
                discountPercent = 0.2m;
            } else if(subtotal >= 250 && subtotal < 500) {
                discountPercent = 0.15m;
            } else if(subtotal >= 100 && subtotal < 250) {
                discountPercent = 0.1m;
            }

            decimal disountAmount = subtotal * discountPercent;

            decimal total = subtotal - disountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = disountAmount.ToString("c");
            txtTotal.Text = total.ToString("c");

            txtSubtotal.Focus();
        }
    }
}
