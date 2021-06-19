using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Trainer
{
    class AdditionTrainer : MatheTrainer
    {
        public AdditionTrainer(int trainingRange) : base(trainingRange)
        {
            Random rand = new Random();
            this.operand1 = rand.Next(trainingRange + 1);
            this.operand2 = rand.Next(trainingRange - this.operand1 + 1);
        }
        public override string exercise()
        {
            return this.operand1.ToString() + " + " + this.operand2.ToString() + " = ";
        }

        public override int getResult()
        {
            return this.operand1 + this.operand2;
        }
    }
}
