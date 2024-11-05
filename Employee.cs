using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChallengeApp
{

    public class Employee
    {
        private List<float> score = new List<float>();

        public Employee(string name, string last_name, string age)
        {
            this.Name = name;
            this.Last_Name = last_name;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Last_Name { get; private set; }
        public string Age { get; private set; }
     


        public void AddScore(float score)
        {
            //Walidacja dodawanie warunków działania programu
            //Można dodawać oceny od 0 do 100

            if (score >= 0 && score <= 100)
            {
                this.score.Add(score);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość oceny");
            }

        }
        // Dodanie metody o tej samej nazwie ale innym parametrze
        // Teraz wpisując string program przerabia go na float

        public void AddScore(string score)
        {
            if(float.TryParse(score, out float result))
            {
                this.score.Add(result);
            }
            else
            {
                Console.WriteLine("To nie jest ocena");
            }
            var value = float.Parse(score);
            this.AddScore(value);
        }
        public void AddScore(int score)
        {
            if (score >=0 && score <= 100)
            {
                this.score.Add(score);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość oceny");
            }
        }
        public void AddScore (long score)
        {
            if (score >= 0 && score <= 100)
            {
                this.score.Add(score);
            }
        }
        public void AddScore (double score)
        {
          float floatvalue = (float)score;
          this.score.Add(floatvalue);
        }

        public float Result
        {
            get
            {
                return this.score.Sum();
                    
            }
        }
  
       
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

           

            return statistics;



            foreach (var score in this.score)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min =Math.Min(statistics.Min, score);
                statistics.Average = +score;
            }

            statistics.Average /= this.score.Count;
            return statistics;

            



        }
        
       

    }
}
