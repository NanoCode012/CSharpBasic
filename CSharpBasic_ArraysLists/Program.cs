using System;
using System.Collections.Generic;

namespace CSharpBasic_ArraysLists
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Arrays
            int[] arrayNumbers = { 5, 18, 3, 9, 8, 55 };
            Console.WriteLine("Length of array : " + arrayNumbers.Length);
            Console.WriteLine("Index of 9 : " + Array.IndexOf(arrayNumbers, 9));
            Console.WriteLine("Index of 7 : " + Array.IndexOf(arrayNumbers, 7));
            //if does not exist like above, output is -1
            Array.Clear(arrayNumbers, 0, 3);
            Console.WriteLine("Cleared first 3 values");
            foreach (var number in arrayNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Copy() method");
            var arrayNumbers2 = new int[10];
            Array.Copy(arrayNumbers,arrayNumbers2,5);
            foreach (var number in arrayNumbers2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Sort from smallest to largest of first array");
            Array.Sort(arrayNumbers);
            foreach (var number in arrayNumbers)
            {
				Console.WriteLine(number);
			}
            Console.WriteLine("Sort in reverse");
            Array.Reverse(arrayNumbers);
			foreach (var number in arrayNumbers)
			{
				Console.WriteLine(number);
			}


            //Lists
            var listNumbers = new List<int> { 50, 60, 70, 80 };
            listNumbers.Add(100);
            listNumbers.AddRange(new int[] {5,70,8,70});
            Console.WriteLine("List list: ");
            foreach(var number in listNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Index of 70 : " + listNumbers.IndexOf(70));
            Console.WriteLine("Last index of 70 : " + listNumbers.LastIndexOf(70));
            Console.WriteLine("Count of objects : " + listNumbers.Count);
            listNumbers.Remove(70);//Only removes one of the 70
            Console.WriteLine("List after remove one 70 : ");
			foreach (var number in listNumbers)
			{
				Console.WriteLine(number);
			}
            for (var i = 0; i < listNumbers.Count; i++)//To remove all 70s
            {
                if (listNumbers[i] == 70)
                    listNumbers.Remove(listNumbers[i]);
            }
            Console.WriteLine("List after remove all 70 : ");
            foreach (var number in listNumbers)
            {
                Console.WriteLine(number);
            }
            listNumbers.Clear();
            Console.WriteLine("Count of objects : " + listNumbers.Count);

            ///Constructor
            Examples examples = new Examples();
            //examples.Mission1();
            //examples.Mission2();
            //examples.Mission3();
            //examples.Mission4();
            examples.Mission5();
        }
    }
}
