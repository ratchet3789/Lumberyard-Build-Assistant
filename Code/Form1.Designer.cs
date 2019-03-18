using System.Windows.Forms;

namespace LumberyardBuildTool
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.BuildCleanPackage_ComboBox = new System.Windows.Forms.ComboBox();
			this.dedicatedServerBuild = new System.Windows.Forms.CheckBox();
			this.BuildButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Android64_ComboBox = new System.Windows.Forms.ComboBox();
			this.Compiler_ComboBox = new System.Windows.Forms.ComboBox();
			this.Configuration_ComboBox = new System.Windows.Forms.ComboBox();
			this.LoggingtextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Build, Clean or Package?";
			// 
			// BuildCleanPackage_ComboBox
			// 
			this.BuildCleanPackage_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BuildCleanPackage_ComboBox.FormattingEnabled = true;
			this.BuildCleanPackage_ComboBox.Items.AddRange(new object[] {
            "Build",
            "Clean",
            "Package"});
			this.BuildCleanPackage_ComboBox.Location = new System.Drawing.Point(208, 7);
			this.BuildCleanPackage_ComboBox.Name = "BuildCleanPackage_ComboBox";
			this.BuildCleanPackage_ComboBox.Size = new System.Drawing.Size(121, 21);
			this.BuildCleanPackage_ComboBox.TabIndex = 1;
			this.BuildCleanPackage_ComboBox.SelectedIndexChanged += new System.EventHandler(this.BuildCleanPackage_ComboBox_SelectedIndexChanged);
			// 
			// dedicatedServerBuild
			// 
			this.dedicatedServerBuild.AutoSize = true;
			this.dedicatedServerBuild.Location = new System.Drawing.Point(11, 130);
			this.dedicatedServerBuild.Name = "dedicatedServerBuild";
			this.dedicatedServerBuild.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dedicatedServerBuild.Size = new System.Drawing.Size(81, 17);
			this.dedicatedServerBuild.TabIndex = 2;
			this.dedicatedServerBuild.Text = "?Dedicated";
			this.dedicatedServerBuild.UseVisualStyleBackColor = true;
			this.dedicatedServerBuild.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// BuildButton
			// 
			this.BuildButton.Location = new System.Drawing.Point(254, 240);
			this.BuildButton.Name = "BuildButton";
			this.BuildButton.Size = new System.Drawing.Size(75, 23);
			this.BuildButton.TabIndex = 3;
			this.BuildButton.Text = "BUILD";
			this.BuildButton.UseVisualStyleBackColor = true;
			this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "x64 or Android?";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Compiler?";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Configuration";
			// 
			// Android64_ComboBox
			// 
			this.Android64_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Android64_ComboBox.FormattingEnabled = true;
			this.Android64_ComboBox.Items.AddRange(new object[] {
            "Win x64",
            "Android"});
			this.Android64_ComboBox.Location = new System.Drawing.Point(208, 37);
			this.Android64_ComboBox.Name = "Android64_ComboBox";
			this.Android64_ComboBox.Size = new System.Drawing.Size(121, 21);
			this.Android64_ComboBox.TabIndex = 7;
			this.Android64_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Android64_ComboBox_SelectedIndexChanged);
			// 
			// Compiler_ComboBox
			// 
			this.Compiler_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Compiler_ComboBox.FormattingEnabled = true;
			this.Compiler_ComboBox.Items.AddRange(new object[] {
            "Clang",
            "VS2013",
            "VS2015",
            "VS2017"});
			this.Compiler_ComboBox.Location = new System.Drawing.Point(208, 67);
			this.Compiler_ComboBox.Name = "Compiler_ComboBox";
			this.Compiler_ComboBox.Size = new System.Drawing.Size(121, 21);
			this.Compiler_ComboBox.TabIndex = 8;
			this.Compiler_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Compiler_ComboBox_SelectedIndexChanged);
			// 
			// Configuration_ComboBox
			// 
			this.Configuration_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Configuration_ComboBox.FormattingEnabled = true;
			this.Configuration_ComboBox.Items.AddRange(new object[] {
            "Debug",
            "Profile",
            "Performance",
            "Release"});
			this.Configuration_ComboBox.Location = new System.Drawing.Point(208, 97);
			this.Configuration_ComboBox.Name = "Configuration_ComboBox";
			this.Configuration_ComboBox.Size = new System.Drawing.Size(121, 21);
			this.Configuration_ComboBox.TabIndex = 9;
			this.Configuration_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Configuration_ComboBox_SelectedIndexChanged);
			// 
			// LoggingtextBox
			// 
			this.LoggingtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LoggingtextBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.LoggingtextBox.Location = new System.Drawing.Point(11, 153);
			this.LoggingtextBox.Name = "LoggingtextBox";
			this.LoggingtextBox.ReadOnly = true;
			this.LoggingtextBox.Size = new System.Drawing.Size(318, 81);
			this.LoggingtextBox.TabIndex = 11;
			this.LoggingtextBox.Text = "";
			this.LoggingtextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 271);
			this.Controls.Add(this.LoggingtextBox);
			this.Controls.Add(this.Configuration_ComboBox);
			this.Controls.Add(this.Compiler_ComboBox);
			this.Controls.Add(this.Android64_ComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BuildButton);
			this.Controls.Add(this.dedicatedServerBuild);
			this.Controls.Add(this.BuildCleanPackage_ComboBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Lumberyard Build Tool (Unofficial) ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox BuildCleanPackage_ComboBox;
		private System.Windows.Forms.CheckBox dedicatedServerBuild;
		private System.Windows.Forms.Button BuildButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Android64_ComboBox;
		private System.Windows.Forms.ComboBox Compiler_ComboBox;
		private System.Windows.Forms.ComboBox Configuration_ComboBox;
		private System.Windows.Forms.RichTextBox LoggingtextBox;
	}
}

