using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public StatsComputer CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            StatsComputer data = new StatsComputer();
            if(null == numbers || 0== numbers.Count)
            {
                average = 0;
                min = 0;
                max = 0;
            }
            return data;
        }
    }
}
