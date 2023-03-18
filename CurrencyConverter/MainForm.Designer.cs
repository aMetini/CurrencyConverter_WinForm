namespace CurrencyConverter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFromCurrency = new System.Windows.Forms.TextBox();
            this.txtToCurrency = new System.Windows.Forms.TextBox();
            this.cmbFromCurrency = new System.Windows.Forms.ComboBox();
            this.cmbToCurrency = new System.Windows.Forms.ComboBox();
            this.btnConvertCurrency = new System.Windows.Forms.Button();
            this.lblFromCuurency = new System.Windows.Forms.Label();
            this.lblToCurrency = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtFromCurrency Styling
            this.txtFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromCurrency.Location = new System.Drawing.Point(111, 79);
            this.txtFromCurrency.Name = "txtFromCurrency";
            this.txtFromCurrency.Size = new System.Drawing.Size(181, 38);
            this.txtFromCurrency.TabIndex = 0;

            //txtToCurrency Styling
            this.txtToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToCurrency.Location = new System.Drawing.Point(817, 76);
            this.txtToCurrency.Name = "txtToCurrency";
            this.txtToCurrency.Size = new System.Drawing.Size(176, 38);
            this.txtToCurrency.TabIndex = 1;

            // cmbFromCurrency Styling
            this.cmbFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromCurrency.FormattingEnabled = true;
            this.cmbFromCurrency.Location = new System.Drawing.Point(308, 79);
            this.cmbFromCurrency.Name = "cmbFromCurrency";
            this.cmbFromCurrency.Size = new System.Drawing.Size(443, 37);
            this.cmbFromCurrency.TabIndex = 2;

            // cmbToCurrency Styling
            this.cmbToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToCurrency.FormattingEnabled = true;
            this.cmbToCurrency.Location = new System.Drawing.Point(1025, 77);
            this.cmbToCurrency.Name = "cmbToCurrency";
            this.cmbToCurrency.Size = new System.Drawing.Size(382, 37);
            this.cmbToCurrency.TabIndex = 3;

            // btnConverCurrency Styling
            this.btnConvertCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertCurrency.Location = new System.Drawing.Point(682, 160);
            this.btnConvertCurrency.Name = "btnConvert";
            this.btnConvertCurrency.Size = new System.Drawing.Size(124, 49);
            this.btnConvertCurrency.TabIndex = 4;
            this.btnConvertCurrency.Text = "Convert";
            this.btnConvertCurrency.UseVisualStyleBackColor = true;
            this.btnConvertCurrency.Click += new System.EventHandler(this.btnConvertCurrency_Click);

            // lblFromCurrency Styling
            this.lblFromCuurency.AutoSize = true;
            this.lblFromCuurency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromCuurency.Location = new System.Drawing.Point(106, 25);
            this.lblFromCuurency.Name = "lblFromCuurency";
            this.lblFromCuurency.Size = new System.Drawing.Size(142, 25);
            this.lblFromCuurency.TabIndex = 5;
            this.lblFromCuurency.Text = "From Currency";

            // lblToCurrency Styling
            this.lblToCurrency.AutoSize = true;
            this.lblToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToCurrency.Location = new System.Drawing.Point(812, 25);
            this.lblToCurrency.Name = "lblToCurrency";
            this.lblToCurrency.Size = new System.Drawing.Size(121, 25);
            this.lblToCurrency.TabIndex = 6;
            this.lblToCurrency.Text = "To Currency";

            // MainForm Styling
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 238);
            this.Controls.Add(this.lblToCurrency);
            this.Controls.Add(this.lblFromCuurency);
            this.Controls.Add(this.btnConvertCurrency);
            this.Controls.Add(this.cmbFromCurrency);
            this.Controls.Add(this.cmbToCurrency);
            this.Controls.Add(this.txtFromCurrency);
            this.Controls.Add(this.txtToCurrency);
            this.components = new System.ComponentModel.Container();
            this.Name = "MainForm";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.MainForm_Load);
        }

        #endregion

        private System.Windows.Forms.TextBox txtToCurrency;
        private ComboBox cmbFromCurrency;
        private ComboBox cmbToCurrency;
        private Button btnConvertCurrency;
        private Label lblFromCuurency;
        private Label lblToCurrency;
        private System.Windows.Forms.TextBox txtFromCurrency;
    }
}