using System;

namespace PrinterQueue.PrinterEquipment
{
    class MatrixPrinter : AbstractPrinter
    {
        public MatrixPrinter(string PrinterName)
        {
            //Имя принтера
            this.Name = PrinterName;

            //Определим "бесконечную" ёмкость лотка для матричного принтера = -1
            this.Capacity = -1;

            //Предположим, что скорость печати матричного принтера равна эквиваленту 10 л/ч
            this.Speed = 10;

            //Разрешение принтера
            this.Resolution = 50;

            //Цветная печать
            this.Color = false;

            //Тип принтера
            this.Type = 1;
        }

        public override Type GetType()
        {
            return GetType();
        }

        protected override void Print(Job Job)
        {
            Console.WriteLine("Печать задания на принтере " + this.Name + "\n" +
                    "Кол-во листов печати: " + Job.GetPageCount());
        }
    }
}
