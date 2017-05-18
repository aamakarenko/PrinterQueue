using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterQueue
{
    public class PrinterJob
    {
        public int PageCount;

        public int Resolution;

        public bool Color;

        public bool TextMode;

        public string PrinterName;

        public int PrinterType;

        public PrinterJob(int PageCount, int Resolution, bool Color, bool TextMode, string PrinterName)
        {
            this.PageCount = PageCount;
            this.Resolution = Resolution;
            this.Color = Color;
            this.TextMode = TextMode;
            this.PrinterName = PrinterName;
            this.PrinterType = 0;
        }

        public PrinterJob(int PageCount, int Resolution, bool Color, bool TextMode, int PrinterType)
        {
            this.PageCount = PageCount;
            this.Resolution = Resolution;
            this.Color = Color;
            this.TextMode = TextMode;
            this.PrinterName = null;
            this.PrinterType = PrinterType;
        }
    }
}
