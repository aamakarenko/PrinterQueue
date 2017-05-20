namespace PrinterQueue
{
    public class MatrixPrinter : AbstractPrinter
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
    }
}
