using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Trainer
{
    public partial class Form1 : Form
    {
        private int range = 0;
        private int nrOfExercises = 0;
        private int typOfExercise = 4;  // 0 = addition, 1 = subtraction, 2 = multiplication, 3 = division, 4 = mixed
        private int nrOfExercisesWrong = 0;
        private int nrOfExercisesRight = 0;
        private int nrOfTrys = 1;
        private MatheTrainer currentTask;
        private MatheTrainerFactory mtf = new MatheTrainerFactory();

        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Range_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.range = int.Parse(this.txt_Range.Text);
            }
            catch (Exception)
            {
                this.range = 0;
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            try
            {
                int result = int.Parse(this.txt_Result.Text);
                this.lb_WrongInput.Enabled = false;
                if (this.currentTask.getResult() == result)
                {
                    if (this.nrOfTrys <= 2)
                    {
                        this.nrOfExercisesRight++;
                    }
                    else
                    {
                        this.nrOfExercisesWrong++;
                    }
                    this.btn_Next.Enabled = true;
                    this.btn_Next.BackColor = SystemColors.Control;
                }
                else
                {
                    if (this.nrOfExercises == 2)
                    {
                        // LB mit Info nochmals Probieren
                        throw new NotImplementedException();
                    }
                    else
                    {
                        // LB mit Lösung
                        throw new NotImplementedException();
                    }
                    // LB mit Info aufgeben
                    this.nrOfTrys++;
                    throw new NotImplementedException();
                }
            }
            catch (Exception)
            {
                this.lb_WrongInput.Enabled = true;
                throw;
            }
            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (this.range != 0 && !this.lb_WrongRange.Enabled)
            {
                this.currentTask = this.mtf.createTask(this.range, this.typOfExercise);
                this.txt_Invoice.Text = currentTask.exercise();
                this.nrOfExercises++;
                UpdateGUI();
                this.btn_Next.Enabled = false;
                this.btn_Next.BackColor = SystemColors.ControlDark;
                this.nrOfTrys = 1;
            }
        }

        private void UpdateGUI()
        {
            this.lb_NrOfExercises.Text = this.nrOfExercises + " Rechnungen generiert!";
            this.lb_NrOfExercisesRight.Text = this.nrOfExercisesRight + " Rechnungen falsch!";
            this.lb_NrOfExercisesWrong.Text = this.nrOfExercisesWrong + "0 Rechnungen richtig!";
            this.lb_PercentOfCorrectAnswers.Text = "Percent of correct answers: " + ((double)this.nrOfExercisesRight / this.nrOfExercises * 100).ToString();
        }

        private void lb_nrOfExercisesWrong_MouseHover(object sender, EventArgs e)
        {
            // Info was alles als falsch beantwortet gilt, also nicht beim zweiten mal Richtig...
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
