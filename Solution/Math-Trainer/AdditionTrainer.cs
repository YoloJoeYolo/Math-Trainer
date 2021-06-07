using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Trainer
{
    class AdditionTrainer : MatheTrainer
    {
        public AdditionTrainer(int trainingRange) : base(trainingRange)
        {
            //trainingRange = 100
            //operand1?, operand2? --> maxValue
            // Lösungsidee 1: für op1 (maxValue von 100), Zufallszahl für op2 (maxValue von 100 - op1)
            // Lösungsidee 2: In einer SChleife solange op1 und op2 (maxValue von 100) generieren bis Ergebnis <= 100 


            Random rand = new Random();
            this.operand1 = rand.Next(trainingRange + 1); // weil Zufallszahl < maxValue
            this.operand2 = rand.Next(trainingRange - this.operand1 + 1); // weil Zufallszahl < maxValue
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
