namespace Math_Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_Range = new System.Windows.Forms.Label();
            this.txt_Range = new System.Windows.Forms.TextBox();
            this.lb_Aufgabe = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_Ergebnis = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Range
            // 
            this.lb_Range.AutoSize = true;
            this.lb_Range.BackColor = System.Drawing.SystemColors.Control;
            this.lb_Range.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Range.Location = new System.Drawing.Point(12, 11);
            this.lb_Range.Name = "lb_Range";
            this.lb_Range.Size = new System.Drawing.Size(97, 21);
            this.lb_Range.TabIndex = 0;
            this.lb_Range.Text = "Zahlenweite:";
            // 
            // txt_Range
            // 
            this.txt_Range.Location = new System.Drawing.Point(64, 35);
            this.txt_Range.Name = "txt_Range";
            this.txt_Range.Size = new System.Drawing.Size(45, 23);
            this.txt_Range.TabIndex = 1;
            // 
            // lb_Aufgabe
            // 
            this.lb_Aufgabe.AutoSize = true;
            this.lb_Aufgabe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Aufgabe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Aufgabe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Aufgabe.Location = new System.Drawing.Point(192, 9);
            this.lb_Aufgabe.Name = "lb_Aufgabe";
            this.lb_Aufgabe.Size = new System.Drawing.Size(87, 21);
            this.lb_Aufgabe.TabIndex = 2;
            this.lb_Aufgabe.Text = "Rechnung:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(192, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 3;
            // 
            // lb_Ergebnis
            // 
            this.lb_Ergebnis.AutoSize = true;
            this.lb_Ergebnis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Ergebnis.Location = new System.Drawing.Point(192, 77);
            this.lb_Ergebnis.Name = "lb_Ergebnis";
            this.lb_Ergebnis.Size = new System.Drawing.Size(77, 21);
            this.lb_Ergebnis.TabIndex = 4;
            this.lb_Ergebnis.Text = "Ergebnis:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Location = new System.Drawing.Point(192, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(169, 23);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lb_Ergebnis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_Aufgabe);
            this.Controls.Add(this.txt_Range);
            this.Controls.Add(this.lb_Range);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mathe Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Range;
        private System.Windows.Forms.TextBox txt_Range;
        private System.Windows.Forms.Label lb_Aufgabe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_Ergebnis;
        private System.Windows.Forms.TextBox textBox2;
    }
}

