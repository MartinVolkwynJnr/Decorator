using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    abstract class Decorator<T> : LibraryItem<T>
    {
        LibraryItem<T> libraryItem;

        // Constructor
        public Decorator(LibraryItem<T> libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }
}
