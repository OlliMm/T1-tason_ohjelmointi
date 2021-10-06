
namespace ikä
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
			this.SyntymaAikaDT = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.vuosinaLB = new System.Windows.Forms.Label();
			this.SekunteinaLB = new System.Windows.Forms.Label();
			this.MinuutteinaLB = new System.Windows.Forms.Label();
			this.päivinäLB = new System.Windows.Forms.Label();
			this.viikkoinaLB = new System.Windows.Forms.Label();
			this.kuukausinaLB = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SyntymaAikaDT
			// 
			this.SyntymaAikaDT.Location = new System.Drawing.Point(514, 225);
			this.SyntymaAikaDT.Name = "SyntymaAikaDT";
			this.SyntymaAikaDT.Size = new System.Drawing.Size(300, 31);
			this.SyntymaAikaDT.TabIndex = 0;
			this.SyntymaAikaDT.ValueChanged += new System.EventHandler(this.SyntymaAikaDT_ValueChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(875, 221);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 34);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// vuosinaLB
			// 
			this.vuosinaLB.AutoSize = true;
			this.vuosinaLB.Location = new System.Drawing.Point(514, 273);
			this.vuosinaLB.Name = "vuosinaLB";
			this.vuosinaLB.Size = new System.Drawing.Size(59, 25);
			this.vuosinaLB.TabIndex = 2;
			this.vuosinaLB.Text = "label1";
			// 
			// SekunteinaLB
			// 
			this.SekunteinaLB.AutoSize = true;
			this.SekunteinaLB.Location = new System.Drawing.Point(661, 379);
			this.SekunteinaLB.Name = "SekunteinaLB";
			this.SekunteinaLB.Size = new System.Drawing.Size(59, 25);
			this.SekunteinaLB.TabIndex = 3;
			this.SekunteinaLB.Text = "label2";
			// 
			// MinuutteinaLB
			// 
			this.MinuutteinaLB.AutoSize = true;
			this.MinuutteinaLB.Location = new System.Drawing.Point(661, 322);
			this.MinuutteinaLB.Name = "MinuutteinaLB";
			this.MinuutteinaLB.Size = new System.Drawing.Size(59, 25);
			this.MinuutteinaLB.TabIndex = 4;
			this.MinuutteinaLB.Text = "label3";
			// 
			// päivinäLB
			// 
			this.päivinäLB.AutoSize = true;
			this.päivinäLB.Location = new System.Drawing.Point(661, 273);
			this.päivinäLB.Name = "päivinäLB";
			this.päivinäLB.Size = new System.Drawing.Size(59, 25);
			this.päivinäLB.TabIndex = 5;
			this.päivinäLB.Text = "label4";
			// 
			// viikkoinaLB
			// 
			this.viikkoinaLB.AutoSize = true;
			this.viikkoinaLB.Location = new System.Drawing.Point(514, 379);
			this.viikkoinaLB.Name = "viikkoinaLB";
			this.viikkoinaLB.Size = new System.Drawing.Size(59, 25);
			this.viikkoinaLB.TabIndex = 6;
			this.viikkoinaLB.Text = "label5";
			// 
			// kuukausinaLB
			// 
			this.kuukausinaLB.AutoSize = true;
			this.kuukausinaLB.Location = new System.Drawing.Point(514, 322);
			this.kuukausinaLB.Name = "kuukausinaLB";
			this.kuukausinaLB.Size = new System.Drawing.Size(59, 25);
			this.kuukausinaLB.TabIndex = 7;
			this.kuukausinaLB.Text = "label6";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1601, 766);
			this.Controls.Add(this.kuukausinaLB);
			this.Controls.Add(this.viikkoinaLB);
			this.Controls.Add(this.päivinäLB);
			this.Controls.Add(this.MinuutteinaLB);
			this.Controls.Add(this.SekunteinaLB);
			this.Controls.Add(this.vuosinaLB);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.SyntymaAikaDT);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker SyntymaAikaDT;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label vuosinaLB;
		private System.Windows.Forms.Label SekunteinaLB;
		private System.Windows.Forms.Label MinuutteinaLB;
		private System.Windows.Forms.Label päivinäLB;
		private System.Windows.Forms.Label viikkoinaLB;
		private System.Windows.Forms.Label kuukausinaLB;
	}
}

