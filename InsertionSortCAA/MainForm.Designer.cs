﻿namespace InsertionSortCAA
{
	partial class MainForm
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
			this.controlButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// controlButton
			// 
			this.controlButton.Location = new System.Drawing.Point(346, 300);
			this.controlButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.controlButton.Name = "controlButton";
			this.controlButton.Size = new System.Drawing.Size(183, 60);
			this.controlButton.TabIndex = 0;
			this.controlButton.Text = "Start";
			this.controlButton.UseVisualStyleBackColor = true;
			this.controlButton.Click += new System.EventHandler(this.controlButtonClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(931, 391);
			this.Controls.Add(this.controlButton);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button controlButton;
	}
}