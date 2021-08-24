using System.Diagnostics;
using System;

namespace Classes.StopWatch
{
    public class StopWatchHandler
    {   
        private Stopwatch stopwatch;
        public StopWatchHandler() { this.stopwatch = new(); }
        public void StartStopWatch()
        {
            stopwatch.Start();
        }
        public void StopStopWatch()
        {
            stopwatch.Stop();
        }
        public double GetTime()
        {
            return stopwatch.Elapsed.TotalMilliseconds;
        }
        public void ResetStopWatch()
        {
            stopwatch.Reset();
        }
    }
}