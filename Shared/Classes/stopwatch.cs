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
        public TimeSpan GetTime()
        {
            return stopwatch.Elapsed;
        }
        public void ResetStopWatch()
        {
            stopwatch.Reset();
        }
    }
}