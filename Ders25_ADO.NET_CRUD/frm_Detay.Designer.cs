
namespace Ders25_ADO.NET_CRUD
{
    partial class frm_Detay
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_productID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_quantityperunit = new System.Windows.Forms.Label();
            this.lbl_reorderlevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_unitsonorder = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_discontinued = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_productname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN DETAYLARI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProductID";
            // 
            // lbl_productID
            // 
            this.lbl_productID.AutoSize = true;
            this.lbl_productID.Location = new System.Drawing.Point(437, 70);
            this.lbl_productID.Name = "lbl_productID";
            this.lbl_productID.Size = new System.Drawing.Size(13, 13);
            this.lbl_productID.TabIndex = 2;
            this.lbl_productID.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "QuantityPerUnit";
            // 
            // lbl_quantityperunit
            // 
            this.lbl_quantityperunit.AutoSize = true;
            this.lbl_quantityperunit.Location = new System.Drawing.Point(437, 192);
            this.lbl_quantityperunit.Name = "lbl_quantityperunit";
            this.lbl_quantityperunit.Size = new System.Drawing.Size(13, 13);
            this.lbl_quantityperunit.TabIndex = 4;
            this.lbl_quantityperunit.Text = "0";
            // 
            // lbl_reorderlevel
            // 
            this.lbl_reorderlevel.AutoSize = true;
            this.lbl_reorderlevel.Location = new System.Drawing.Point(437, 307);
            this.lbl_reorderlevel.Name = "lbl_reorderlevel";
            this.lbl_reorderlevel.Size = new System.Drawing.Size(13, 13);
            this.lbl_reorderlevel.TabIndex = 8;
            this.lbl_reorderlevel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reorderlevel";
            // 
            // lbl_unitsonorder
            // 
            this.lbl_unitsonorder.AutoSize = true;
            this.lbl_unitsonorder.Location = new System.Drawing.Point(437, 249);
            this.lbl_unitsonorder.Name = "lbl_unitsonorder";
            this.lbl_unitsonorder.Size = new System.Drawing.Size(13, 13);
            this.lbl_unitsonorder.TabIndex = 6;
            this.lbl_unitsonorder.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "UnitsOnOrder";
            // 
            // lbl_discontinued
            // 
            this.lbl_discontinued.AutoSize = true;
            this.lbl_discontinued.Location = new System.Drawing.Point(437, 364);
            this.lbl_discontinued.Name = "lbl_discontinued";
            this.lbl_discontinued.Size = new System.Drawing.Size(13, 13);
            this.lbl_discontinued.TabIndex = 10;
            this.lbl_discontinued.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Discontinued";
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Location = new System.Drawing.Point(437, 132);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(13, 13);
            this.lbl_productname.TabIndex = 12;
            this.lbl_productname.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "ProductName";
            // 
            // frm_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_productname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_discontinued);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_reorderlevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_unitsonorder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_quantityperunit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_productID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Detay";
            this.Text = "frm_Detay";
            this.Load += new System.EventHandler(this.frm_Detay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_productID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_quantityperunit;
        private System.Windows.Forms.Label lbl_reorderlevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_unitsonorder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_discontinued;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.Label label8;
    }
}