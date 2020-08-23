using System;
using System.Collections;
using System.Collections.Generic;

namespace Motivs.Tasks
{
    public class NaturalNumbers : IEnumerable<int>
    {
        public NaturalNumbers(uint finalNumber)
        {
            FinalNumber = finalNumber;
            naturalList = createList(finalNumber);
        }

        public uint FinalNumber { get; set; }
        private List<int> naturalList;

        private List<int> createList(uint finalNum)
        {
            List<int> list = new List<int>((int)finalNum);

            for (int i = 0; i <= finalNum; i++)
                list.Add(i);

            return list;
        }
        public void Print()
        {
            foreach (var item in naturalList)
                Console.Write($"{item} ");
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in naturalList)
                yield return item;
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
