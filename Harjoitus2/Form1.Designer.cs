
namespace Harjoitus_2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.OtsikkoLB = new System.Windows.Forms.Label();
			this.TulostusLB = new System.Windows.Forms.Label();
			this.ViestiTB = new System.Windows.Forms.TextBox();
			this.tulostaBT = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// OtsikkoLB
			// 
			this.OtsikkoLB.AutoSize = true;
			this.OtsikkoLB.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.OtsikkoLB.Location = new System.Drawing.Point(169, 191);
			this.OtsikkoLB.Name = "OtsikkoLB";
			this.OtsikkoLB.Size = new System.Drawing.Size(432, 51);
			this.OtsikkoLB.TabIndex = 0;
			this.OtsikkoLB.Text = "Anna tulostettava teksti";
			// 
			// TulostusLB
			// 
			this.TulostusLB.AutoSize = true;
			this.TulostusLB.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TulostusLB.Location = new System.Drawing.Point(169, 358);
			this.TulostusLB.Name = "TulostusLB";
			this.TulostusLB.Size = new System.Drawing.Size(111, 51);
			this.TulostusLB.TabIndex = 1;
			this.TulostusLB.Text = "xxxx";
			this.TulostusLB.Visible = false;
			this.TulostusLB.Click += new System.EventHandler(this.label1_Click);
			// 
			// ViestiTB
			// 
			this.ViestiTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ViestiTB.Location = new System.Drawing.Point(622, 187);
			this.ViestiTB.Name = "ViestiTB";
			this.ViestiTB.Size = new System.Drawing.Size(380, 50);
			this.ViestiTB.TabIndex = 2;
			this.ViestiTB.TextChanged += new System.EventHandler(this.ViestiTB_TextChanged);
			// 
			// tulostaBT
			// 
			this.tulostaBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.tulostaBT.Location = new System.Drawing.Point(134, 447);
			this.tulostaBT.Name = "tulostaBT";
			this.tulostaBT.Size = new System.Drawing.Size(191, 54);
			this.tulostaBT.TabIndex = 3;
			this.tulostaBT.Text = "Tulosta teksti";
			this.tulostaBT.UseVisualStyleBackColor = true;
			this.tulostaBT.Click += new System.EventHandler(this.tulostaBT_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Salmon;
			this.ClientSize = new System.Drawing.Size(1648, 740);
			this.Controls.Add(this.tulostaBT);
			this.Controls.Add(this.ViestiTB);
			this.Controls.Add(this.TulostusLB);
			this.Controls.Add(this.OtsikkoLB);
			this.ForeColor = System.Drawing.Color.MintCream;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label OtsikkoLB;
		private System.Windows.Forms.Label TulostusLB;
		private System.Windows.Forms.TextBox ViestiTB;
		private System.Windows.Forms.Button tulostaBT;
	}
}

