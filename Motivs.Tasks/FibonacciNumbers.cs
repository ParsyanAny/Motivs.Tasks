using System;
using System.Collections;
using System.Collections.Generic;

namespace Motivs.Tasks
{
    class FibonacciNumbers : IEnumerable<int>
    {
        public FibonacciNumbers(uint finalNumber)
        {
            FinalNumber = finalNumber;
            fibonacciList = createList(finalNumber);
        }

        public uint FinalNumber { get; set; }
        private List<int> fibonacciList;

        private List<int> createList(uint finalNum)
        {
            List<int> list = new List<int>();
            int first = 0;
            int second = 1;
            for (int i = 0; first <= finalNum; i++)
            {
                list.Add(first);
                int temp = first;
                first = second;
                second = temp + second;
            }
            return list;
        }
        public void Print()
        {
            foreach (var item in fibonacciList)
                Console.Write($"{item} ");
        }
        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in fibonacciList)
                yield return item;
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    }
}

