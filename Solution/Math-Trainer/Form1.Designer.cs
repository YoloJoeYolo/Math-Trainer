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
            this.lb_nrOfExercises = new System.Windows.Forms.Label();
            this.lb_nrOfExercisesRight = new System.Windows.Forms.Label();
            this.lb_nrOfExercisesWrong = new System.Windows.Forms.Label();
            this.gb_statistics = new System.Windows.Forms.GroupBox();
            this.lb_PercentOfCorrectAnswers = new System.Windows.Forms.Label();
            this.lb_WrongInput = new System.Windows.Forms.Label();
            this.gb_statistics.SuspendLayout();
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
            this.lb_Range.MouseEnter += new System.EventHandler(this.lb_Range_MouseEnter);
            this.lb_Range.MouseLeave += new System.EventHandler(this.lb_Range_MouseLeave);
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
            this.btn_Check.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Check.Location = new System.Drawing.Point(161, 149);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(108, 43);
            this.btn_Check.TabIndex = 5;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Next.Location = new System.Drawing.Point(275, 149);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(108, 43);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lb_WrongRange
            // 
            this.lb_WrongRange.AutoSize = true;
            this.lb_WrongRange.Location = new System.Drawing.Point(12, 61);
            this.lb_WrongRange.Name = "lb_WrongRange";
            this.lb_WrongRange.Size = new System.Drawing.Size(223, 30);
            this.lb_WrongRange.TabIndex = 7;
            this.lb_WrongRange.Text = "Die Eingabe der Zahlenweite ist inkorekt, \r\nbitte geben sie nur eine positive Zah" +
    "l ein";
            this.lb_WrongRange.Visible = false;
            // 
            // lb_nrOfExercises
            // 
            this.lb_nrOfExercises.AutoSize = true;
            this.lb_nrOfExercises.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nrOfExercises.Location = new System.Drawing.Point(38, 52);
            this.lb_nrOfExercises.Name = "lb_nrOfExercises";
            this.lb_nrOfExercises.Size = new System.Drawing.Size(170, 20);
            this.lb_nrOfExercises.TabIndex = 8;
            this.lb_nrOfExercises.Text = "0 Rechnungen generiert!";
            // 
            // lb_nrOfExercisesRight
            // 
            this.lb_nrOfExercisesRight.AutoSize = true;
            this.lb_nrOfExercisesRight.Location = new System.Drawing.Point(154, 129);
            this.lb_nrOfExercisesRight.Name = "lb_nrOfExercisesRight";
            this.lb_nrOfExercisesRight.Size = new System.Drawing.Size(123, 15);
            this.lb_nrOfExercisesRight.TabIndex = 9;
            this.lb_nrOfExercisesRight.Text = "0 Rechnungen richtig!";
            // 
            // lb_nrOfExercisesWrong
            // 
            this.lb_nrOfExercisesWrong.AutoSize = true;
            this.lb_nrOfExercisesWrong.Location = new System.Drawing.Point(6, 129);
            this.lb_nrOfExercisesWrong.Name = "lb_nrOfExercisesWrong";
            this.lb_nrOfExercisesWrong.Size = new System.Drawing.Size(120, 15);
            this.lb_nrOfExercisesWrong.TabIndex = 11;
            this.lb_nrOfExercisesWrong.Text = "0 Rechnungen falsch!";
            this.lb_nrOfExercisesWrong.MouseEnter += new System.EventHandler(this.lb_nrOfExercisesWrong_MouseEnter);
            this.lb_nrOfExercisesWrong.MouseLeave += new System.EventHandler(this.lb_nrOfExercisesWrong_MouseLeave);
            // 
            // gb_statistics
            // 
            this.gb_statistics.Controls.Add(this.lb_PercentOfCorrectAnswers);
            this.gb_statistics.Controls.Add(this.lb_nrOfExercises);
            this.gb_statistics.Controls.Add(this.lb_nrOfExercisesWrong);
            this.gb_statistics.Controls.Add(this.lb_nrOfExercisesRight);
            this.gb_statistics.Location = new System.Drawing.Point(52, 252);
            this.gb_statistics.Name = "gb_statistics";
            this.gb_statistics.Size = new System.Drawing.Size(438, 173);
            this.gb_statistics.TabIndex = 12;
            this.gb_statistics.TabStop = false;
            this.gb_statistics.Text = "Auswertung";
            // 
            // lb_PercentOfCorrectAnswers
            // 
            this.lb_PercentOfCorrectAnswers.AutoSize = true;
            this.lb_PercentOfCorrectAnswers.Location = new System.Drawing.Point(259, 57);
            this.lb_PercentOfCorrectAnswers.Name = "lb_PercentOfCorrectAnswers";
            this.lb_PercentOfCorrectAnswers.Size = new System.Drawing.Size(177, 15);
            this.lb_PercentOfCorrectAnswers.TabIndex = 12;
            this.lb_PercentOfCorrectAnswers.Text = "Richtige Anworten in Prozent: %";
            // 
            // lb_WrongInput
            // 
            this.lb_WrongInput.AutoSize = true;
            this.lb_WrongInput.Location = new System.Drawing.Point(367, 101);
            this.lb_WrongInput.Name = "lb_WrongInput";
            this.lb_WrongInput.Size = new System.Drawing.Size(217, 15);
            this.lb_WrongInput.TabIndex = 13;
            this.lb_WrongInput.Text = "Eingabe kann nicht ausgewertet werden";
            this.lb_WrongInput.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_WrongInput);
            this.Controls.Add(this.gb_statistics);
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
            this.gb_statistics.ResumeLayout(false);
            this.gb_statistics.PerformLayout();
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
        private System.Windows.Forms.Label lb_nrOfExercises;
        private System.Windows.Forms.Label lb_nrOfExercisesRight;
        private System.Windows.Forms.Label lb_nrOfExercisesWrong;
        private System.Windows.Forms.GroupBox gb_Auswertung;
        private System.Windows.Forms.Label lb_nrOfExercisesTrue;
        private System.Windows.Forms.Label lb_nrOfExercisesWrite;
        private System.Windows.Forms.GroupBox gb_statistics;
        private System.Windows.Forms.Label lb_PercentOfCorrectAnswers;
        private System.Windows.Forms.Label lb_WrongInput;
    }
}

