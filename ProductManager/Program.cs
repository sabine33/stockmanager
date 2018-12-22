/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/22/2018
 * Time: 8:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using ProductManager.Managers;

namespace ProductManager
{

	class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			
		
			
			Application.EnableVisualStyles();
			      Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}