/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/22/2018
 * Time: 8:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using ProductManager.Managers;
using ProductManager.Models;

namespace ProductManager
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		StockManager _stockManager;

		public MainForm()
		{
			
			InitializeComponent();
			_stockManager=new StockManager();
			
			
			
		}
		
		void LoadData()
		{
			List<Product> _allProducts=_stockManager.GetAllProducts();
			lstProductList.DataSource=_allProducts;
			cmbProductList.DataSource=_allProducts;
			cmbActionList.Items.Clear();
			cmbActionList.Items.AddRange(new string[]{"Sale","Purchase","Purchase Return","Sales Return"});
			
			
			lstProductList.DisplayMember="name";
			lstProductList.ValueMember="name";
			cmbProductList.DisplayMember="name";
			cmbProductList.ValueMember="name";
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			LoadData();
			
			lstProductList.SelectedValueChanged+=delegate{
				Product product=lstProductList.SelectedItem as Product;
				txtOpeningStock.Text=(product.Stock).ToString();
				txtQty.Text=product.Stock.ToString();
				txtProductName.Text=product.Name;
			};
			btnAdd.Click+=delegate {
				string productName=txtProductName.Text.Trim().ToUpper();
				int totalStock=0;
				int.TryParse(txtOpeningStock.Text,out totalStock);
				Product product=new Product(productName,totalStock);
				_stockManager.AddProduct(product);
			};
			
			
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnApplyClick(object sender, EventArgs e)
		{
			try
			{
				Product product=cmbProductList.SelectedItem as Product;

				int qty=0;
				int.TryParse(txtQty.Text,out qty);
				string action=cmbActionList.SelectedItem.ToString();
				switch(action)
				{
					case "Sale":
						_stockManager.Sale(product,qty);
						break;
					case "Purchase":
						_stockManager.Purchase(product,qty);
						break;
					case "Sales Return":
						_stockManager.SalesReturn(product,qty);
						break;
					case "Purchase Return":
						_stockManager.PurchaseReturn(product,qty);
						break;
						
				}
				MessageBox.Show("Successfully Done");
				LoadData();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"error");
			}
			
		}
	}
}
