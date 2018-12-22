/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/22/2018
 * Time: 8:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using ProductManager.Models;
namespace ProductManager.Interfaces
{
	/// <summary>
	/// Description of IProductManager.
	/// </summary>
	/// 
	
	//interface to manage all stock related operations
	public interface IStockManager
	{
		void Purchase(Product product, int quantity);
		void Sale(Product product, int quantity);
		void PurchaseReturn(Product product, int quantity);
		void SalesReturn(Product product, int quantity);
		List<Product> GetAllProducts();
		void AddProduct(Product product);
		bool ValidateForDecrement(Product product,int quantity);
	}
}
