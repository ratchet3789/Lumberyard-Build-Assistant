using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using LumberyardBuildAssistant.Code;

namespace LumberyardBuildTool
{
	public partial class Form1 : Form
	{
		string[] BuildCommand;
		string OutputValue;
		bool hasWaf;

		public Form1()
		{
			InitializeComponent();
			BuildCommand = new string[6];
			string[] FileData = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);

			//Check if any WAF files exist in the directory.
			foreach (string file in FileData)
			{
				if (file.Contains("lmbr_waf.bat"))
					hasWaf = true;
			}
			if (!hasWaf)
			{
				WarningForm wf = new WarningForm();
				wf.ShowDialog();
			}

			//setup default ComboBox data
			BuildCleanPackage_ComboBox.SelectedIndex = 0;
			Android64_ComboBox.SelectedIndex = 0;
			Compiler_ComboBox.SelectedIndex = Compiler_ComboBox.Items.Count - 1;
			Configuration_ComboBox.SelectedIndex = 0;
			Spec_ComboBox.SelectedIndex = 0;

			//Log welcome message.
			LoggingtextBox.Text = string.Empty;
			InfoLog(Application.ProductName + " - v " + Application.ProductVersion);
			InfoLog("\nCurrently Supports Lumberyard 1.17.0.0 to 1.21.2.0");
		}

		private void BuildCleanPackage_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string ProcessedPackageType = BuildCleanPackage_ComboBox.GetItemText(BuildCleanPackage_ComboBox.SelectedItem).ToLower();
			BuildCommand[0] = ProcessedPackageType;
		}

		private void Android64_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string ProcessedAndroid64 = Android64_ComboBox.GetItemText(Android64_ComboBox.SelectedItem).ToLower().Replace(" ", "_");
			BuildCommand[1] = "_" + ProcessedAndroid64;

			//Swap MSVS/Clang Win for ARMV Clang Android (Fastest way)
			if (ProcessedAndroid64.Contains("android") && !Compiler_ComboBox.Items.Contains("ARM"))
			{
				Compiler_ComboBox.Items.Clear();
				Compiler_ComboBox.Items.Add("ARMv7 clang");
				Compiler_ComboBox.Items.Add("ARMv8 clang");
			}

			if (ProcessedAndroid64.Contains("x64") && !Compiler_ComboBox.Items.Contains("vs"))
			{
				Compiler_ComboBox.Items.Clear();
				Compiler_ComboBox.Items.Add("clang");
				Compiler_ComboBox.Items.Add("VS2013");
				Compiler_ComboBox.Items.Add("VS2015");
				Compiler_ComboBox.Items.Add("VS2017");
			}
		}

		private void Compiler_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string ProcessedCompiler = "_" + Compiler_ComboBox.GetItemText(Compiler_ComboBox.SelectedItem).ToLower().Replace(" ", "_");
			BuildCommand[2] = ProcessedCompiler;
		}

		private void Configuration_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string ProcessedConfiguration = "_" + Configuration_ComboBox.GetItemText(Configuration_ComboBox.SelectedItem).ToLower();
			BuildCommand[3] = ProcessedConfiguration;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (dedicatedServerBuild.Checked)
				BuildCommand[4] = "_dedicated";
			else
				BuildCommand[4] = string.Empty;
		}

		private void Spec_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//because Spec works a bit differently we have to process in a few different ways
			string specInput = Spec_ComboBox.GetItemText(Spec_ComboBox.SelectedItem).ToLower();
			specInput = specInput.Replace(' ', '_');
			string ProcessedSpec = " -p " + specInput;
			BuildCommand[5] = ProcessedSpec;
			InfoLog(ProcessedSpec);
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			//Automatically scroll to the bottom of the text box.
			LoggingtextBox.SelectionStart = LoggingtextBox.Text.Length;
			LoggingtextBox.ScrollToCaret();
		}

		private void BuildButton_Click(object sender, EventArgs e)
		{
			LoggingtextBox.Text = string.Empty;
			OutputValue = string.Empty;

			//Build our waf build string
			for (int i = 0; i < BuildCommand.Length; i++)
			{
				if (BuildCommand[i] != null && BuildCommand[i] != string.Empty)
				{
					OutputValue += BuildCommand[i];
				}
			}
			InfoLog("Executing: lmbr_waf " + OutputValue);
			FindRunWAF();
		}

		void FindRunWAF()
		{
			System.Diagnostics.Process Proc = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo PSI = new System.Diagnostics.ProcessStartInfo();

			//Start Windows CMD and parse build string.
			PSI.FileName = "CMD.EXE";
			PSI.Arguments = "/K lmbr_waf " + OutputValue + " >> Build.log";

			Proc.StartInfo = PSI;
			Proc.Start();
			LoggingtextBox.Text += "\nCheck Build.log for messages upon completion";
		}

		void InfoLog(string InputData)
		{
			LoggingtextBox.Text += "\n" + InputData;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			InfoLog("Executing: lmbr_waf configure");
			System.Diagnostics.Process Proc = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo PSI = new System.Diagnostics.ProcessStartInfo();

			//Start Windows CMD and parse build string.
			PSI.FileName = "CMD.EXE";
			PSI.Arguments = "/K lmbr_waf configure >> Build.log";
			Proc.StartInfo = PSI;
			Proc.Start();
			while (!Proc.HasExited)
			{
				LoggingtextBox.Text += Proc.StandardOutput.ReadLine();
				Proc.WaitForExit();
			}
			LoggingtextBox.Text += "Check Build.log for messages";
		}
	}
}
