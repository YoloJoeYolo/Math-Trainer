using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Trainer
{
    class MatheTrainer
    {
        protected int operand1;
        protected int operand2;

        public MatheTrainer(int trainingRange)
        {

        }

        public virtual string exercise()
        {
            return ""; // leerer String --> keine Implementierung hier sinnvoll
        }
        public virtual int getResult()
        {
            return 0; // keine Implementierung sinnvoll
        }
    }
}
