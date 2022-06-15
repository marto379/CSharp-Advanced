using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodString
{
    internal class Box<T> : IComparable<T> where T: IComparable<T> 
    {
        public Box(T element)
        {
            Element = element;
        }
        public Box(List<T> elements)
        {
            Elements = elements;
        }

        public List<T> Elements { get;}
        public T Element { get;}

        

        public int CountOfGreaterElement<T>(List<T> list, T readline) where T: IComparable =>
            list.Count(word => word.CompareTo(readline) > 0);

        public int CompareTo(T other)
            => Element.CompareTo(other);

    }
}
