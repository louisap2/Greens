namespace Greens
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnBuyNow = new System.Windows.Forms.Button();
            this.txtApples = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBananas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOranges = new System.Windows.Forms.TextBox();
            this.lblApplePrice = new System.Windows.Forms.Label();
            this.lblBananasPrice = new System.Windows.Forms.Label();
            this.lblOrangesPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtPurchases = new System.Windows.Forms.TextBox();
            this.btnServiceIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(103, 9);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(210, 22);
            this.txtCustomer.TabIndex = 1;
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.Location = new System.Drawing.Point(103, 143);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(75, 23);
            this.btnBuyNow.TabIndex = 2;
            this.btnBuyNow.Text = "Buy now!";
            this.btnBuyNow.UseVisualStyleBackColor = true;
            this.btnBuyNow.Click += new System.EventHandler(this.btnBuyNow_Click);
            // 
            // txtApples
            // 
            this.txtApples.Location = new System.Drawing.Point(103, 50);
            this.txtApples.Name = "txtApples";
            this.txtApples.Size = new System.Drawing.Size(49, 22);
            this.txtApples.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apples";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bananas";
            // 
            // txtBananas
            // 
            this.txtBananas.Location = new System.Drawing.Point(103, 78);
            this.txtBananas.Name = "txtBananas";
            this.txtBananas.Size = new System.Drawing.Size(49, 22);
            this.txtBananas.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oranges";
            // 
            // txtOranges
            // 
            this.txtOranges.Location = new System.Drawing.Point(103, 106);
            this.txtOranges.Name = "txtOranges";
            this.txtOranges.Size = new System.Drawing.Size(49, 22);
            this.txtOranges.TabIndex = 7;
            // 
            // lblApplePrice
            // 
            this.lblApplePrice.AutoSize = true;
            this.lblApplePrice.Location = new System.Drawing.Point(167, 53);
            this.lblApplePrice.Name = "lblApplePrice";
            this.lblApplePrice.Size = new System.Drawing.Size(25, 17);
            this.lblApplePrice.TabIndex = 9;
            this.lblApplePrice.Text = "?,-";
            // 
            // lblBananasPrice
            // 
            this.lblBananasPrice.AutoSize = true;
            this.lblBananasPrice.Location = new System.Drawing.Point(167, 81);
            this.lblBananasPrice.Name = "lblBananasPrice";
            this.lblBananasPrice.Size = new System.Drawing.Size(25, 17);
            this.lblBananasPrice.TabIndex = 10;
            this.lblBananasPrice.Text = "?,-";
            // 
            // lblOrangesPrice
            // 
            this.lblOrangesPrice.AutoSize = true;
            this.lblOrangesPrice.Location = new System.Drawing.Point(167, 109);
            this.lblOrangesPrice.Name = "lblOrangesPrice";
            this.lblOrangesPrice.Size = new System.Drawing.Size(25, 17);
            this.lblOrangesPrice.TabIndex = 11;
            this.lblOrangesPrice.Text = "?,-";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(106, 180);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 17);
            this.lblTotalPrice.TabIndex = 12;
            // 
            // txtPurchases
            // 
            this.txtPurchases.Location = new System.Drawing.Point(357, 9);
            this.txtPurchases.Multiline = true;
            this.txtPurchases.Name = "txtPurchases";
            this.txtPurchases.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPurchases.Size = new System.Drawing.Size(392, 188);
            this.txtPurchases.TabIndex = 13;
            // 
            // btnServiceIt
            // 
            this.btnServiceIt.Location = new System.Drawing.Point(238, 49);
            this.btnServiceIt.Name = "btnServiceIt";
            this.btnServiceIt.Size = new System.Drawing.Size(75, 23);
            this.btnServiceIt.TabIndex = 14;
            this.btnServiceIt.Text = "Service it";
            this.btnServiceIt.UseVisualStyleBackColor = true;
            this.btnServiceIt.Click += new System.EventHandler(this.btnServiceIt_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 216);
            this.Controls.Add(this.btnServiceIt);
            this.Controls.Add(this.txtPurchases);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblOrangesPrice);
            this.Controls.Add(this.lblBananasPrice);
            this.Controls.Add(this.lblApplePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOranges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBananas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApples);
            this.Controls.Add(this.btnBuyNow);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btnBuyNow;
        private System.Windows.Forms.TextBox txtApples;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBananas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOranges;
        private System.Windows.Forms.Label lblApplePrice;
        private System.Windows.Forms.Label lblBananasPrice;
        private System.Windows.Forms.Label lblOrangesPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtPurchases;
        private System.Windows.Forms.Button btnServiceIt;
    }
}

