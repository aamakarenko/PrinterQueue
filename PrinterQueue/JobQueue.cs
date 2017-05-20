using System;
using System.Collections.Generic;
using System.Linq;

namespace PrinterQueue
{
    public static class JobQueue
    {
        private static Queue<Job> jobQueue = new Queue<Job>();

        public static bool Add(Job job)
        {
            try
            {
                jobQueue.Enqueue(job);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Remove(Job job)
        {
            List<Job> jobList = new List<Job>();
            try
            {
                if (jobQueue.Contains(job))
                    jobList = jobQueue.ToList();

                jobList.Remove(job);
                jobQueue.Clear();
                foreach (var l in jobList)
                {
                    jobQueue.Enqueue(l);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Job> List()
        {
            return jobQueue.ToList();
        }

        public static Job Next()
        {
            return jobQueue.Dequeue();
        }

        public static Job GetNext()
        {
            return jobQueue.Peek();
        }
    }
}
