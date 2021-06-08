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
            this.lb_NrOfExercises = new System.Windows.Forms.Label();
            this.lb_NrOfExercisesRight = new System.Windows.Forms.Label();
            this.lb_NrOfExercisesWrong = new System.Windows.Forms.Label();
            this.gb_Statistics = new System.Windows.Forms.GroupBox();
            this.lb_PercentOfCorrectAnswers = new System.Windows.Forms.Label();
            this.lb_WrongInput = new System.Windows.Forms.Label();
            this.rB_Addition = new System.Windows.Forms.RadioButton();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_typeOfCalcualtion = new System.Windows.Forms.Label();
            this.lb_TypeOfCalculation = new System.Windows.Forms.Label();
            this.rB_Subtraction = new System.Windows.Forms.RadioButton();
            this.rB_Multiplikation = new System.Windows.Forms.RadioButton();
            this.lb_TryAgain = new System.Windows.Forms.Label();
            this.gB_Einstellungen = new System.Windows.Forms.GroupBox();
            this.lb_Solution = new System.Windows.Forms.Label();
            this.lb_InfoWrongAnswer = new System.Windows.Forms.Label();
            this.lb_InfoReset = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB_Division = new System.Windows.Forms.RadioButton();
            this.rB_Mixed = new System.Windows.Forms.RadioButton();
            this.gb_Statistics.SuspendLayout();
            this.gB_Einstellungen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Range
            // 
            this.lb_Range.AutoSize = true;
            this.lb_Range.BackColor = System.Drawing.SystemColors.Control;
            this.lb_Range.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Range.Location = new System.Drawing.Point(6, 19);
            this.lb_Range.Name = "lb_Range";
            this.lb_Range.Size = new System.Drawing.Size(102, 21);
            this.lb_Range.TabIndex = 0;
            this.lb_Range.Text = "Zahlenweite:";
            this.lb_Range.MouseEnter += new System.EventHandler(this.lb_Range_MouseEnter);
            this.lb_Range.MouseLeave += new System.EventHandler(this.lb_Range_MouseLeave);
            // 
            // txt_Range
            // 
            this.txt_Range.Location = new System.Drawing.Point(17, 43);
            this.txt_Range.Name = "txt_Range";
            this.txt_Range.Size = new System.Drawing.Size(91, 23);
            this.txt_Range.TabIndex = 1;
            this.txt_Range.TextChanged += new System.EventHandler(this.txt_Range_TextChanged);
            // 
            // lb_Invoice
            // 
            this.lb_Invoice.AutoSize = true;
            this.lb_Invoice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Invoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Invoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Invoice.Location = new System.Drawing.Point(6, 21);
            this.lb_Invoice.Name = "lb_Invoice";
            this.lb_Invoice.Size = new System.Drawing.Size(87, 21);
            this.lb_Invoice.TabIndex = 2;
            this.lb_Invoice.Text = "Rechnung:";
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Invoice.Location = new System.Drawing.Point(6, 45);
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.ReadOnly = true;
            this.txt_Invoice.Size = new System.Drawing.Size(169, 23);
            this.txt_Invoice.TabIndex = 3;
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Result.Location = new System.Drawing.Point(11, 71);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(77, 21);
            this.lb_Result.TabIndex = 4;
            this.lb_Result.Text = "Ergebnis:";
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Result.Location = new System.Drawing.Point(11, 112);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(169, 23);
            this.txt_Result.TabIndex = 3;
            this.txt_Result.Tag = "test";
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Check.Location = new System.Drawing.Point(28, 185);
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
            this.btn_Next.Location = new System.Drawing.Point(213, 185);
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
            this.lb_WrongRange.BackColor = System.Drawing.Color.Transparent;
            this.lb_WrongRange.Enabled = false;
            this.lb_WrongRange.ForeColor = System.Drawing.Color.Black;
            this.lb_WrongRange.Location = new System.Drawing.Point(61, 346);
            this.lb_WrongRange.Name = "lb_WrongRange";
            this.lb_WrongRange.Size = new System.Drawing.Size(223, 30);
            this.lb_WrongRange.TabIndex = 7;
            this.lb_WrongRange.Text = "Die Eingabe der Zahlenweite ist inkorekt, \r\nbitte geben sie nur eine positive Zah" +
    "l ein";
            this.lb_WrongRange.Visible = false;
            // 
            // lb_NrOfExercises
            // 
            this.lb_NrOfExercises.AutoSize = true;
            this.lb_NrOfExercises.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_NrOfExercises.Location = new System.Drawing.Point(26, 31);
            this.lb_NrOfExercises.Name = "lb_NrOfExercises";
            this.lb_NrOfExercises.Size = new System.Drawing.Size(170, 20);
            this.lb_NrOfExercises.TabIndex = 8;
            this.lb_NrOfExercises.Text = "0 Rechnungen generiert!";
            // 
            // lb_NrOfExercisesRight
            // 
            this.lb_NrOfExercisesRight.AutoSize = true;
            this.lb_NrOfExercisesRight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_NrOfExercisesRight.Location = new System.Drawing.Point(195, 129);
            this.lb_NrOfExercisesRight.Name = "lb_NrOfExercisesRight";
            this.lb_NrOfExercisesRight.Size = new System.Drawing.Size(152, 20);
            this.lb_NrOfExercisesRight.TabIndex = 9;
            this.lb_NrOfExercisesRight.Text = "0 Rechnungen richtig!";
            // 
            // lb_NrOfExercisesWrong
            // 
            this.lb_NrOfExercisesWrong.AutoSize = true;
            this.lb_NrOfExercisesWrong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_NrOfExercisesWrong.Location = new System.Drawing.Point(26, 129);
            this.lb_NrOfExercisesWrong.Name = "lb_NrOfExercisesWrong";
            this.lb_NrOfExercisesWrong.Size = new System.Drawing.Size(148, 20);
            this.lb_NrOfExercisesWrong.TabIndex = 11;
            this.lb_NrOfExercisesWrong.Text = "0 Rechnungen falsch!";
            this.lb_NrOfExercisesWrong.MouseHover += new System.EventHandler(this.lb_nrOfExercisesWrong_MouseHover);
            // 
            // gb_Statistics
            // 
            this.gb_Statistics.BackColor = System.Drawing.SystemColors.Control;
            this.gb_Statistics.Controls.Add(this.lb_InfoWrongAnswer);
            this.gb_Statistics.Controls.Add(this.lb_PercentOfCorrectAnswers);
            this.gb_Statistics.Controls.Add(this.lb_NrOfExercises);
            this.gb_Statistics.Controls.Add(this.lb_NrOfExercisesWrong);
            this.gb_Statistics.Controls.Add(this.lb_NrOfExercisesRight);
            this.gb_Statistics.Location = new System.Drawing.Point(350, 265);
            this.gb_Statistics.Name = "gb_Statistics";
            this.gb_Statistics.Size = new System.Drawing.Size(438, 173);
            this.gb_Statistics.TabIndex = 12;
            this.gb_Statistics.TabStop = false;
            this.gb_Statistics.Text = "Auswertung";
            // 
            // lb_PercentOfCorrectAnswers
            // 
            this.lb_PercentOfCorrectAnswers.AutoSize = true;
            this.lb_PercentOfCorrectAnswers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_PercentOfCorrectAnswers.Location = new System.Drawing.Point(26, 64);
            this.lb_PercentOfCorrectAnswers.Name = "lb_PercentOfCorrectAnswers";
            this.lb_PercentOfCorrectAnswers.Size = new System.Drawing.Size(225, 20);
            this.lb_PercentOfCorrectAnswers.TabIndex = 12;
            this.lb_PercentOfCorrectAnswers.Text = "Richtige Antworten in Prozent: %";
            // 
            // lb_WrongInput
            // 
            this.lb_WrongInput.AutoSize = true;
            this.lb_WrongInput.Enabled = false;
            this.lb_WrongInput.Location = new System.Drawing.Point(11, 138);
            this.lb_WrongInput.Name = "lb_WrongInput";
            this.lb_WrongInput.Size = new System.Drawing.Size(217, 15);
            this.lb_WrongInput.TabIndex = 13;
            this.lb_WrongInput.Text = "Eingabe kann nicht ausgewertet werden";
            this.lb_WrongInput.Visible = false;
            // 
            // rB_Addition
            // 
            this.rB_Addition.AutoSize = true;
            this.rB_Addition.Location = new System.Drawing.Point(17, 135);
            this.rB_Addition.Name = "rB_Addition";
            this.rB_Addition.Size = new System.Drawing.Size(73, 19);
            this.rB_Addition.TabIndex = 14;
            this.rB_Addition.TabStop = true;
            this.rB_Addition.Text = "Addieren";
            this.rB_Addition.UseVisualStyleBackColor = true;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(49, 172);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(0, 15);
            this.lb_type.TabIndex = 15;
            // 
            // lb_typeOfCalcualtion
            // 
            this.lb_typeOfCalcualtion.AutoSize = true;
            this.lb_typeOfCalcualtion.Location = new System.Drawing.Point(-218, 70);
            this.lb_typeOfCalcualtion.Name = "lb_typeOfCalcualtion";
            this.lb_typeOfCalcualtion.Size = new System.Drawing.Size(118, 15);
            this.lb_typeOfCalcualtion.TabIndex = 16;
            this.lb_typeOfCalcualtion.Text = "Wähle die Rechenart:";
            // 
            // lb_TypeOfCalculation
            // 
            this.lb_TypeOfCalculation.AutoSize = true;
            this.lb_TypeOfCalculation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TypeOfCalculation.Location = new System.Drawing.Point(6, 110);
            this.lb_TypeOfCalculation.Name = "lb_TypeOfCalculation";
            this.lb_TypeOfCalculation.Size = new System.Drawing.Size(143, 21);
            this.lb_TypeOfCalculation.TabIndex = 17;
            this.lb_TypeOfCalculation.Text = "Rechenart wählen:";
            // 
            // rB_Subtraction
            // 
            this.rB_Subtraction.AutoSize = true;
            this.rB_Subtraction.Location = new System.Drawing.Point(17, 155);
            this.rB_Subtraction.Name = "rB_Subtraction";
            this.rB_Subtraction.Size = new System.Drawing.Size(86, 19);
            this.rB_Subtraction.TabIndex = 18;
            this.rB_Subtraction.TabStop = true;
            this.rB_Subtraction.Text = "Subtraktion";
            this.rB_Subtraction.UseVisualStyleBackColor = true;
            // 
            // rB_Multiplikation
            // 
            this.rB_Multiplikation.AutoSize = true;
            this.rB_Multiplikation.Location = new System.Drawing.Point(17, 175);
            this.rB_Multiplikation.Name = "rB_Multiplikation";
            this.rB_Multiplikation.Size = new System.Drawing.Size(97, 19);
            this.rB_Multiplikation.TabIndex = 19;
            this.rB_Multiplikation.TabStop = true;
            this.rB_Multiplikation.Text = "Multiplizieren";
            this.rB_Multiplikation.UseVisualStyleBackColor = true;
            // 
            // lb_TryAgain
            // 
            this.lb_TryAgain.AutoSize = true;
            this.lb_TryAgain.Location = new System.Drawing.Point(255, 48);
            this.lb_TryAgain.Name = "lb_TryAgain";
            this.lb_TryAgain.Size = new System.Drawing.Size(106, 15);
            this.lb_TryAgain.TabIndex = 20;
            this.lb_TryAgain.Text = "Versuchs nochmal:";
            // 
            // gB_Einstellungen
            // 
            this.gB_Einstellungen.BackColor = System.Drawing.SystemColors.Control;
            this.gB_Einstellungen.Controls.Add(this.rB_Mixed);
            this.gB_Einstellungen.Controls.Add(this.rB_Division);
            this.gB_Einstellungen.Controls.Add(this.lb_InfoReset);
            this.gB_Einstellungen.Controls.Add(this.lb_Range);
            this.gB_Einstellungen.Controls.Add(this.txt_Range);
            this.gB_Einstellungen.Controls.Add(this.rB_Subtraction);
            this.gB_Einstellungen.Controls.Add(this.rB_Multiplikation);
            this.gB_Einstellungen.Controls.Add(this.rB_Addition);
            this.gB_Einstellungen.Controls.Add(this.lb_TypeOfCalculation);
            this.gB_Einstellungen.Location = new System.Drawing.Point(12, 12);
            this.gB_Einstellungen.Name = "gB_Einstellungen";
            this.gB_Einstellungen.Size = new System.Drawing.Size(323, 252);
            this.gB_Einstellungen.TabIndex = 21;
            this.gB_Einstellungen.TabStop = false;
            this.gB_Einstellungen.Text = "Einstellungen";
            // 
            // lb_Solution
            // 
            this.lb_Solution.AutoSize = true;
            this.lb_Solution.Location = new System.Drawing.Point(260, 92);
            this.lb_Solution.Name = "lb_Solution";
            this.lb_Solution.Size = new System.Drawing.Size(61, 15);
            this.lb_Solution.TabIndex = 22;
            this.lb_Solution.Text = "Ergebenis:";
            // 
            // lb_InfoWrongAnswer
            // 
            this.lb_InfoWrongAnswer.AutoSize = true;
            this.lb_InfoWrongAnswer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lb_InfoWrongAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_InfoWrongAnswer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InfoWrongAnswer.Location = new System.Drawing.Point(39, 114);
            this.lb_InfoWrongAnswer.Name = "lb_InfoWrongAnswer";
            this.lb_InfoWrongAnswer.Size = new System.Drawing.Size(231, 15);
            this.lb_InfoWrongAnswer.TabIndex = 23;
            this.lb_InfoWrongAnswer.Text = "Ab 2 Versuche gilt die Rechnung als Falsch!";
            this.lb_InfoWrongAnswer.Visible = false;
            // 
            // lb_InfoReset
            // 
            this.lb_InfoReset.AutoSize = true;
            this.lb_InfoReset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_InfoReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_InfoReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InfoReset.Location = new System.Drawing.Point(53, 0);
            this.lb_InfoReset.Name = "lb_InfoReset";
            this.lb_InfoReset.Size = new System.Drawing.Size(219, 28);
            this.lb_InfoReset.TabIndex = 23;
            this.lb_InfoReset.Text = "Sobald die Zahlenweite geändert wurde,\r\nwird die Statistik zurückgesetzt!";
            this.lb_InfoReset.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Invoice);
            this.groupBox1.Controls.Add(this.lb_Solution);
            this.groupBox1.Controls.Add(this.txt_Invoice);
            this.groupBox1.Controls.Add(this.lb_Result);
            this.groupBox1.Controls.Add(this.txt_Result);
            this.groupBox1.Controls.Add(this.lb_TryAgain);
            this.groupBox1.Controls.Add(this.btn_Check);
            this.groupBox1.Controls.Add(this.btn_Next);
            this.groupBox1.Controls.Add(this.lb_WrongInput);
            this.groupBox1.Location = new System.Drawing.Point(376, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 254);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rB_Division
            // 
            this.rB_Division.AutoSize = true;
            this.rB_Division.Location = new System.Drawing.Point(17, 195);
            this.rB_Division.Name = "rB_Division";
            this.rB_Division.Size = new System.Drawing.Size(78, 19);
            this.rB_Division.TabIndex = 24;
            this.rB_Division.TabStop = true;
            this.rB_Division.Text = "Dividieren";
            this.rB_Division.UseVisualStyleBackColor = true;
            // 
            // rB_Mixed
            // 
            this.rB_Mixed.AutoSize = true;
            this.rB_Mixed.Location = new System.Drawing.Point(17, 215);
            this.rB_Mixed.Name = "rB_Mixed";
            this.rB_Mixed.Size = new System.Drawing.Size(75, 19);
            this.rB_Mixed.TabIndex = 25;
            this.rB_Mixed.TabStop = true;
            this.rB_Mixed.Text = "Gemischt";
            this.rB_Mixed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gB_Einstellungen);
            this.Controls.Add(this.lb_WrongRange);
            this.Controls.Add(this.lb_typeOfCalcualtion);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.gb_Statistics);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mathe Trainer";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.gb_Statistics.ResumeLayout(false);
            this.gb_Statistics.PerformLayout();
            this.gB_Einstellungen.ResumeLayout(false);
            this.gB_Einstellungen.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lb_NrOfExercises;
        private System.Windows.Forms.Label lb_NrOfExercisesRight;
        private System.Windows.Forms.Label lb_NrOfExercisesWrong;
        private System.Windows.Forms.GroupBox gb_Auswertung;
        private System.Windows.Forms.Label lb_nrOfExercisesTrue;
        private System.Windows.Forms.Label lb_nrOfExercisesWrite;
        private System.Windows.Forms.GroupBox gb_Statistics;
        private System.Windows.Forms.Label lb_PercentOfCorrectAnswers;
        private System.Windows.Forms.Label lb_WrongInput;
        private System.Windows.Forms.RadioButton rB_Addition;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_typeOfCalcualtion;
        private System.Windows.Forms.Label lb_TypeOfCalculation;
        private System.Windows.Forms.RadioButton rB_Subtraction;
        private System.Windows.Forms.RadioButton rB_Multiplikation;
        private System.Windows.Forms.Label lb_TryAgain;
        private System.Windows.Forms.GroupBox gB_Einstellungen;
        private System.Windows.Forms.Label lb_Solution;
        private System.Windows.Forms.Label lb_InfoWrongAnswer;
        private System.Windows.Forms.RadioButton rB_Mixed;
        private System.Windows.Forms.RadioButton rB_Division;
        private System.Windows.Forms.Label lb_InfoReset;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

