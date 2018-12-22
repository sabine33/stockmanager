/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/22/2018
 * Time: 8:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProductManager.Managers
{
	/// <summary>
	/// Description of Helpers.
	/// </summary>
	/// 
	//helpers with satatic props
	public static class Helpers
	{
		
		public static string connectionString="Server=ANSSOFT;Database=products_db;User Id=sa;Password=123;";
		
	}
	//possible Actions
	public enum Actions
	{
		Sale,Purchase,SalesReturn,PurchaseReturn
			
	}
}
