﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    internal class Box<T>
    {
        public Box(T element)
        {
            Element = element;
        }
        public T Element { get;}

        public override string ToString()
        {
            return $"{typeof(T)}: {Element}";
        }
    }
}
