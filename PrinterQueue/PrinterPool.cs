using System.Collections.Generic;

namespace PrinterQueue
{
    public class PrinterPool
    {
        private List<AbstractPrinter> Printers = new List<AbstractPrinter>();

        public void Add(AbstractPrinter Printer)
        {
            this.Printers.Add(Printer);
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

        public AbstractPrinter SearchGoodPrinter(Job Job)
        {
            foreach (var p in this.Printers)
            {
                if (IsGoodPrinterForJob(Job, p))
                    return p;
            }

            return null;
        }
    }
}
