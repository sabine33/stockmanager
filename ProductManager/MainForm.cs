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

		List<Product> _allProducts;
		public MainForm()
		{
			
			InitializeComponent();
			_stockManager=new StockManager();
			
			
		}
		
		void LoadData()
		{
			//load data from database to list
			
			_allProducts=_stockManager.GetAllProducts();
			lstProductList.DataSource=_allProducts;
			cmbProductList.DataSource=_allProducts;
			cmbActionList.Items.Clear();
			cmbActionList.Items.AddRange(new string[]{"Sale","Purchase","Purchase Return","Sales Return"});
			
			
			lstProductList.DisplayMember="name";
			lstProductList.ValueMember="name";
			cmbProductList.DisplayMember="name";
			cmbProductList.ValueMember="name";
		}
		void LazyLoadData(Product product)
		{
			Product _updated=_stockManager.GetProduct(product.Id);
			_allProducts[_allProducts.IndexOf(product)]=_updated;
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			LoadData();
			
			//on product selected
			
			lstProductList.SelectedValueChanged+=delegate{
				Product product=lstProductList.SelectedItem as Product;
				txtOpeningStock.Text=(product.Stock).ToString();
				txtQty.Text=product.Stock.ToString();
				txtProductName.Text=product.Name;
			};
			
			//on add button clicked
			
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
			//on apply button clicked
			try
			{
				Product product=cmbProductList.SelectedItem as Product;

				int qty=0;
				int.TryParse(txtQty.Text,out qty);
				string action=cmbActionList.SelectedItem.ToString();
				bool isSuccess=false;
				switch(action)
				{
					case "Sale":
						if(_stockManager.ValidateForDecrement(product,qty))
						{
							_stockManager.Sale(product,qty);
							isSuccess=true;
						}
						else
						{
							
							MessageBox.Show("Please enter valid quantity");
							isSuccess=false;
						}
						break;
					case "Purchase":
						_stockManager.Purchase(product,qty);
						isSuccess=true;
						break;
					case "Sales Return":
						_stockManager.SalesReturn(product,qty);
						isSuccess=true;
						break;
					case "Purchase Return":
						if(_stockManager.ValidateForDecrement(product,qty))
						{
							_stockManager.PurchaseReturn(product,qty);
							isSuccess=true;
						}
						else
						{
							
							MessageBox.Show("Please enter valid quantity");
							isSuccess=false;
							
						}
						break;
				}
				if(isSuccess)
				{
					MessageBox.Show("Successfully Done");
				}
				else
				{
					MessageBox.Show("Unable to apply action");
				}
				LoadData();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"error");
			}
			
		}
	}
}
