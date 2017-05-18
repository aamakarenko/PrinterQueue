using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterQueue
{
    public class MatrixPrinter : AbstractPrinter
    {
        public MatrixPrinter()
        {
            //Определим "бесконечную" ёмкость лотка для матричного принтера = -1
            Capacity = -1;

            //Предположим, что скорость печати матричного принтера равна эквиваленту 10 л/ч
            Speed = 10;

            //Цветная печать
            Color = false;
        }
    }
}
