namespace PrinterQueue
{
    public class LazerPrinter : AbstractPrinter
    {
        public LazerPrinter(string PrinterName)
        {
            //Имя принтера
            this.Name = PrinterName;

            // Ёмкость лотка "бесконечный"  
            this.Capacity = -1;

            //Скорость печати (л./мин.)
            this.Speed = 10;

            //Разрешение
            this.Resolution = 100;

            //Цветная печать
            this.Color = false;

            //Тип принтера
            this.Type = 3;
        }

        public LazerPrinter(string PrinterName, int Capacity)
        {
            //Имя принтера
            this.Name = PrinterName;

            // Ёмкость лотка
            this.Capacity = Capacity;

            //Скорость печати (л./мин.)
            this.Speed = 10;

            //Разрешение
            this.Resolution = 100;

            //Цветная печать
            this.Color = false;

            //Тип принтера
            this.Type = 3;
        }
    }
}
