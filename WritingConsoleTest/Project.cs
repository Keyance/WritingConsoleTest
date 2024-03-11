using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace WritingConsoleTest
{
    public class Project
    {
        public string Name { get; set; }
        string Path;
        public Dictionary <DateOnly, int> Days = new Dictionary <DateOnly, int> ();
        public Project(string path, string name)
        {
            Name = name;
            Path = path;

        }

        public double GetAverage ()
        {
            double result = 0;
            int count = 0;
            int sum = 0;

            foreach (var item in Days)
            {
                sum = sum + item.Value;
                count++;
            }

            result = sum / count;
            return result;
        }

        public int GetSum ()
        {
            int sum = 0;

            foreach (var item in Days)
            {
                sum = sum + item.Value;
            }

            return sum;
        }

        public void ShowData ()
        {
            foreach (var item in Days)
            {
                Console.WriteLine($"Day: {item.Key} - {item.Value} words");
            }
        }


    }
}
