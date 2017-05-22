using System;

namespace PrinterQueue.PrinterEquipment
{
    class JetPrinter : AbstractPrinter
    {
        public JetPrinter(string PrinterName, bool Color)
        {
            //Имя принтера
            this.Name = PrinterName;

            //Ёмкость лотка "100 листов"
            this.Capacity = 1000;

            //Скорость печати принтера (л./мин.)
            this.Speed = 10;

            //Разрешение принтера
            this.Resolution = 100;

            //Цветная печать
            this.Color = Color;

            //Тип принтера
            this.Type = 2;
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
