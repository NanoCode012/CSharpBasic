using System;
namespace CSharpBasic_ControlFlow
{
    class Examples
    {

		///<summary>
		///Goal: Get used to function of Input of Console for c#</summary>
		public void Reveal()
        {
			Console.WriteLine("==========================");
            ConsoleKeyInfo state = Console.ReadKey();//I have no idea how this works
            if (state.Key == ConsoleKey.Enter)//scan per letter?
            {
                Console.WriteLine("Enter pressed!");
            }
            else Console.ReadLine();
            Mission1();
        }

		///<summary>
		///Goal: Write a program and ask the user to enter a number. The 
		///number should be between 1 to 10. If the user enters a valid number, 
		///display "Valid" on the console. Otherwise, display "Invalid".</summary>
		public void Mission1()
        {
			Console.WriteLine("Press a number between 1->10.");
            var numberEntered = Console.ReadLine();
            if (Convert.ToInt32(numberEntered) < 0 ||
                Convert.ToInt32(numberEntered) > 10)
			{
				Console.WriteLine("Error! Not within specified range!");
			}
			else
			{
				Console.WriteLine("Thank yoU! You pressed on " +numberEntered);
			}
            Mission2();

        }

		///<summary>
		///Goal: Write a program which takes two numbers from the console and 
		///displays the maximum of the two.</summary>
		public void Mission2()
        {
			Console.WriteLine("Please type one number, press enter and repeat once");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
			var secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber>secondNumber)
            {
                Console.WriteLine(firstNumber + " is bigger");
            }else
            {
                Console.WriteLine(secondNumber + " is bigger");
            }
            Mission3();
		}

		///<summary>
		///Goal:  Write a program and ask the user to enter the width and 
		///height of an image. Then tell if the image is landscape or portrait.</summary>
		public void Mission3()
        {
			Console.WriteLine("Image properties identifier. Please enter width");
            var width = Console.ReadLine();
            Console.WriteLine("Now please enter height");
            var height = Console.ReadLine();
            Orientation orientation;
            if (Convert.ToInt32(width)>Convert.ToInt32(height))
            {
                orientation = Orientation.Landscape;
            }else
            {
                orientation = Orientation.Portrait;
            }
            Console.WriteLine("This picture is in " + orientation);
            Mission4();
		}
        enum Orientation
        {
            Landscape,
            Portrait
        }

		///<summary>
		///Goal: Your job is to write a program for a speed camera. For 
		///simplicity, ignore the details such as camera, sensors, etc and 
		///focus purely on the logic. Write a program that asks the user to 
		///enter the speed limit. Once set, the program asks for the speed 
		///of a car. If the user enters a value less than the speed limit, 
		///program should display Ok on the console. If the value is above 
		///the speed limit, the program should calculate the number of demerit
		///points. For every 5km/hr above the speed limit, 1 demerit points 
		///should be incurred and displayed on the console. If the number of 
		///demerit points is above 12, the program should display License 
		///Suspended.</summary>
		public void Mission4()
        {
			Console.WriteLine("Catch you Now");
            Console.WriteLine("Please enter speed limit of road");
            var limitSpeed = Console.ReadLine();
            Console.WriteLine("Please enter your speed");
            var currentSpeed = Console.ReadLine();
            if (Convert.ToInt32(currentSpeed)>=Convert.ToInt32(limitSpeed))
            {
                Console.WriteLine("Warning! You're over limit! SlowDown!!");
                Console.WriteLine("Calculating points deduction...");
                Console.ReadLine();
                const int kmperpoints = 5;
                float points = (Convert.ToInt32(currentSpeed) 
                                - Convert.ToInt32(limitSpeed)) / kmperpoints;
                if (points < 1.0f)
                {
                    Console.WriteLine("You were warned! Don't do it again!");
                }else if (points >= 1.0f && points < 12.0f)
                {
                    Console.WriteLine("You have now been deducted " + points);
                }else if (points >= 12.0f)
                {
                    Console.WriteLine("License Rescended");
                }
            }else Console.WriteLine("You pass. Thx for obeying the law!");
        }
    }
}
        