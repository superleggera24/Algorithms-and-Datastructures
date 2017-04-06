﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class Node<T>// where T : IComparable
    {
        public Node<T> next;
        public T data;
    }
}
