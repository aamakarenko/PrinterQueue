using PrinterQueue.Generator;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace PrinterQueue.PrinterEquipment
{
    public class PrinterPool
    {
        private List<AbstractPrinter> Printers = new List<AbstractPrinter>();

        public void Add(AbstractPrinter Printer)
        {
            this.Printers.Add(Printer);
        }

        public void Add(List<AbstractPrinter> Printers)
        {
            this.Printers.AddRange(Printers);
        }

        private bool IsGoodPrinterForJob(Job Job, AbstractPrinter Printer)
        {
            if ((Job.GetPageCount() <= Printer.GetCapacity() || Printer.GetCapacity() == -1) &&
                (Job.GetPrinterType() == Printer.GetPrinterType() || Job.GetPrinterName() == Printer.GetName()) &&
                Job.GetResolution() <= Printer.GetResolution() &&
                Job.IsColor() == Printer.IsColor())
                return true;

            return false;
        }

        private AbstractPrinter SearchGoodPrinter(Job Job)
        {
            foreach (var p in this.Printers)
            {
                if (IsGoodPrinterForJob(Job, p))
                    return p;
            }

            return null;
        }

        public void PrintJobs(List<Job> Jobs)
        {
            foreach (var j in Jobs)
            {

                object i = SearchGoodPrinter(j);
                if (i != null)
                {
                    Type t = i.GetType();
                    MethodInfo Print = t.GetMethod("Print", BindingFlags.Instance | BindingFlags.NonPublic);

                    Console.WriteLine(Print.Invoke(i, new object[] { j }));
                }
                else
                {
                    Console.WriteLine("Для задания: " + j.ToString() + " не найден подходящий принтер");
                }
            }
        }

        public void PrintJob(Job Job)
        {
            object i = SearchGoodPrinter(Job);
            if (i != null)
            {
                Type t = i.GetType();
                MethodInfo Print = t.GetMethod("Print", BindingFlags.Instance | BindingFlags.NonPublic);

                Console.WriteLine(Print.Invoke(i, new object[] { Job }));
            }
            else
            {
                Console.WriteLine("Для задания: " + Job.ToString() + " не найден подходящий принтер");
            }
            
        }

        public bool Delete(AbstractPrinter Printer)
        {
            if (Printers.Find(p => p.Equals(Printer)) != null)
            {
                this.Printers.Remove(Printer);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
