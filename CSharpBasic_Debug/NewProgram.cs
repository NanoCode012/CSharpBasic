using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
	class NewProgram//fixed problem in OldProgram
	{
		public static void Main(string[] args)
		{
			var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

			foreach (var number in smallests)
				Console.WriteLine(number);
		}

		public static List<int> GetSmallests(List<int> list, int count)
		{
			if (list == null)//defensive programming, in case list is null
            {
                throw new ArgumentNullException(nameof(list), "list cannot be null");
            }
            if (count > list.Count || count <= 0)//defensive programming, in case count isn't within range
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count " +
                                                      "needs to be between 1 and " +
                                                      "number of elements in list");
            }
            var buffer = new List<int>(list);//create new list, so previous list 
                                             //wouldn't be changed, no side effect
			var smallests = new List<int>();

			while (smallests.Count < count)
			{
                var min = GetSmallest(buffer);
				smallests.Add(min);
                buffer.Remove(min);
			}

			return smallests;
		}

		public static int GetSmallest(List<int> list)
		{
			// Assume the first number is the smallest
			var min = list[0];
			for (var i = 1; i < list.Count; i++)
			{
				if (list[i] < min)
					min = list[i];
			}
			return min;
		}
	}
}
