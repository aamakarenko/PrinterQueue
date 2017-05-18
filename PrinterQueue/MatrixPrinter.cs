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
            this.Capacity = -1;

            //Предположим, что скорость печати матричного принтера равна эквиваленту 10 л/ч
            this.Speed = 10;

            //Цветная печать
            this.Color = false;

            this.Type = "Matrix";
        }
    }
}
