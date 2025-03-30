/*using System;
using System.Collections;
using UnityEngine;

namespace _15강_컬랙션_실습
{
    class Queue : MonoBehaviour
    {
        static void Main()
        {
            Queue queue = new Queue();

            for (int i = 0; i<5; i++)
            {
                queue.Enqueue(i);
            }
            Console.WriteLine(queue.count);
            Console.WriteLine(queue.Peek()); //요소를 삭제하지 않고 요소를 반환
            Console.WriteLine(queue.count);

            object data = queue.Dequeue();
            Console.WriteLine(data); // 큐에서 빠져나온 데이터
            Console.WriteLine(queue.count);
            queue.Clear();
            Console.WriteLine(queue.count);
        }
    }
}*/
