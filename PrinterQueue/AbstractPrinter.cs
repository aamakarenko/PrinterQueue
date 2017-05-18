namespace PrinterQueue
{
    public abstract class AbstractPrinter
    {
        //Название принтера
        public string Name;

        //Максимальная высота печатного листа
        public int MaxHeight;

        //Максимальная ширина печатного листа
        public int MaxWidth;

        //Максимальное разрешение
        public int Resolution;

        //Скорость печати (кол-во листов единицу времени(такт))
        public int Speed;

        //Ёмкость лотка подачи листов
        public int Capacity;

        //Признак цветной печати
        public bool Color;

        //Тип принтера
        public string Type;
    }
}
