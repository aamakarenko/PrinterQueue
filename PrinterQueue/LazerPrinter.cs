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
            this.Capacity = -1;

            // Ёмкость лотка "100 листов"
            this.Capacity = Capacity;

            //Цветная печать
            this.Color = false;

            this.Type = "Lazer";
        }
    }
}
