﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROBSI
{
    public class Resolution
    {
        private int width;
        private int height;

        public Resolution(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            get { return this.width; }
        }

        public int Height
        {
            get { return this.height; }
        }
    }
}
