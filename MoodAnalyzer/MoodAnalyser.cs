using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if (message.Contains("happy", System.StringComparison.OrdinalIgnoreCase))
            {
                return "Happy Mood";
            }
            else if (message.Contains("sad", System.StringComparison.OrdinalIgnoreCase))
            {
                return "Sad Mood";
            }
            else
            {
                return "Unknown Mood";
            }
        }
    }
}
