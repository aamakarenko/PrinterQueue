namespace PrinterQueue
{
    public class Job
    {
        private int PageCount;

        private int Resolution;

        private bool Color;

        private bool TextMode;

        private string PrinterName;

        private int PrinterType;

        public Job(int PageCount, int Resolution, bool Color, bool TextMode, string PrinterName)
        {
            this.PageCount = PageCount;
            this.Resolution = Resolution;
            this.Color = Color;
            this.TextMode = TextMode;
            this.PrinterName = PrinterName;
            this.PrinterType = 0;
        }

        public Job(int PageCount, int Resolution, bool Color, bool TextMode, int PrinterType)
        {
            this.PageCount = PageCount;
            this.Resolution = Resolution;
            this.Color = Color;
            this.TextMode = TextMode;
            this.PrinterName = null;
            this.PrinterType = PrinterType;
        }

        public int GetPageCount()
        {
            return PageCount;
        }

        public int GetResolution()
        {
            return Resolution;
        }

        public bool IsColor()
        {
            return Color;
        }

        public bool IsTextMode()
        {
            return TextMode;
        }

        public string GetPrinterName()
        {
            return PrinterName;
        }

        public int GetPrinterType()
        {
            return PrinterType;
        }

        public override string ToString()
        {
            return PageCount + " " + PrinterName + " " + PrinterType + " " + Resolution + " " + TextMode + " " + Color;
        }
    }
}
