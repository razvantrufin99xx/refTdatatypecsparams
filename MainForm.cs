/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/19/2024
 * Time: 2:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace textBox2DatatypeValidation
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void functioncalled()
		{
		int number = 0;
      
        
        ModifyValue(ref textBox1, "int" , ref number);
        
        
		}
		public static  ModifyValue<T>(ref TextBox t,string datatypex,  ref T value)
		{
			
			if (value is int)
        	{
            value = (T)(object)((int)(object)value + 10);
        	}
	        else if (value is string)
	        {
	            value = (T)(object)("Modified: " + value);
	        }
			
		}
		
		
	}
	

}
