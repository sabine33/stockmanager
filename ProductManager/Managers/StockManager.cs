/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/22/2018
 * Time: 8:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using ProductManager.Interfaces;
using ProductManager.Models;

namespace ProductManager.Managers
{
	/// <summary>
	/// Description of StockManager.
	/// </summary>
	public class StockManager:IStockManager
	{
		//self explanatory actions
		public void Purchase(Product product, int quantity)
		{
			DBManager.Update(product,quantity,Actions.Purchase);
		}
		
		public void Sale(Product product, int quantity)
		{
			
				
			DBManager.Update(product,quantity,Actions.Sale);
		}
		
		public void PurchaseReturn(Product product, int quantity)
		{
           
			DBManager.Update(product,quantity,Actions.PurchaseReturn);
		}
		
		public void SalesReturn(Product product, int quantity)
		{
			DBManager.Update(product,quantity,Actions.SalesReturn);
		}
		
		public List<Product> GetAllProducts()
		{
			return DBManager.GetAllProducts();
		}
		public void AddProduct(Product product)
		{
			DBManager.Insert(product);
		}
		
	
	}
}
