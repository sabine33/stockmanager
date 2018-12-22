/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/22/2018
 * Time: 8:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProductManager.Models
{
	/// <summary>
	/// Description of Product.
	/// </summary>
	public class Product
	{
		public int Id{get;set;}
		public string Name{get;set;}
		public int Stock{get;set;}
		
		public Product(string name,int openingStock)
		{
		
			this.Name=name;
			this.Stock=openingStock;
		}
		
		public override string ToString()
		{
			return string.Format("[Product Id={0}, Name={1}, Stock={2}]", Id, Name, Stock);
		}

	}
}
