using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Trainer
{
    class MatheTrainerFactory
    {
        int wrongAnswer = 0;
        int rightAnswer = 0;

        public MatheTrainerFactory()
        {
            //nichts zu tun
        }

        public MatheTrainer createTask(int Range, int typOfExercise)
        {
            switch (typOfExercise)
            {
                case 4:
                    Random rand = new Random();
                    int randValue = rand.Next(4); // Zufallszahl zwischen 0 und 3

                    if (randValue == 0)
                    {
                        AdditionTrainer t = new AdditionTrainer(Range);
                        return t;
                    }
                    else if (randValue == 1)
                    {
                        SubtractionTrainer t = new SubtractionTrainer(Range);
                        return t;
                    }
                    else if (randValue == 2)
                    {
                        MultiplicationTrainer t = new MultiplicationTrainer(Range);
                        return t;
                    }
                    else
                    {
                        DivisionTrainer t = new DivisionTrainer(Range);
                        return t;
                    }
                    
            }
        }
        public void train()
        {
            for (int i = 0; i < this.nrOfExercises; i++)
            {
                Console.Write(exercises[i].exercise());
                int result = int.Parse(Console.ReadLine());

                if (result == exercises[i].getResult())
                {
                    //richtige Antwort
                    this.correctAnswers++;
                    Console.WriteLine("Richitges Ergebnis!");
                }
                else
                {
                    //falsche Antwort
                    Console.WriteLine("Falsche Antwort! Bitte nochmals probieren!");
                    Console.Write(exercises[i].exercise());
                    result = int.Parse(Console.ReadLine());
                    //Überprüfen der 2.Antwort
                    if (result == exercises[i].getResult())
                    {
                        //richtige Antwort
                        this.correctAnswers++;
                        Console.WriteLine("Richitges Ergebnis!");
                    }
                    else
                    {
                        Console.WriteLine("Leider Falsch! Richtige Antwort: " + exercises[i].getResult());
                    }

                }
            }

        }

        public string getStatistics()
        {
            double percent = (double) this.correctAnswers / this.nrOfExercises * 100;
            return this.correctAnswers + " von " + this.nrOfExercises + " Rechnungen (" +percent +"%) richtig gelöst!";
        }
    }
}
