namespace InvoiceTotal {
    partial class FormInvoiceTotal {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberOfInvoices = new System.Windows.Forms.TextBox();
            this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter &Subtotal:";
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.Location = new System.Drawing.Point(150, 28);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(118, 23);
            this.txtEnterSubtotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount Percent:";
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(150, 121);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(118, 23);
            this.txtDiscountPercent.TabIndex = 3;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(150, 165);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(118, 23);
            this.txtDiscountAmount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Discount Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(150, 209);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(118, 23);
            this.txtTotal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(342, 239);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(544, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(150, 73);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(118, 23);
            this.txtSubtotal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of Invoices:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total of Invoices:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Invoice Average:";
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(490, 57);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.ReadOnly = true;
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(129, 23);
            this.txtNumberOfInvoices.TabIndex = 15;
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(490, 108);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.ReadOnly = true;
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(129, 23);
            this.txtTotalOfInvoices.TabIndex = 16;
            this.txtTotalOfInvoices.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.Location = new System.Drawing.Point(490, 162);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(129, 23);
            this.txtInvoiceAverage.TabIndex = 17;
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Location = new System.Drawing.Point(443, 239);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(75, 23);
            this.btnClearTotals.TabIndex = 18;
            this.btnClearTotals.Text = "Clear";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // FormInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(681, 426);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.label1);
            this.Name = "FormInvoiceTotal";
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberOfInvoices;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.Button btnClearTotals;
    }
}
