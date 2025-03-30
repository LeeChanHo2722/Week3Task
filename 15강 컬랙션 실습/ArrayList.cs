/*using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace _15강_컬랙션_실습
{
    class Program
    {
        static void Main()
        {
            ArrayList array = new ArrayList();
            Console.WriteLine(array.Add(10));
            array.Insert(1, 100);

            for (int i=0; i<array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            Collection<int> data = new Collection<int>();
            data.Add(1);
            data.Add(3);
            data.Add(2);
            array.AddRange(data);
            array.Sort();
            array.Remove(10);

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            array.RemoveAt(0);
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }

            array.RemoveRange(0, 2);
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            array.Clear();
            Console.WriteLine(array.Count);
        }
    }
}
*/