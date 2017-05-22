using System;

namespace PrinterQueue.PrinterEquipment
{
    public abstract class AbstractPrinter
    {
        //Название принтера
        protected string Name;

        //Максимальная высота печатного листа
        protected int MaxHeight;

        //Максимальная ширина печатного листа
        protected int MaxWidth;

        //Максимальное разрешение
        protected int Resolution;

        //Скорость печати (кол-во листов единицу времени(такт))
        protected int Speed;

        //Ёмкость лотка подачи листов
        protected int Capacity;

        //Признак цветной печати
        protected bool Color;

        //Тип принтера
        protected int Type;

        public string GetName()
        {
            return Name;
        }

        public int GetMaxHeight()
        {
            return MaxHeight;
        }

        public int GetResolution()
        {
            return Resolution;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public int GetCapacity()
        {
            return Capacity;
        }

        public bool IsColor()
        {
            return Color;
        }

        public int GetPrinterType()
        {
            return Type;
        }

        protected abstract void Print(Job Job);

        public abstract new Type GetType();
    }
}
