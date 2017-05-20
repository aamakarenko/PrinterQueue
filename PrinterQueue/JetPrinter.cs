namespace PrinterQueue
{
    public class JetPrinter : AbstractPrinter
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
    }
}
