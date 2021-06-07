using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Trainer
{
    class DivisionTrainer : MatheTrainer
    {
        public DivisionTrainer(int trainingRange) : base(trainingRange)
        {
            Random rand = new Random();
            do
            {
                this.operand1 = rand.Next(trainingRange + 1);
                this.operand2 = rand.Next(1, trainingRange + 1);
            } while (operand1 % operand2 != 0);
        }
        
        public override string exercise()
        {
            return this.operand1.ToString() + " / " + this.operand2.ToString() + " = ";
        }

        public override int getResult()
        {
            return this.operand1 / this.operand2;
        }
    }
}
