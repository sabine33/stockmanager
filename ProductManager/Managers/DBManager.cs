/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/22/2018
 * Time: 8:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

using ProductManager.Models;

namespace ProductManager.Managers
{
	/// <summary>
	/// Description of DBManager.
	/// </summary>
	public class DBManager
	{
		
		public static void Update(Product product,int qty,Actions action)
		{
			using (SqlConnection con = new SqlConnection(
				Helpers.connectionString))
			{
				con.Open();
				string sql="";
				switch(action)
				{
					case Actions.Purchase:case Actions.SalesReturn:
						sql="Update products set stock=stock+@qty where id=@id";
						break;
					case Actions.Sale:case Actions.PurchaseReturn:
						sql="Update products set stock=stock-@qty where id=@id";
						break;
					default:
						break;
						
				}
				
				try
				{
					using (SqlCommand command = new SqlCommand(
						sql, con))
					{
						command.Parameters.Add(new SqlParameter("qty", qty));
						command.Parameters.Add(new SqlParameter("id", product.Id));
						command.ExecuteNonQuery();
					}
				}
				catch
				{
					Console.WriteLine("Unable to update .");
				}
			}
		}
		public  static void Insert(Product product)
		{
			using (SqlConnection con = new SqlConnection(
				Helpers.connectionString))
			{
				con.Open();
				try
				{
					using (SqlCommand command = new SqlCommand(
						"INSERT INTO products VALUES(@name, @stock)", con))
					{
						command.Parameters.Add(new SqlParameter("name", product.Name));
						command.Parameters.Add(new SqlParameter("stock", product.Stock));
						command.ExecuteNonQuery();
					}
				}
				catch
				{
					Console.WriteLine("Unable to insert .");
				}
			}
		}
		
		public static List<Product> GetAllProducts()
		{
			List<Product> products = new List<Product>();
			using (SqlConnection con = new SqlConnection(
				Helpers.connectionString))
			{
				con.Open();
				string sql="select id,name,stock from products";
				using(SqlCommand sqlCommand=new SqlCommand(sql,con))
				{
					
					SqlDataReader reader = sqlCommand.ExecuteReader();
					while (reader.Read())
					{
						var product = new Product(reader[1].ToString(),(int)reader[2]);
						product.Id=(int)reader[0];
						Debug.WriteLine(product.ToString());
						products.Add(product);
					}
						
				}
				
			}
			return products;
		}
		
	}
}