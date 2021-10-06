namespace BMI
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
            this.BMIBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.kuvausLB = new System.Windows.Forms.Label();
            this.bmiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BMIBT
            // 
            this.BMIBT.BackColor = System.Drawing.Color.White;
            this.BMIBT.Font = new System.Drawing.Font("Onky", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIBT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BMIBT.Location = new System.Drawing.Point(143, 268);
            this.BMIBT.Name = "BMIBT";
            this.BMIBT.Size = new System.Drawing.Size(226, 88);
            this.BMIBT.TabIndex = 0;
            this.BMIBT.Text = "Laske painoindeksi";
            this.BMIBT.UseVisualStyleBackColor = false;
            this.BMIBT.Click += new System.EventHandler(this.BMIBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anna paino:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anna pituus:";
            // 
            // painoTB
            // 
            this.painoTB.Location = new System.Drawing.Point(248, 188);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(100, 20);
            this.painoTB.TabIndex = 3;
            // 
            // pituusTB
            // 
            this.pituusTB.Location = new System.Drawing.Point(252, 231);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(100, 20);
            this.pituusTB.TabIndex = 4;
            // 
            // kuvausLB
            // 
            this.kuvausLB.AutoSize = true;
            this.kuvausLB.Location = new System.Drawing.Point(154, 395);
            this.kuvausLB.Name = "kuvausLB";
            this.kuvausLB.Size = new System.Drawing.Size(35, 13);
            this.kuvausLB.TabIndex = 5;
            this.kuvausLB.Text = "label3";
            this.kuvausLB.Visible = false;
            // 
            // bmiLB
            // 
            this.bmiLB.AutoSize = true;
            this.bmiLB.Location = new System.Drawing.Point(157, 363);
            this.bmiLB.Name = "bmiLB";
            this.bmiLB.Size = new System.Drawing.Size(35, 13);
            this.bmiLB.TabIndex = 6;
            this.bmiLB.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.bmiLB);
            this.Controls.Add(this.kuvausLB);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BMIBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BMIBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox painoTB;
        private System.Windows.Forms.TextBox pituusTB;
        private System.Windows.Forms.Label kuvausLB;
        private System.Windows.Forms.Label bmiLB;
    }
}

