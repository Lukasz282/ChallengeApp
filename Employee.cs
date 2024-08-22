using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{

    public class Employee
    {
        
        private List<int> score = new List<int>();

        public Employee(string name, string last_name, string age)
        {
            this.Name = name;
            this.Last_Name = last_name;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Last_Name { get; private set; }
        public string Age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }


        public void AddScore(int score)
        {
            this.score.Add(score);
        }


    }
}
