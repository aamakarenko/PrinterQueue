﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterQueue
{
    public class JetPrinter : AbstractPrinter
    {
        public JetPrinter(bool Color)
        {
            //Ёмкость лотка "100 листов"
            Capacity = 100;

            //Цветная печать
            Color = Color;
        }
    }
}