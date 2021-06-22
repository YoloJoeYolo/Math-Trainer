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
            this.lb_WrongRange = new System.Windows.Forms.Label();
            this.lb_NrOfExercises = new System.Windows.Forms.Label();
            this.lb_NrOfExercisesRight = new System.Windows.Forms.Label();
            this.lb_NrOfExercisesWrong = new System.Windows.Forms.Label();
            this.gb_Statistics = new System.Windows.Forms.GroupBox();
            this.gb_Diagram = new System.Windows.Forms.GroupBox();
            this.txt_DiagramWrong = new System.Windows.Forms.TextBox();
            this.txt_DiagramRight = new System.Windows.Forms.TextBox();
            this.lb_PercentOfCorrectAnswers = new System.Windows.Forms.Label();
            this.lb_InfoWrongAnswer = new System.Windows.Forms.Label();
            this.rb_Addition = new System.Windows.Forms.RadioButton();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_typeOfCalcualtion = new System.Windows.Forms.Label();
            this.lb_TypeOfCalculation = new System.Windows.Forms.Label();
            this.rb_Subtraction = new System.Windows.Forms.RadioButton();
            this.rb_Multiplikation = new System.Windows.Forms.RadioButton();
            this.gb_Einstellungen = new System.Windows.Forms.GroupBox();
            this.lb_InfoTypeOfCalculation = new System.Windows.Forms.Label();
            this.rb_Mixed = new System.Windows.Forms.RadioButton();
            this.rb_Division = new System.Windows.Forms.RadioButton();
            this.lb_InfoReset = new System.Windows.Forms.Label();
            this.lb_Solution = new System.Windows.Forms.Label();
            this.lb_WrongInput = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.lb_Result = new System.Windows.Forms.Label();
            this.lb_Invoice = new System.Windows.Forms.Label();
            this.txt_Invoice = new System.Windows.Forms.TextBox();
            this.lb_TryAgain = new System.Windows.Forms.Label();
            this.gb_CalculatingForm = new System.Windows.Forms.GroupBox();
            this.lb_SolutionValue = new System.Windows.Forms.Label();
            this.lb_WriteAnswer = new System.Windows.Forms.Label();
            this.gb_Statistics.SuspendLayout();
            this.gb_Diagram.SuspendLayout();
            this.gb_Einstellungen.SuspendLayout();
            this.gb_CalculatingForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Range
            // 
            this.lb_Range.AutoSize = true;
            this.lb_Range.BackColor = System.Drawing.SystemColors.Control;
            this.lb_Range.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Range.Location = new System.Drawing.Point(6, 19);
            this.lb_Range.Name = "lb_Range";
            this.lb_Range.Size = new System.Drawing.Size(117, 21);
            this.lb_Range.TabIndex = 0;
            this.lb_Range.Text = "Zahlenbereich:";
            this.lb_Range.MouseEnter += new System.EventHandler(this.lb_Range_MouseEnter);
            this.lb_Range.MouseLeave += new System.EventHandler(this.lb_Range_MouseLeave);
            // 
            // txt_Range
            // 
            this.txt_Range.Location = new System.Drawing.Point(6, 43);
            this.txt_Range.Name = "txt_Range";
            this.txt_Range.Size = new System.Drawing.Size(150, 25);
            this.txt_Range.TabIndex = 1;
            this.txt_Range.TextChanged += new System.EventHandler(this.txt_Range_TextChanged);
            // 
            // lb_WrongRange
            // 
            this.lb_WrongRange.AutoSize = true;
            this.lb_WrongRange.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_WrongRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_WrongRange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_WrongRange.ForeColor = System.Drawing.Color.Red;
            this.lb_WrongRange.Location = new System.Drawing.Point(37, 187);
            this.lb_WrongRange.Name = "lb_WrongRange";
            this.lb_WrongRange.Size = new System.Drawing.Size(250, 36);
            this.lb_WrongRange.TabIndex = 7;
            this.lb_WrongRange.Text = "Die Eingabe der Zahlenweite ist inkorekt, \r\nbitte geben sie nur eine positive Zah" +
    "l ein";
            this.lb_WrongRange.Visible = false;
            // 
            // lb_NrOfExercises
            // 
            this.lb_NrOfExercises.AutoSize = true;
            this.lb_NrOfExercises.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_NrOfExercises.Location = new System.Drawing.Point(6, 21);
            this.lb_NrOfExercises.Name = "lb_NrOfExercises";
            this.lb_NrOfExercises.Size = new System.Drawing.Size(182, 21);
            this.lb_NrOfExercises.TabIndex = 8;
            this.lb_NrOfExercises.Text = "0 Rechnungen generiert!";
            // 
            // lb_NrOfExercisesRight
            // 
            this.lb_NrOfExercisesRight.AutoSize = true;
            this.lb_NrOfExercisesRight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_NrOfExercisesRight.Location = new System.Drawing.Point(6, 63);
            this.lb_NrOfExercisesRight.Name = "lb_NrOfExercisesRight";
            this.lb_NrOfExercisesRight.Size = new System.Drawing.Size(163, 21);
            this.lb_NrOfExercisesRight.TabIndex = 9;
            this.lb_NrOfExercisesRight.Text = "0 Rechnungen richtig!";
            // 
            // lb_NrOfExercisesWrong
            // 
            this.lb_NrOfExercisesWrong.AutoSize = true;
            this.lb_NrOfExercisesWrong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_NrOfExercisesWrong.Location = new System.Drawing.Point(175, 63);
            this.lb_NrOfExercisesWrong.Name = "lb_NrOfExercisesWrong";
            this.lb_NrOfExercisesWrong.Size = new System.Drawing.Size(159, 21);
            this.lb_NrOfExercisesWrong.TabIndex = 11;
            this.lb_NrOfExercisesWrong.Text = "0 Rechnungen falsch!";
            this.lb_NrOfExercisesWrong.MouseEnter += new System.EventHandler(this.lb_NrOfExercisesWrong_MouseEnter);
            this.lb_NrOfExercisesWrong.MouseLeave += new System.EventHandler(this.lb_NrOfExercisesWrong_MouseLeave);
            // 
            // gb_Statistics
            // 
            this.gb_Statistics.AutoSize = true;
            this.gb_Statistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_Statistics.BackColor = System.Drawing.SystemColors.Control;
            this.gb_Statistics.Controls.Add(this.gb_Diagram);
            this.gb_Statistics.Controls.Add(this.lb_PercentOfCorrectAnswers);
            this.gb_Statistics.Controls.Add(this.lb_NrOfExercises);
            this.gb_Statistics.Controls.Add(this.lb_NrOfExercisesWrong);
            this.gb_Statistics.Controls.Add(this.lb_NrOfExercisesRight);
            this.gb_Statistics.Controls.Add(this.lb_InfoWrongAnswer);
            this.gb_Statistics.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_Statistics.Location = new System.Drawing.Point(12, 280);
            this.gb_Statistics.Name = "gb_Statistics";
            this.gb_Statistics.Size = new System.Drawing.Size(760, 127);
            this.gb_Statistics.TabIndex = 12;
            this.gb_Statistics.TabStop = false;
            this.gb_Statistics.Text = "Auswertung";
            // 
            // gb_Diagram
            // 
            this.gb_Diagram.Controls.Add(this.txt_DiagramWrong);
            this.gb_Diagram.Controls.Add(this.txt_DiagramRight);
            this.gb_Diagram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_Diagram.Location = new System.Drawing.Point(337, 21);
            this.gb_Diagram.Name = "gb_Diagram";
            this.gb_Diagram.Size = new System.Drawing.Size(417, 82);
            this.gb_Diagram.TabIndex = 24;
            this.gb_Diagram.TabStop = false;
            this.gb_Diagram.Text = "Diagramm";
            // 
            // txt_DiagramWrong
            // 
            this.txt_DiagramWrong.BackColor = System.Drawing.Color.Red;
            this.txt_DiagramWrong.Enabled = false;
            this.txt_DiagramWrong.Location = new System.Drawing.Point(0, 51);
            this.txt_DiagramWrong.Name = "txt_DiagramWrong";
            this.txt_DiagramWrong.ReadOnly = true;
            this.txt_DiagramWrong.Size = new System.Drawing.Size(10, 25);
            this.txt_DiagramWrong.TabIndex = 3;
            // 
            // txt_DiagramRight
            // 
            this.txt_DiagramRight.BackColor = System.Drawing.Color.Green;
            this.txt_DiagramRight.Enabled = false;
            this.txt_DiagramRight.Location = new System.Drawing.Point(0, 26);
            this.txt_DiagramRight.Name = "txt_DiagramRight";
            this.txt_DiagramRight.ReadOnly = true;
            this.txt_DiagramRight.Size = new System.Drawing.Size(10, 25);
            this.txt_DiagramRight.TabIndex = 2;
            // 
            // lb_PercentOfCorrectAnswers
            // 
            this.lb_PercentOfCorrectAnswers.AutoSize = true;
            this.lb_PercentOfCorrectAnswers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_PercentOfCorrectAnswers.Location = new System.Drawing.Point(6, 42);
            this.lb_PercentOfCorrectAnswers.Name = "lb_PercentOfCorrectAnswers";
            this.lb_PercentOfCorrectAnswers.Size = new System.Drawing.Size(290, 21);
            this.lb_PercentOfCorrectAnswers.TabIndex = 12;
            this.lb_PercentOfCorrectAnswers.Text = "Davon prozentuell richtige Antworten: %";
            // 
            // lb_InfoWrongAnswer
            // 
            this.lb_InfoWrongAnswer.AutoSize = true;
            this.lb_InfoWrongAnswer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_InfoWrongAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_InfoWrongAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InfoWrongAnswer.Location = new System.Drawing.Point(37, 84);
            this.lb_InfoWrongAnswer.Name = "lb_InfoWrongAnswer";
            this.lb_InfoWrongAnswer.Size = new System.Drawing.Size(261, 19);
            this.lb_InfoWrongAnswer.TabIndex = 23;
            this.lb_InfoWrongAnswer.Text = "Ab 2 Versuche gilt die Rechnung als Falsch!";
            this.lb_InfoWrongAnswer.Visible = false;
            // 
            // rb_Addition
            // 
            this.rb_Addition.AutoSize = true;
            this.rb_Addition.Location = new System.Drawing.Point(9, 95);
            this.rb_Addition.Name = "rb_Addition";
            this.rb_Addition.Size = new System.Drawing.Size(79, 21);
            this.rb_Addition.TabIndex = 14;
            this.rb_Addition.Text = "Addieren";
            this.rb_Addition.UseVisualStyleBackColor = true;
            this.rb_Addition.CheckedChanged += new System.EventHandler(this.rb_Mixed_CheckedChanged);
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
            this.lb_TypeOfCalculation.Location = new System.Drawing.Point(6, 71);
            this.lb_TypeOfCalculation.Name = "lb_TypeOfCalculation";
            this.lb_TypeOfCalculation.Size = new System.Drawing.Size(143, 21);
            this.lb_TypeOfCalculation.TabIndex = 17;
            this.lb_TypeOfCalculation.Text = "Rechenart wählen:";
            this.lb_TypeOfCalculation.MouseEnter += new System.EventHandler(this.lb_TypeOfCalculation_MouseEnter);
            this.lb_TypeOfCalculation.MouseLeave += new System.EventHandler(this.lb_TypeOfCalculation_MouseLeave);
            // 
            // rb_Subtraction
            // 
            this.rb_Subtraction.AutoSize = true;
            this.rb_Subtraction.Location = new System.Drawing.Point(9, 112);
            this.rb_Subtraction.Name = "rb_Subtraction";
            this.rb_Subtraction.Size = new System.Drawing.Size(92, 21);
            this.rb_Subtraction.TabIndex = 18;
            this.rb_Subtraction.Text = "Subtraktion";
            this.rb_Subtraction.UseVisualStyleBackColor = true;
            this.rb_Subtraction.CheckedChanged += new System.EventHandler(this.rb_Mixed_CheckedChanged);
            // 
            // rb_Multiplikation
            // 
            this.rb_Multiplikation.AutoSize = true;
            this.rb_Multiplikation.Location = new System.Drawing.Point(9, 129);
            this.rb_Multiplikation.Name = "rb_Multiplikation";
            this.rb_Multiplikation.Size = new System.Drawing.Size(104, 21);
            this.rb_Multiplikation.TabIndex = 19;
            this.rb_Multiplikation.Text = "Multiplizieren";
            this.rb_Multiplikation.UseVisualStyleBackColor = true;
            this.rb_Multiplikation.CheckedChanged += new System.EventHandler(this.rb_Mixed_CheckedChanged);
            // 
            // gb_Einstellungen
            // 
            this.gb_Einstellungen.BackColor = System.Drawing.SystemColors.Control;
            this.gb_Einstellungen.Controls.Add(this.lb_InfoTypeOfCalculation);
            this.gb_Einstellungen.Controls.Add(this.rb_Mixed);
            this.gb_Einstellungen.Controls.Add(this.lb_WrongRange);
            this.gb_Einstellungen.Controls.Add(this.rb_Division);
            this.gb_Einstellungen.Controls.Add(this.lb_InfoReset);
            this.gb_Einstellungen.Controls.Add(this.lb_Range);
            this.gb_Einstellungen.Controls.Add(this.txt_Range);
            this.gb_Einstellungen.Controls.Add(this.rb_Subtraction);
            this.gb_Einstellungen.Controls.Add(this.rb_Multiplikation);
            this.gb_Einstellungen.Controls.Add(this.rb_Addition);
            this.gb_Einstellungen.Controls.Add(this.lb_TypeOfCalculation);
            this.gb_Einstellungen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_Einstellungen.Location = new System.Drawing.Point(12, 12);
            this.gb_Einstellungen.Name = "gb_Einstellungen";
            this.gb_Einstellungen.Size = new System.Drawing.Size(329, 262);
            this.gb_Einstellungen.TabIndex = 21;
            this.gb_Einstellungen.TabStop = false;
            this.gb_Einstellungen.Text = "Einstellungen";
            // 
            // lb_InfoTypeOfCalculation
            // 
            this.lb_InfoTypeOfCalculation.AutoSize = true;
            this.lb_InfoTypeOfCalculation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_InfoTypeOfCalculation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_InfoTypeOfCalculation.Location = new System.Drawing.Point(144, 71);
            this.lb_InfoTypeOfCalculation.Name = "lb_InfoTypeOfCalculation";
            this.lb_InfoTypeOfCalculation.Size = new System.Drawing.Size(179, 36);
            this.lb_InfoTypeOfCalculation.TabIndex = 26;
            this.lb_InfoTypeOfCalculation.Text = "Die Rechenart wird bei der \r\nnächsten Rechnung geändert";
            this.lb_InfoTypeOfCalculation.Visible = false;
            // 
            // rb_Mixed
            // 
            this.rb_Mixed.AutoSize = true;
            this.rb_Mixed.Checked = true;
            this.rb_Mixed.Location = new System.Drawing.Point(9, 163);
            this.rb_Mixed.Name = "rb_Mixed";
            this.rb_Mixed.Size = new System.Drawing.Size(79, 21);
            this.rb_Mixed.TabIndex = 25;
            this.rb_Mixed.TabStop = true;
            this.rb_Mixed.Text = "Gemischt";
            this.rb_Mixed.UseVisualStyleBackColor = true;
            this.rb_Mixed.CheckedChanged += new System.EventHandler(this.rb_Mixed_CheckedChanged);
            // 
            // rb_Division
            // 
            this.rb_Division.AutoSize = true;
            this.rb_Division.Location = new System.Drawing.Point(9, 146);
            this.rb_Division.Name = "rb_Division";
            this.rb_Division.Size = new System.Drawing.Size(84, 21);
            this.rb_Division.TabIndex = 24;
            this.rb_Division.Text = "Dividieren";
            this.rb_Division.UseVisualStyleBackColor = true;
            this.rb_Division.CheckedChanged += new System.EventHandler(this.rb_Mixed_CheckedChanged);
            // 
            // lb_InfoReset
            // 
            this.lb_InfoReset.AutoSize = true;
            this.lb_InfoReset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_InfoReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_InfoReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InfoReset.Location = new System.Drawing.Point(83, 4);
            this.lb_InfoReset.Name = "lb_InfoReset";
            this.lb_InfoReset.Size = new System.Drawing.Size(234, 36);
            this.lb_InfoReset.TabIndex = 23;
            this.lb_InfoReset.Text = "Sobald die Zahlenweite geändert wird,\r\nwird die Statistik zurückgesetzt!";
            this.lb_InfoReset.Visible = false;
            // 
            // lb_Solution
            // 
            this.lb_Solution.AutoSize = true;
            this.lb_Solution.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Solution.Location = new System.Drawing.Point(241, 21);
            this.lb_Solution.Name = "lb_Solution";
            this.lb_Solution.Size = new System.Drawing.Size(81, 21);
            this.lb_Solution.TabIndex = 22;
            this.lb_Solution.Text = "Ergebenis:";
            // 
            // lb_WrongInput
            // 
            this.lb_WrongInput.AutoSize = true;
            this.lb_WrongInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_WrongInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_WrongInput.ForeColor = System.Drawing.Color.Red;
            this.lb_WrongInput.Location = new System.Drawing.Point(13, 123);
            this.lb_WrongInput.Name = "lb_WrongInput";
            this.lb_WrongInput.Size = new System.Drawing.Size(241, 19);
            this.lb_WrongInput.TabIndex = 13;
            this.lb_WrongInput.Text = "Eingabe kann nicht ausgewertet werden";
            this.lb_WrongInput.Visible = false;
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Next.Enabled = false;
            this.btn_Next.Location = new System.Drawing.Point(127, 152);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(108, 43);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "Nächste\r\nAufgabe";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Check.Enabled = false;
            this.btn_Check.Location = new System.Drawing.Point(13, 152);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(108, 43);
            this.btn_Check.TabIndex = 5;
            this.btn_Check.Text = "Ergennis\r\nPrüfen";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Result.Enabled = false;
            this.txt_Result.Location = new System.Drawing.Point(13, 95);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.Size = new System.Drawing.Size(175, 25);
            this.txt_Result.TabIndex = 3;
            this.txt_Result.Tag = "test";
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
            // lb_Invoice
            // 
            this.lb_Invoice.AutoSize = true;
            this.lb_Invoice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Invoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Invoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Invoice.Location = new System.Drawing.Point(6, 19);
            this.lb_Invoice.Name = "lb_Invoice";
            this.lb_Invoice.Size = new System.Drawing.Size(87, 21);
            this.lb_Invoice.TabIndex = 2;
            this.lb_Invoice.Text = "Rechnung:";
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Invoice.Enabled = false;
            this.txt_Invoice.Location = new System.Drawing.Point(11, 38);
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.ReadOnly = true;
            this.txt_Invoice.Size = new System.Drawing.Size(175, 25);
            this.txt_Invoice.TabIndex = 24;
            // 
            // lb_TryAgain
            // 
            this.lb_TryAgain.AutoSize = true;
            this.lb_TryAgain.BackColor = System.Drawing.Color.Transparent;
            this.lb_TryAgain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_TryAgain.ForeColor = System.Drawing.Color.Red;
            this.lb_TryAgain.Location = new System.Drawing.Point(241, 43);
            this.lb_TryAgain.Name = "lb_TryAgain";
            this.lb_TryAgain.Size = new System.Drawing.Size(141, 42);
            this.lb_TryAgain.TabIndex = 20;
            this.lb_TryAgain.Text = "Falsch:\r\nVersuchs nochmal!";
            this.lb_TryAgain.Visible = false;
            // 
            // gb_CalculatingForm
            // 
            this.gb_CalculatingForm.Controls.Add(this.lb_SolutionValue);
            this.gb_CalculatingForm.Controls.Add(this.lb_WriteAnswer);
            this.gb_CalculatingForm.Controls.Add(this.lb_TryAgain);
            this.gb_CalculatingForm.Controls.Add(this.txt_Invoice);
            this.gb_CalculatingForm.Controls.Add(this.lb_Invoice);
            this.gb_CalculatingForm.Controls.Add(this.lb_Result);
            this.gb_CalculatingForm.Controls.Add(this.txt_Result);
            this.gb_CalculatingForm.Controls.Add(this.btn_Check);
            this.gb_CalculatingForm.Controls.Add(this.btn_Next);
            this.gb_CalculatingForm.Controls.Add(this.lb_WrongInput);
            this.gb_CalculatingForm.Controls.Add(this.lb_Solution);
            this.gb_CalculatingForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_CalculatingForm.Location = new System.Drawing.Point(349, 16);
            this.gb_CalculatingForm.Name = "gb_CalculatingForm";
            this.gb_CalculatingForm.Size = new System.Drawing.Size(423, 258);
            this.gb_CalculatingForm.TabIndex = 0;
            this.gb_CalculatingForm.TabStop = false;
            this.gb_CalculatingForm.Text = "Rechnung";
            // 
            // lb_SolutionValue
            // 
            this.lb_SolutionValue.AutoSize = true;
            this.lb_SolutionValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_SolutionValue.Location = new System.Drawing.Point(241, 47);
            this.lb_SolutionValue.Name = "lb_SolutionValue";
            this.lb_SolutionValue.Size = new System.Drawing.Size(128, 21);
            this.lb_SolutionValue.TabIndex = 25;
            this.lb_SolutionValue.Text = "<SolutionValue>";
            this.lb_SolutionValue.Visible = false;
            // 
            // lb_WriteAnswer
            // 
            this.lb_WriteAnswer.AutoSize = true;
            this.lb_WriteAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lb_WriteAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_WriteAnswer.ForeColor = System.Drawing.Color.Green;
            this.lb_WriteAnswer.Location = new System.Drawing.Point(241, 42);
            this.lb_WriteAnswer.Name = "lb_WriteAnswer";
            this.lb_WriteAnswer.Size = new System.Drawing.Size(84, 42);
            this.lb_WriteAnswer.TabIndex = 23;
            this.lb_WriteAnswer.Text = "Richtig:\r\nGratuliere!";
            this.lb_WriteAnswer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.gb_Einstellungen);
            this.Controls.Add(this.lb_typeOfCalcualtion);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.gb_Statistics);
            this.Controls.Add(this.gb_CalculatingForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mathe Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_Statistics.ResumeLayout(false);
            this.gb_Statistics.PerformLayout();
            this.gb_Diagram.ResumeLayout(false);
            this.gb_Diagram.PerformLayout();
            this.gb_Einstellungen.ResumeLayout(false);
            this.gb_Einstellungen.PerformLayout();
            this.gb_CalculatingForm.ResumeLayout(false);
            this.gb_CalculatingForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Range;
        private System.Windows.Forms.TextBox txt_Range;
        private System.Windows.Forms.Label lb_WrongRange;
        private System.Windows.Forms.Label lb_NrOfExercises;
        private System.Windows.Forms.Label lb_NrOfExercisesRight;
        private System.Windows.Forms.Label lb_NrOfExercisesWrong;
        private System.Windows.Forms.GroupBox gb_Statistics;
        private System.Windows.Forms.Label lb_PercentOfCorrectAnswers;
        private System.Windows.Forms.RadioButton rb_Addition;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_typeOfCalcualtion;
        private System.Windows.Forms.Label lb_TypeOfCalculation;
        private System.Windows.Forms.RadioButton rb_Subtraction;
        private System.Windows.Forms.RadioButton rb_Multiplikation;
        private System.Windows.Forms.GroupBox gb_Einstellungen;
        private System.Windows.Forms.Label lb_InfoWrongAnswer;
        private System.Windows.Forms.RadioButton rb_Mixed;
        private System.Windows.Forms.RadioButton rb_Division;
        private System.Windows.Forms.Label lb_InfoReset;
        private System.Windows.Forms.Label lb_Solution;
        private System.Windows.Forms.Label lb_WrongInput;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.Label lb_Invoice;
        private System.Windows.Forms.TextBox txt_Invoice;
        private System.Windows.Forms.Label lb_TryAgain;
        private System.Windows.Forms.GroupBox gb_CalculatingForm;
        private System.Windows.Forms.Label lb_WriteAnswer;
        private System.Windows.Forms.Label lb_SolutionValue;
        private System.Windows.Forms.Label lb_InfoTypeOfCalculation;
        private System.Windows.Forms.GroupBox gb_Diagram;
        private System.Windows.Forms.TextBox txt_DiagramWrong;
        private System.Windows.Forms.TextBox txt_DiagramRight;
    }
}

