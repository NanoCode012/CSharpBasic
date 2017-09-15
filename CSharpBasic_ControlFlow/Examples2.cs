using System;
using System.Linq;

namespace CSharpBasic_ControlFlow
{
    class Examples2
    {
        ///<summary>
        ///Write a program to count how many numbers between 1 and 100 are 
        ///divisible by 3 with no remainder. Display the count on the console.
        ///</summary>
        public void Mission1()
        {
            var divisibleCounter = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    divisibleCounter++;
                    Console.WriteLine(i + " is divisible by 3");
                }
            }
            Console.WriteLine(divisibleCounter + " are the numbers that have 3 as a LCM");
            Console.WriteLine("{0} numbers have a LCM of 3", divisibleCounter);
            //used String.Format() for more readability
        }
        ///<summary>
        ///Write a program and continuously ask the user to enter a number or 
        ///"ok" to exit. Calculate the sum of all the previously entered 
        ///numbers and display it on the console.
        ///</summary>
        public void Mission2()
        {
            int total = 0;
            while (true)
            {
                Console.WriteLine("Please input number(ok to exit) : ");
                var input = Console.ReadLine();
                if (input.ToLower() != "ok") //ToLower to account for Ok or OK or oK
                {
                    Console.WriteLine("@Admin : You inputted " + Convert.ToInt32(input));
                    total += Convert.ToInt32(input);
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("total is " + total);
        }

		///<summary>
		///Write a program and ask the user to enter a number. Compute the 
        ///factorial of the number and print it on the console. For example, 
        ///if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        ///and display it as 5! = 120.
		///</summary>
		public void Mission3()
        {
            Console.WriteLine("Please enter a natural number : ");
            var input2 = Convert.ToInt32(Console.ReadLine());
            double factorial = 1;//use double because have largest range
            for (var i = input2; i > 1; i--)//use Decrement is more challenging
            {
                factorial *= i;
            }
            Console.WriteLine(input2 + "! = " + factorial);//Can use String.Format() here
        }

		///<summary>
		///Write a program that picks a random number between 1 and 10. Give 
        ///the user 4 chances to guess the number. If the user guesses the 
        ///number, display “You won"; otherwise, display “You lost". (To make 
        ///sure the program is behaving correctly, you can display the secret 
        ///number on the console first.)
		///</summary>
		public void Mission4()
        {
            var random = new Random();
            var secretNumber = random.Next(1,11);
            var amountTries = 4;
            Console.WriteLine("Try guess my secretNumber ");
            //Console.WriteLine("secretNumber is " + secretNumber);debug
            for (var i = amountTries; i > 0;i--)
            {
                var input3 = Convert.ToInt32(Console.ReadLine());
                if (input3 == secretNumber)
                {
                    Console.WriteLine("Yes! Yo, God!");
                    break;
                }
                if (i-1 != 0)
                {
                    Console.WriteLine("Nope! Try again! You have " + (i-1)
                                      + " tries left.");
                }
                else
                {
                    Console.WriteLine("You Lose!");
                }
            }
        }

        ///<summary>
        ///Write a program and ask the user to enter a series of numbers 
        ///separated by comma. Find the maximum of the numbers and display it 
        ///on the console. For example, if the user enters “5, 3, 8, 1, 4", the 
        ///program should display 8.
        ///</summary>
        public void Mission5()
        {
            Console.WriteLine("Please enter an array of numbers(use comma to seperate) :");
            var lineList = Console.ReadLine();
			//var lineString = System.Text.RegularExpressions.Regex.Split(lineList, @"\W+");
            //or can use "using System.Text.RegularExpressions;" to shorten to Regex.Split()
			// \W+ is one or more non-word characters together
			var another = new char[] { ',', ' ' };
            var lineString = lineList.Split(another,StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("length is : " + lineString.Length);
            //String.Split is faster and efficient at shorter strings than Regex.Split
            //Regex.Split works better with longer strings
            var max = 0;
            for (var i = 0; i < lineString.Length-1; i++)//need -1 because if not, 
			{                                            //[i+1] will not work
				var a = Convert.ToInt32(lineString[i]);
                //Console.WriteLine("a : " +a);Debug
                var b = Convert.ToInt32(lineString[i + 1]);
                //Console.WriteLine("b : " +b);Debug
                if (a >= b)
                {
                    if (max <= a)
                    {
						max = a;                  
                    }
                }else{
                    if (max <= b)
                    {
						max = b;                  
                    }
                }
                //Console.WriteLine("Temp max is : " + max);Debug

            }
            Console.WriteLine("max is : " + max);
			var highest = lineString.Max();//This also work, must simpler too
                                           //uses "using System.Linq;"
            Console.WriteLine("highest is : " + highest);
            //the below method seems to be much simpler in logic, and faster
            var max2 = lineString[0];
            foreach (var number in lineString)
            {
                if (Convert.ToInt32(max2) < Convert.ToInt32(number))
                {
                    max2 = number;
                }
            }
            Console.WriteLine("max2 is : " + max2);

        }

    }
}
