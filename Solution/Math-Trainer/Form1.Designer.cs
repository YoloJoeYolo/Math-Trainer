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
            this.lb_Invoice = new System.Windows.Forms.Label();
            this.txt_Invoice = new System.Windows.Forms.TextBox();
            this.lb_Result = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lb_WrongRange = new System.Windows.Forms.Label();
            this.lb_Anzahl = new System.Windows.Forms.Label();
            this.lb_AnzahlRichtig = new System.Windows.Forms.Label();
            this.lb_AnzahlFalsch = new System.Windows.Forms.Label();
            this.gB_Auswertung = new System.Windows.Forms.GroupBox();
            this.gB_Auswertung.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Range
            // 
            this.lb_Range.AutoSize = true;
            this.lb_Range.BackColor = System.Drawing.SystemColors.Control;
            this.lb_Range.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Range.Location = new System.Drawing.Point(12, 11);
            this.lb_Range.Name = "lb_Range";
            this.lb_Range.Size = new System.Drawing.Size(102, 21);
            this.lb_Range.TabIndex = 0;
            this.lb_Range.Text = "Zahlenweite:";
            // 
            // txt_Range
            // 
            this.txt_Range.Location = new System.Drawing.Point(58, 35);
            this.txt_Range.Name = "txt_Range";
            this.txt_Range.Size = new System.Drawing.Size(45, 23);
            this.txt_Range.TabIndex = 1;
            this.txt_Range.TextChanged += new System.EventHandler(this.txt_Range_TextChanged);
            // 
            // lb_Invoice
            // 
            this.lb_Invoice.AutoSize = true;
            this.lb_Invoice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Invoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Invoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Invoice.Location = new System.Drawing.Point(192, 9);
            this.lb_Invoice.Name = "lb_Invoice";
            this.lb_Invoice.Size = new System.Drawing.Size(87, 21);
            this.lb_Invoice.TabIndex = 2;
            this.lb_Invoice.Text = "Rechnung:";
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Invoice.Location = new System.Drawing.Point(192, 35);
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.ReadOnly = true;
            this.txt_Invoice.Size = new System.Drawing.Size(169, 23);
            this.txt_Invoice.TabIndex = 3;
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Result.Location = new System.Drawing.Point(192, 77);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(77, 21);
            this.lb_Result.TabIndex = 4;
            this.lb_Result.Text = "Ergebnis:";
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Result.Location = new System.Drawing.Point(192, 101);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(169, 23);
            this.txt_Result.TabIndex = 3;
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(161, 149);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(108, 43);
            this.btn_Check.TabIndex = 5;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(275, 149);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(108, 43);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lb_WrongRange
            // 
            this.lb_WrongRange.AutoSize = true;
            this.lb_WrongRange.Enabled = false;
            this.lb_WrongRange.Location = new System.Drawing.Point(160, 209);
            this.lb_WrongRange.Name = "lb_WrongRange";
            this.lb_WrongRange.Size = new System.Drawing.Size(223, 30);
            this.lb_WrongRange.TabIndex = 7;
            this.lb_WrongRange.Text = "Die Eingabe der Zahlenweite ist inkorekt, \r\nbitte geben sie nur eine positive Zah" +
    "l ein";
            // 
            // lb_Anzahl
            // 
            this.lb_Anzahl.AutoSize = true;
            this.lb_Anzahl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Anzahl.Location = new System.Drawing.Point(38, 52);
            this.lb_Anzahl.Name = "lb_Anzahl";
            this.lb_Anzahl.Size = new System.Drawing.Size(151, 20);
            this.lb_Anzahl.TabIndex = 8;
            this.lb_Anzahl.Text = "0 Rechnungen gelöst!";
            // 
            // lb_AnzahlRichtig
            // 
            this.lb_AnzahlRichtig.AutoSize = true;
            this.lb_AnzahlRichtig.Location = new System.Drawing.Point(154, 129);
            this.lb_AnzahlRichtig.Name = "lb_AnzahlRichtig";
            this.lb_AnzahlRichtig.Size = new System.Drawing.Size(126, 15);
            this.lb_AnzahlRichtig.TabIndex = 9;
            this.lb_AnzahlRichtig.Text = "0 Rechnungen Richtig!";
            // 
            // lb_AnzahlFalsch
            // 
            this.lb_AnzahlFalsch.AutoSize = true;
            this.lb_AnzahlFalsch.Location = new System.Drawing.Point(6, 129);
            this.lb_AnzahlFalsch.Name = "lb_AnzahlFalsch";
            this.lb_AnzahlFalsch.Size = new System.Drawing.Size(122, 15);
            this.lb_AnzahlFalsch.TabIndex = 11;
            this.lb_AnzahlFalsch.Text = "0 Rechnungen Falsch!";
            // 
            // gB_Auswertung
            // 
            this.gB_Auswertung.Controls.Add(this.lb_Anzahl);
            this.gB_Auswertung.Controls.Add(this.lb_AnzahlFalsch);
            this.gB_Auswertung.Controls.Add(this.lb_AnzahlRichtig);
            this.gB_Auswertung.Location = new System.Drawing.Point(52, 252);
            this.gB_Auswertung.Name = "gB_Auswertung";
            this.gB_Auswertung.Size = new System.Drawing.Size(309, 173);
            this.gB_Auswertung.TabIndex = 12;
            this.gB_Auswertung.TabStop = false;
            this.gB_Auswertung.Text = "Auswertung";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gB_Auswertung);
            this.Controls.Add(this.lb_WrongRange);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.txt_Invoice);
            this.Controls.Add(this.lb_Invoice);
            this.Controls.Add(this.txt_Range);
            this.Controls.Add(this.lb_Range);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mathe Trainer";
            this.gB_Auswertung.ResumeLayout(false);
            this.gB_Auswertung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Range;
        private System.Windows.Forms.TextBox txt_Range;
        private System.Windows.Forms.Label lb_Invoice;
        private System.Windows.Forms.TextBox txt_Invoice;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lb_WrongRange;
        private System.Windows.Forms.Label lb_Anzahl;
        private System.Windows.Forms.Label lb_AnzahlRichtig;
        private System.Windows.Forms.Label lb_AnzahlFalsch;
        private System.Windows.Forms.GroupBox gB_Auswertung;
    }
}

