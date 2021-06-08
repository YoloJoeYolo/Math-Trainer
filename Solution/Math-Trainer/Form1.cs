using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// V1.2.1
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
                if (this.range <= 0)
                {
                    this.lb_WrongRange.Visible = true;
                    resetToDefault();
                }
                else
                {
                    this.lb_WrongRange.Visible = false;
                    this.txt_Invoice.BackColor = SystemColors.Control;
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
        
        public void resetToDefault()
        {
            this.range = 0;
            this.nrOfExercises = 0;
            this.nrOfExercisesRight = 0;
            this.nrOfExercisesWrong = 0;
            this.txt_Invoice.BackColor = SystemColors.ControlDark;
            this.txt_Result.ReadOnly = true;
            this.txt_Result.BackColor = SystemColors.ControlDark;
            this.btn_Check.Enabled = false;
            this.btn_Check.BackColor = SystemColors.ControlDark;
            this.btn_Next.Enabled = false;
            this.btn_Next.BackColor = SystemColors.ControlDark;
            UpdateGUI();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            try
            {
                int result = int.Parse(this.txt_Result.Text);
                this.lb_WrongInput.Enabled = false;
                this.lb_Solution.Visible = false;
                this.lb_TryAgain.Visible = false;
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
                    this.btn_Check.Enabled = false;
                    this.btn_Check.BackColor = SystemColors.ControlDark;
                    this.btn_Next.Enabled = true;
                    this.btn_Next.BackColor = SystemColors.Control;
                }
                else
                {
                    if (this.nrOfExercises == 2)
                    {
                        this.lb_TryAgain.Visible = true;
                    }
                    else
                    {
                        this.lb_Solution.Text = "Ergebnis: " +this.currentTask.getResult();
                        this.lb_Solution.Visible = true;
                    }
                    // LB mit Info aufgeben
                    this.nrOfTrys++;
                    throw new NotImplementedException();
                }
            }
            catch (Exception)
            {
                this.lb_WrongInput.Enabled = true;
            }
            
        }

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
        }

        private void UpdateGUI()
        {
            this.lb_NrOfExercises.Text = this.nrOfExercises + " Rechnungen generiert!";
            this.lb_NrOfExercisesRight.Text = this.nrOfExercisesRight + " Rechnungen falsch!";
            this.lb_NrOfExercisesWrong.Text = this.nrOfExercisesWrong + "0 Rechnungen richtig!";
            this.lb_PercentOfCorrectAnswers.Text = "Percent of correct answers: " + ((double)this.nrOfExercisesRight / this.nrOfExercises * 100).ToString();
        }

        private void lb_nrOfExercisesWrong_MouseEnter(object sender, EventArgs e)
        {
            this.lb_InfoWrongAnswer.Visible = true;
        }

        private void lb_nrOfExercisesWrong_MouseLeave(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
