using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InsertionSortCAA
{
	public partial class StartForm : Form
	{
		private bool arrayInserted;
		public static List<int> array;
		public StartForm()
		{
			InitializeComponent();
			arrayInserted = false;
			array = new List<int>();
		}
		private void AddText(object sender, EventArgs e)
		{
			arrayInserted = true;
		}

		private void Go_Click(object sender, EventArgs e)
		{
			if (arrayInserted)
			{
				string text = textBox.Text;
				string element = "";
				for (int i = 0; i < text.Length; i++)
				{
					if (int.TryParse(text[i].ToString(), out int num))
					{
						element = String.Concat(element, text[i].ToString());
					}
					else if (text[i] == ' ' && element != "")
					{
						array.Add(int.Parse(element));
						element = "";
					}
					{
						continue;
					}
				}	
				if (element != "")
				{
					array.Add(int.Parse(element));
				}
				MainForm mainForm = new MainForm();
				mainForm.Show();
				Hide();
			} 
			else
			{
				MessageBox.Show("Invalid input");
				arrayInserted = false;
				textBox.Clear();
			}
			//
		}
	}
}
