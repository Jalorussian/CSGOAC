﻿using System;

namespace KACAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    class VTableSlotAttribute : Attribute
    {
        public int Slot { get; set; }

        public VTableSlotAttribute(int s)
        {
            Slot = s;
        }
    }
}
