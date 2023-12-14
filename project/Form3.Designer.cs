namespace project
{
    partial class Form3
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
            this.buttonAllVendor = new System.Windows.Forms.Button();
            this.buttonPurchasingHistory = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAllVendor
            // 
            this.buttonAllVendor.Location = new System.Drawing.Point(58, 50);
            this.buttonAllVendor.Name = "buttonAllVendor";
            this.buttonAllVendor.Size = new System.Drawing.Size(168, 23);
            this.buttonAllVendor.TabIndex = 0;
            this.buttonAllVendor.Text = "VendorData";
            this.buttonAllVendor.UseVisualStyleBackColor = true;
            this.buttonAllVendor.Click += new System.EventHandler(this.buttonAllVendor_Click);
            // 
            // buttonPurchasingHistory
            // 
            this.buttonPurchasingHistory.Location = new System.Drawing.Point(58, 93);
            this.buttonPurchasingHistory.Name = "buttonPurchasingHistory";
            this.buttonPurchasingHistory.Size = new System.Drawing.Size(168, 23);
            this.buttonPurchasingHistory.TabIndex = 1;
            this.buttonPurchasingHistory.Text = "Purchasing History";
            this.buttonPurchasingHistory.UseVisualStyleBackColor = true;
            this.buttonPurchasingHistory.Click += new System.EventHandler(this.buttonPurchasingHistory_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(215, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 218);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonPurchasingHistory);
            this.Controls.Add(this.buttonAllVendor);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAllVendor;
        private System.Windows.Forms.Button buttonPurchasingHistory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonBack;
    }
}