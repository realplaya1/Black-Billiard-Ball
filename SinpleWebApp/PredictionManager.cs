using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinpleWebApp
{
    public class PredictionManager
    {
        private List<string> predictions = new List<string> { "1", "2", "3", "4", "5"};

        Random rnd;

        public string GetRandomPrediction()
        { 
            return predictions[rnd.Next(0,predictions.Count)];
        }
    }
}
