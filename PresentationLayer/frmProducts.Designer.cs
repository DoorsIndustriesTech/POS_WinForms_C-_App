namespace PresentationLayer
{
    partial class frmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.NumericUpDown();
            this.lblCurrencySign = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnProductClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(77, 133);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(80, 31);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Name:";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductPrice.Location = new System.Drawing.Point(77, 188);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(69, 31);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "Price:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.DecimalPlaces = 2;
            this.txtProductPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductPrice.Location = new System.Drawing.Point(195, 185);
            this.txtProductPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(150, 34);
            this.txtProductPrice.TabIndex = 2;
            // 
            // lblCurrencySign
            // 
            this.lblCurrencySign.AutoSize = true;
            this.lblCurrencySign.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrencySign.Location = new System.Drawing.Point(163, 188);
            this.lblCurrencySign.Name = "lblCurrencySign";
            this.lblCurrencySign.Size = new System.Drawing.Size(26, 31);
            this.lblCurrencySign.TabIndex = 3;
            this.lblCurrencySign.Text = "$";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(163, 137);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(182, 27);
            this.txtProductName.TabIndex = 4;
            // 
            // btnProductClear
            // 
            this.btnProductClear.Location = new System.Drawing.Point(12, 410);
            this.btnProductClear.Name = "btnProductClear";
            this.btnProductClear.Size = new System.Drawing.Size(94, 29);
            this.btnProductClear.TabIndex = 5;
            this.btnProductClear.Text = "Limpiar";
            this.btnProductClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(314, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 451);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnProductClear);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblCurrencySign);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductName);
            this.Name = "frmProducts";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.txtProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProductName;
        private Label lblProductPrice;
        private NumericUpDown txtProductPrice;
        private Label lblCurrencySign;
        private TextBox txtProductName;
        private Button btnProductClear;
        private Button btnAdd;
    }
}