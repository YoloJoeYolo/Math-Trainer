using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Trainer
{
    class MatheTrainerFactory
    {
        public MatheTrainerFactory()
        {
            //nichts zu tun
        }

        public MatheTrainer createTask(int Range, int typOfExercise)
        {
            MatheTrainer task;
            switch (typOfExercise)
            {
                case 0:
                    task = new AdditionTrainer(Range);
                    return task;
                default:
                    Random rand = new Random();
                    int randValue = rand.Next(4); // Zufallszahl zwischen 0 und 3

                    switch (randValue)
                    {
                        case 0:
                             task = new AdditionTrainer(Range);
                            return task;
                        case 1:
                             task = new SubtractionTrainer(Range);
                            return task;
                        case 2:
                             task = new MultiplicationTrainer(Range);
                            return task;
                        default:
                             task = new DivisionTrainer(Range);
                            return task;
                    }
                    
            }
        }
    }
}
