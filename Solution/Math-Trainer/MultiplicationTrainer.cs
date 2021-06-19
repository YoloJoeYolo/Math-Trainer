using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Trainer
{
    class MultiplicationTrainer : MatheTrainer
    {
        public MultiplicationTrainer(int trainingRange) : base(trainingRange)
        {
            Random rand = new Random();
            do
            {
                this.operand1 = rand.Next(trainingRange + 1);
                this.operand2 = rand.Next(trainingRange + 1);
            } while (this.getResult() > trainingRange);
        }
        public override string exercise()
        {
            return this.operand1.ToString() + " * " + this.operand2.ToString() + " = ";
        }

        public override int getResult()
        {
            return this.operand1 * this.operand2;
        }
    }
}
