using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS_Learning.Linq
{
    internal class LinqExercise
    {
        public static void Run()
        {
            List<int> myList = new List<int>() { 12,5,7,23,22,5};
            int sum = 0;
            foreach(int i in myList)
            {
                sum = sum + i;
            }
            double average = sum / myList.Count;

            var result = myList.Where(n => n > average).ToList();
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
            // sadece int yaparsam tek bir sayi olur var veya List<int> yapmam gerekiyor
            Console.WriteLine("------------------");
            Console.WriteLine("SmallerNumbers");
            List<int> SmallNumbers = myList.Where(n => n < myList[3]).ToList();
            for(int i = 0; i < SmallNumbers.Count; i++)
            {
                Console.Write($"{SmallNumbers[i]} -- ");
            }
        }
        // ie numerable bu nesnenin elemanlari uzerinde gezebilirsin demek
        // yanindaki int de  nesnenin uzerinde gezerken elde edecegin elemanlar
        static void ListWriter(IEnumerable<int> arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{ i}--");
            }
        }
    }

}
