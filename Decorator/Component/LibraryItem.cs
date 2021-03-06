﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Component
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    abstract class LibraryItem<T>
    {
        // Each T has its own NumCopies
        public static int NumCopies { get; set; }

        public abstract void Display();
    }
}
