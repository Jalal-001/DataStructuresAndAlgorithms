﻿using System;

namespace ReferenceTypeAndValueType
{
    public class ReferenceType
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Swap(ref int x,ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
        public void CheckOutKeyword(out int x)
        {
            x = 100;
            return;
        }
    }
}
