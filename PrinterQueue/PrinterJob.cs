using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterQueue
{
    public class PrinterJob<T> where T : AbstractPrinter
    {
        public int PageCount;

        public int Resolution;

        public bool Color;

        public bool TextMode;

        public string PrinterName;

        public string PrinterType;

        public PrinterJob(int PageCount, int Resolution, bool Color, bool TextMode, T Printer)
        {
            if (TextMode)
            {
                if (!Color)
                {
                    if (Printer.Type == "Matrix" && Printer.Resolution >= Resolution)
                    {
                        this.PageCount = PageCount;
                        this.Resolution = Resolution;
                        this.Color = Color;
                        this.TextMode = TextMode;
                        this.PrinterName = Printer.Name;
                        this.PrinterType = Printer.Type;
                    }
                }
            }
        }
    }
}
