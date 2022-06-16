﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    internal class Touple<TFirst,TSecond>
    {
        public Touple(TFirst firstElement,TSecond secondElement)
        {
            FirstElement = firstElement;
            SecondElement = secondElement;
        }
        public TFirst FirstElement { get;private set; }
        public TSecond SecondElement { get;private set; }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement}";
        }
    }
}
