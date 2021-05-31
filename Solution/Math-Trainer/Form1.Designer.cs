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
            this.SuspendLayout();
            // 
            // lb_Range
            // 
            this.lb_Range.AutoSize = true;
            this.lb_Range.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lb_Range.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Range.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Range.Location = new System.Drawing.Point(12, 9);
            this.lb_Range.Name = "lb_Range";
            this.lb_Range.Size = new System.Drawing.Size(99, 23);
            this.lb_Range.TabIndex = 0;
            this.lb_Range.Text = "Zahlenweite:";
            // 
            // txt_Range
            // 
            this.txt_Range.Location = new System.Drawing.Point(117, 9);
            this.txt_Range.Name = "txt_Range";
            this.txt_Range.Size = new System.Drawing.Size(119, 23);
            this.txt_Range.TabIndex = 1;
            // 
            // lb_Aufgabe
            // 
            this.lb_Aufgabe.AutoSize = true;
            this.lb_Aufgabe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lb_Aufgabe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Aufgabe.Location = new System.Drawing.Point(12, 61);
            this.lb_Aufgabe.Name = "lb_Aufgabe";
            this.lb_Aufgabe.Size = new System.Drawing.Size(57, 17);
            this.lb_Aufgabe.TabIndex = 2;
            this.lb_Aufgabe.Text = "Aufgabe:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

