using System;
using System.Collections.Generic;

namespace SystemCollectionsPracWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<int>();
            var rand = new Random();
            for (int i = 0; i < 40; i++)
            {
                collection.Add(rand.Next(0, 1000));
            }
            //•	Удалить все нечетные элементы списка List<int>;
            for (int i = 0; i < collection.Count; i++)
            {
                if (i % 2 == 1)
                {
                    collection.RemoveAt(i);
                }
            }
            //•	Вывести на экран элементы, значение которых больше среднего арифметического всех элементов коллекции.
            var sum = 0;
            for (int i = 0; i < collection.Count; i++)
            {
                sum += collection[i];
            }
            var avgList = sum / collection.Count;
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] > avgList)
                {
                    Console.Write(collection[i]);
                    Console.Write(" ");
                }
            }
            //Используя интерфейсы System.Collections реализовать собственную коллекцию, ключём которой является строка, а значением List<string>
            var myCollection = new Dictionary<string, List<string>>();
        }
    } 
}