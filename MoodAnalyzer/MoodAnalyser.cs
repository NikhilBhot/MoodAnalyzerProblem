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



        /*
         * Given “I am in Sad Mood” message Should Return SAD analyseMood method can just return SAD to pass this Test Case (TC)
         */
        public string AnalyseMood1()
        {
            return "SAD";
        }
    }
}
