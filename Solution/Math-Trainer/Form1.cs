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
        int range = 0;
        int nrOfExercises = 0;
        Boolean correctInput = true;
        int typOfExercise = 4;  // 0 = addition, 1 = subtraction, 2 = multiplication, 3 = division, 4 = mixed

        public Form1()
        {
            InitializeComponent();
            MatheTrainerFactory mtf = new MatheTrainerFactory();
        }

        private void txt_Range_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.range = int.Parse(this.txt_Range.Text);
                this.lb_WrongRange.Enabled = false;
                this.correctInput = true;
            }
            catch (Exception)
            {
                this.lb_WrongRange.Enabled = true;
                this.range = 0;
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (this.range != 0 && this.correctInput == true)
            {

            }
        }
    }
}
