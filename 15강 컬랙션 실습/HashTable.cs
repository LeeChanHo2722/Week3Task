/*using System;
using System.Collections;
using UnityEngine;

namespace _15강_컬랙션_실습
{
    class HashTable : MonoBehaviour
    {
        static void Main()
        {
            Hashtable hash = new Hashtable();

            Goblin goblin = new Goblin(); //오브젝트 타입을 저장하기 때문에 클래스 인스턴스도 저장 가능
            Slime slime = new Slime();
            hash["Goblin"] = goblin; //요소 추가 [] 연산

            hash.Add("Slime", slime);
            hash.Add(1, "정수");
            hash.Add(1.2f, "실수");
            hash.Add("안녕하세요 고박사입니다.", "문자열");

            foreach ( object key in hash.Keys )
            {
                Console.WriteLine("{0} = {1}", key, hash[key]);
            }
            if (hash.ContainsKey("Slime"))
            {
                Console.WriteLine("Slime 키 존재");
            }
            if (hash.ContainsValue(goblin))
            {
                Console.WriteLine("{0} 값 존재",goblin);
            }
            Console.WriteLine(hash.Count);
            hash.Remove("Slime");
            Console.WriteLine(hash.Count);
            hash.Clear();
            Console.WriteLine(hash.Count);
        }
    }
}*/
