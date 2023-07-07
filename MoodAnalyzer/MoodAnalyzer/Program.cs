using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    internal class Program
    {
        public string Happy_Mood = "I am in Happy Mood";
        public string Sad_Mood = "I am in Sad Mood";
        public static void Main(string[] args)
        {
            
        Console.WriteLine("Wlcome to mood analyzer Problem");
            MoodAnalyze moodAnalyze= new MoodAnalyze(Sad_Mood);
            moodAnalyze.AnalyzeMood();

        }
    }
}