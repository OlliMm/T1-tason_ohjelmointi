
namespace Celciustofahrenheit
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
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.AsteetTB = new System.Windows.Forms.TextBox();
            this.CelsiusRB = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Location = new System.Drawing.Point(628, 94);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(152, 114);
            this.MuunnaBT.TabIndex = 0;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            // 
            // AsteetTB
            // 
            this.AsteetTB.Location = new System.Drawing.Point(307, 136);
            this.AsteetTB.Name = "AsteetTB";
            this.AsteetTB.Size = new System.Drawing.Size(121, 31);
            this.AsteetTB.TabIndex = 1;
            this.AsteetTB.TextChanged += new System.EventHandler(this.AsteetTB_TextChanged);
            // 
            // CelsiusRB
            // 
            this.CelsiusRB.AutoSize = true;
            this.CelsiusRB.Location = new System.Drawing.Point(448, 141);
            this.CelsiusRB.Name = "CelsiusRB";
            this.CelsiusRB.Size = new System.Drawing.Size(91, 29);
            this.CelsiusRB.TabIndex = 2;
            this.CelsiusRB.TabStop = true;
            this.CelsiusRB.Text = "Celsius";
            this.CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(177, 255);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(72, 25);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Location = new System.Drawing.Point(448, 190);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(118, 29);
            this.FahrenheitRB.TabIndex = 4;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "Fahrenheit";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(448, 94);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(141, 25);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Miten muunnat?";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(177, 139);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 25);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Anna asteet:";
            this.Label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 558);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.FahrenheitRB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.CelsiusRB);
            this.Controls.Add(this.AsteetTB);
            this.Controls.Add(this.MuunnaBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MuunnaBT;
        private System.Windows.Forms.TextBox AsteetTB;
        private System.Windows.Forms.RadioButton CelsiusRB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.RadioButton FahrenheitRB;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
    }
}

