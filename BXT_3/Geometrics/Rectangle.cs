﻿using BXT_3.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_3.Geometrics
{
    internal class Rectangle
    {
        public Position Centre { get; init; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Rectangle(float Width, float Height) 
        {
            this.Width = Width;
            this.Height = Height;

        }



    }
}