using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumberyardBuildTool
{
	public partial class WarningForm : Form
	{
		public WarningForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void WarningForm_Load(object sender, EventArgs e)
		{

		}
	}
}
