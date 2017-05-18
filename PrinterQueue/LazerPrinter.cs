using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterQueue
{
    public class LazerPrinter : AbstractPrinter
    {
        public LazerPrinter(int Capacity)
        {
            // Ёмкость лотка "бесконечный"  
            Capacity = -1;

            // Ёмкость лотка "100 листов"
            Capacity = Capacity;

            //Цветная печать
            Color = false;
        }
    }
}
