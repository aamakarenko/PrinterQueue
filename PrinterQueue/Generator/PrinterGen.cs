using PrinterQueue.PrinterEquipment;
using System.Collections.Generic;

namespace PrinterQueue.Generator
{
    public static class PrinterGen
    {
        public static List<AbstractPrinter> Generate()
        {
            var printers = new List<AbstractPrinter>
            {
                new JetPrinter("Epson Expression Home XP-332", true),
                new JetPrinter("Canon PIXMA PRO-1", false),
                new MatrixPrinter("Epson LQ 630"),
                new LazerPrinter("Samsung SL-M2020"),
                new LazerPrinter("Canon i-SENSYS LBP7100Cn", 1000)
            };

            return printers;
        }
    }
}
