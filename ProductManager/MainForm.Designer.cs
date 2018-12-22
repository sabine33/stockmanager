/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/22/2018
 * Time: 8:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProductManager
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstProductList = new System.Windows.Forms.ListBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblProductStock = new System.Windows.Forms.Label();
			this.txtOpeningStock = new System.Windows.Forms.TextBox();
			this.cmbProductList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbActionList = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstProductList
			// 
			this.lstProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstProductList.FormattingEnabled = true;
			this.lstProductList.ItemHeight = 20;
			this.lstProductList.Location = new System.Drawing.Point(12, 12);
			this.lstProductList.Name = "lstProductList";
			this.lstProductList.Size = new System.Drawing.Size(256, 324);
			this.lstProductList.TabIndex = 0;
			// 
			// txtProductName
			// 
			this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductName.Location = new System.Drawing.Point(394, 20);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(150, 22);
			this.txtProductName.TabIndex = 1;
			this.txtProductName.Visible = false;
			// 
			// lblProductName
			// 
			this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductName.Location = new System.Drawing.Point(288, 23);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(100, 23);
			this.lblProductName.TabIndex = 2;
			this.lblProductName.Text = "Product Name :";
			this.lblProductName.Visible = false;
			// 
			// lblProductStock
			// 
			this.lblProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductStock.Location = new System.Drawing.Point(288, 48);
			this.lblProductStock.Name = "lblProductStock";
			this.lblProductStock.Size = new System.Drawing.Size(100, 23);
			this.lblProductStock.TabIndex = 4;
			this.lblProductStock.Text = "Total Stock :";
			this.lblProductStock.Visible = false;
			// 
			// txtOpeningStock
			// 
			this.txtOpeningStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtOpeningStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOpeningStock.Location = new System.Drawing.Point(394, 48);
			this.txtOpeningStock.Name = "txtOpeningStock";
			this.txtOpeningStock.Size = new System.Drawing.Size(150, 22);
			this.txtOpeningStock.TabIndex = 3;
			this.txtOpeningStock.Visible = false;
			// 
			// cmbProductList
			// 
			this.cmbProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProductList.FormattingEnabled = true;
			this.cmbProductList.Location = new System.Drawing.Point(394, 160);
			this.cmbProductList.Name = "cmbProductList";
			this.cmbProductList.Size = new System.Drawing.Size(150, 28);
			this.cmbProductList.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(288, 166);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Select Product :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(288, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 22);
			this.label2.TabIndex = 8;
			this.label2.Text = "Action :";
			// 
			// cmbActionList
			// 
			this.cmbActionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbActionList.FormattingEnabled = true;
			this.cmbActionList.Items.AddRange(new object[] {
									"Sale",
									"Purchase",
									"SalesReturn",
									"PurchaseReturn"});
			this.cmbActionList.Location = new System.Drawing.Point(394, 194);
			this.cmbActionList.Name = "cmbActionList";
			this.cmbActionList.Size = new System.Drawing.Size(150, 28);
			this.cmbActionList.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(288, 247);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Total Quantity :";
			// 
			// txtQty
			// 
			this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(394, 237);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(150, 33);
			this.txtQty.TabIndex = 9;
			// 
			// btnApply
			// 
			this.btnApply.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnApply.Location = new System.Drawing.Point(288, 297);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(256, 39);
			this.btnApply.TabIndex = 11;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = false;
			this.btnApply.Click += new System.EventHandler(this.BtnApplyClick);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(394, 85);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(150, 31);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Visible = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(593, 356);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtQty);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbActionList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbProductList);
			this.Controls.Add(this.lblProductStock);
			this.Controls.Add(this.txtOpeningStock);
			this.Controls.Add(this.lblProductName);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.lstProductList);
			this.Name = "MainForm";
			this.Text = "Stock Manager";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbActionList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbProductList;
		private System.Windows.Forms.TextBox txtOpeningStock;
		private System.Windows.Forms.Label lblProductStock;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.ListBox lstProductList;
	}
}
