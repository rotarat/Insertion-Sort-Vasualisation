namespace InsertionSortCAA
{
	partial class StartForm
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
			this.generalText = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.TextBox();
			this.enterButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// generalText
			// 
			this.generalText.AutoSize = true;
			this.generalText.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.generalText.Font = new System.Drawing.Font("High Tower Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.generalText.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.generalText.Location = new System.Drawing.Point(45, 42);
			this.generalText.Name = "generalText";
			this.generalText.Size = new System.Drawing.Size(547, 44);
			this.generalText.TabIndex = 0;
			this.generalText.Text = "Въведете масив за сортиране";
			// 
			// textBox1
			// 
			this.textBox.Location = new System.Drawing.Point(53, 155);
			this.textBox.Name = "textBox1";
			this.textBox.Size = new System.Drawing.Size(446, 20);
			this.textBox.TabIndex = 1;
			this.textBox.TextChanged += new System.EventHandler(AddText);

			// 
			// enterButton
			// 
			this.enterButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.enterButton.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enterButton.ForeColor = System.Drawing.SystemColors.Highlight;
			this.enterButton.Location = new System.Drawing.Point(517, 152);
			this.enterButton.Name = "enterButton";
			this.enterButton.Size = new System.Drawing.Size(75, 23);
			this.enterButton.TabIndex = 2;
			this.enterButton.Text = "Go";
			this.enterButton.UseVisualStyleBackColor = false;
			this.enterButton.Click += new System.EventHandler(this.Go_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 228);
			this.Controls.Add(this.enterButton);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.generalText);
			this.Name = "Form1";
			this.Text = "Go";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label generalText;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button enterButton;
	}
}

