using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// V2
namespace Math_Trainer
{
    public partial class Form1 : Form
    {
        // Datenkomponenten
        private int range = 0;
        private int nrOfExercises = 0;
        private int typOfExercise = 4;  // 0 = addition, 1 = subtraction, 2 = multiplication, 3 = division, 4 = mixed
        private int nrOfExercisesWrong = 0;
        private int nrOfExercisesRight = 0;
        private int nrOfTrys = 1;
        private MatheTrainer currentTask;
        private MatheTrainerFactory mtf = new MatheTrainerFactory();    // Über dieses Objekt werden die Aufgabe erstellt

        public Form1()
        {
            InitializeComponent();
        }

        // Funktion welche den Zahlenbereich ändert
        private void txt_Range_TextChanged(object sender, EventArgs e)
        {
            try     // Sicherung damit das Programm bei falschen Eingaben nicht crashed
            {
                this.range = int.Parse(this.txt_Range.Text);
                if (this.range <= 0)                           // hier wird geprüft ob die Zahl größer oder gleich 0 ist, wenn nicht wird die GUI inaktiv geschalten
                {
                    this.lb_WrongRange.Visible = true;
                    resetToDefault();
                }
                else    // hier wird die GUI aktiviert geschalten
                {
                    this.txt_Invoice.Enabled = true;
                    this.txt_Invoice.BackColor = SystemColors.Control;
                    this.lb_WrongRange.Visible = false;
                    this.txt_Result.Enabled = true;
                    this.txt_Result.ReadOnly = false;
                    this.txt_Result.BackColor = SystemColors.Control;
                    this.btn_Next.Enabled = true;
                    this.btn_Next.BackColor = SystemColors.Control;
                }
            }
            catch (Exception)
            {
                this.lb_WrongRange.Visible = true;
                resetToDefault();
            }
        }

        // Funktion welche die GUI inaktiv schaltet
        public void resetToDefault()
        {
            this.range = 0;
            this.nrOfExercises = 0;
            this.nrOfExercisesRight = 0;
            this.nrOfExercisesWrong = 0;
            this.txt_Invoice.Enabled = false;
            this.txt_Invoice.BackColor = SystemColors.ControlDark;
            this.txt_Result.Enabled = false;
            this.txt_Result.ReadOnly = true;
            this.txt_Result.BackColor = SystemColors.ControlDark;
            this.btn_Check.Enabled = false;
            this.btn_Check.BackColor = SystemColors.ControlDark;
            this.btn_Next.Enabled = false;
            this.btn_Next.BackColor = SystemColors.ControlDark;
            UpdateGUI();
        }

        // Funktion welche die Antwort prüft
        private void btn_Check_Click(object sender, EventArgs e)
        {
            try     // Sicherung damit das Programm bei falschen Eingaben nicht crashed
            {
                int result = int.Parse(this.txt_Result.Text);
                this.lb_WrongInput.Enabled = false;
                this.lb_SolutionValue.Visible = false;
                this.lb_TryAgain.Visible = false;
                if (this.currentTask.getResult() == result)     // richtig geantwortet
                {
                    if (this.nrOfTrys <= 2)     // wenn man weniger als zwei Versuche gebraucht hat, hat man die Rechnung richtig gelöst
                    {
                        this.nrOfExercisesRight++;
                    }
                    else
                    {
                        this.nrOfExercisesWrong++;
                    }
                    this.btn_Check.Enabled = false;
                    this.btn_Check.BackColor = SystemColors.ControlDark;
                    this.btn_Next.Enabled = true;
                    this.btn_Next.BackColor = SystemColors.Control;
                    this.lb_WriteAnswer.Visible = true;
                    UpdateGUI();
                }
                else    // falsch geantwortet
                {
                    if (this.nrOfTrys == 1)
                    {
                        this.lb_TryAgain.Visible = true;
                    }
                    else
                    {
                        this.lb_SolutionValue.Text = this.currentTask.getResult().ToString();
                        this.lb_SolutionValue.Visible = true;
                    }
                    this.nrOfTrys++;
                    this.txt_Result.Text = "";
                }
            }
            catch (Exception)
            {
                this.lb_WrongInput.Enabled = true;
            }
            
        }

        // Funktion um eine neue Rechung zu erzeugen
        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.currentTask = this.mtf.createTask(this.range, this.typOfExercise);
            this.txt_Invoice.Text = currentTask.exercise();
            this.nrOfExercises++;
            UpdateGUI();
            this.btn_Next.Enabled = false;
            this.btn_Next.BackColor = SystemColors.ControlDark;
            this.nrOfTrys = 1;
            this.btn_Check.Enabled = true;
            this.btn_Check.BackColor = SystemColors.Control;
            this.lb_WriteAnswer.Visible = false;
            this.txt_Result.Text = "";
        }

        // aktualisiert die Statistik Ausgaben
        private void UpdateGUI()
        {
            this.lb_NrOfExercises.Text = this.nrOfExercises + " Rechnungen generiert!";
            this.lb_NrOfExercisesRight.Text = this.nrOfExercisesRight + " Rechnungen richtig!";
            this.lb_NrOfExercisesWrong.Text = this.nrOfExercisesWrong + " Rechnungen falsch!";
            this.lb_PercentOfCorrectAnswers.Text = "Richtige Antworten in Prozent: " +MathF.Round((float)this.nrOfExercisesRight / this.nrOfExercises * 100,2).ToString() +"%";
            this.txt_DiagramRight.Size = new Size((int)(this.gb_Diagram.Size.Width / 100 * (float)this.nrOfExercisesRight / this.nrOfExercises * 100),25);
            this.txt_DiagramWrong.Size = new Size((int)(this.gb_Diagram.Size.Width / 100 * (100 -((float)this.nrOfExercisesRight / this.nrOfExercises * 100))),25);
        }

        // Funktion um Rechenarten auszuwählen
        private void rb_Mixed_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_Addition.Checked)
            {
                this.typOfExercise = 0;
            }
            else if (this.rb_Subtraction.Checked)
            {
                this.typOfExercise = 1;
            }
            else if (this.rb_Multiplikation.Checked)
            {
                this.typOfExercise = 2;
            }
            else if (this.rb_Division.Checked)
            {
                this.typOfExercise = 3;
            }
            else
            {
                this.typOfExercise = 4;
            }
        }

        // Die folgenden 6 Funktionen dienen um Hover-Informationen zu zeigen
        private void lb_NrOfExercisesWrong_MouseEnter(object sender, EventArgs e)
        {
            this.lb_InfoWrongAnswer.Visible = true;
        }

        private void lb_NrOfExercisesWrong_MouseLeave(object sender, EventArgs e)
        {
            this.lb_InfoWrongAnswer.Visible = false;
        }

        private void lb_Range_MouseEnter(object sender, EventArgs e)
        {
            this.lb_InfoReset.Visible = true;
        }

        private void lb_Range_MouseLeave(object sender, EventArgs e)
        {
            this.lb_InfoReset.Visible = false;
        }
        private void lb_TypeOfCalculation_MouseEnter(object sender, EventArgs e)
        {
            this.lb_InfoTypeOfCalculation.Visible = true;
        }

        private void lb_TypeOfCalculation_MouseLeave(object sender, EventArgs e)
        {
            this.lb_InfoTypeOfCalculation.Visible = false;
        }
    }
}
