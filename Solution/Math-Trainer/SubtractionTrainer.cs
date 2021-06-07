using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Trainer
{
    class SubtractionTrainer : MatheTrainer
    {
        public SubtractionTrainer(int trainingRange) : base(trainingRange)
        {
            Random rand = new Random();
            this.operand1 = rand.Next(trainingRange + 1);
            this.operand2 = rand.Next(this.operand1 + 1);
        }
        public override string exercise()
        {
            return this.operand1.ToString() + " - " + this.operand2.ToString() + " = ";
        }

        public override int getResult()
        {
            return this.operand1 - this.operand2;
        }
    }
}
