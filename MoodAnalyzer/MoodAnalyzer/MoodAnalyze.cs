using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    internal class MoodAnalyze
    {
        private string Message;
        //constructor for MoodAnalyzer 
        public MoodAnalyze(string message)
        {
            //this indicate difff of global name and method parrameter
            this.Message = message;
        }

        

        //method for MoodAnalyzer
        public string AnalyzeMood()
        {
            //UC2
            try
            {
                if (this.Message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionsType.EMPTY_MESSAGE, "Message should not be Empty");
                }
                // put the code here that may raise exceptions
                //if message contains sad
                if (this.Message.Contains("Sad"))
                    // it will retrun sad
                    return "Sad";
                else
                    //else happy
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionsType.NULL_MESSAGE, "Message should not be Null");
            }
            
        }

    }
}
