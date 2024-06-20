
using System;
using System.Collections.Generic;

namespace GenericClassExample
{
    // Define a generic class GenericList with a type parameter T
    public class GenericList<T>
    {
        private List<T> _items = new List<T>();

        // Method to add an item to the list
        public void Add(T item)
        {
            _items.Add(item);
        }

        // Method to get an item at a specific index
        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return _items[index];
        }

        // Method to get the count of items in the list
        public int Count
        {
            get { return _items.Count; }
        }

        // Method to print all items in the list
        public void PrintAllItems()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of GenericList for integers
            GenericList<int> intList = new GenericList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            Console.WriteLine("Integer List:");
            intList.PrintAllItems();

            // Create an instance of GenericList for strings
            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            Console.WriteLine("String List:");
            stringList.PrintAllItems();

            // Demonstrating Get method and handling out of range index
            try
            {
                Console.WriteLine("Element at index 1 in Integer List: " + intList.Get(1));
                Console.WriteLine("Element at index 5 in Integer List: " + intList.Get(5));
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
