using PrinterQueue.PrinterEquipment;
using System;

namespace PrinterQueue
{
    public class Simple
    {
        public void Run()
        {
            JetPrinter jet = new JetPrinter("Тфьу1", true);
            MatrixPrinter matrix = new MatrixPrinter("Тфьу3");
            LazerPrinter lazer = new LazerPrinter("Тфьу5");

            PrinterPool pool = new PrinterPool();
            pool.Add(jet);
            pool.Add(matrix);
            pool.Add(lazer);

            Job job1 = new Job(527, 100, true, false, "Тфьу1");
            Job job2 = new Job(11, 11, false, false, "Тфьу2");
            Job job3 = new Job(12, 12, false, true, "Тфьу3");
            Job job4 = new Job(13, 13, true, false, "Тфьу4");
            Job job5 = new Job(100123123, 14, false, false, "Тфьу5");
            Job job6 = new Job(15, 15, false, true, "Тфьу6");
            Job job7 = new Job(16, 16, true, false, "Тфьу7");

            JobQueue.Add(job1);
            JobQueue.Add(job2);
            JobQueue.Add(job3);
            JobQueue.Add(job4);
            JobQueue.Add(job5);
            JobQueue.Add(job6);
            JobQueue.Add(job7);

            //JobQueue.Remove(job4);

            pool.PrintJobs(JobQueue.List());

            Console.WriteLine(JobQueue.Next().ToString() + "Next" + JobQueue.Next().ToString());
            

            //object i = Utils.GetRandomObject(pool.GetAll());
            //Type t = i.GetType();
            //MethodInfo Print = t.GetMethod("Print");
            //Console.WriteLine(Print.Invoke(i, new object[] { job1 } ));

            //pool.Delete(jet);

            //foreach (var i in JobQueue.List())
            //{
            //    var p = pool.SearchGoodPrinter(i);
            //    if (p != null)
            //    {
            //        p.Print(i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Для задания " + i.ToString() + " не найден походящий принтер");
            //    }
                
            //}
        }
    }
}
