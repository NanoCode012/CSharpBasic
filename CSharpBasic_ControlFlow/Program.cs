﻿using System;

namespace CSharpBasic_ControlFlow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // if/else
            int time = 12;//24hour format
            if (time > 5 && time < 12)
            {
                Console.WriteLine("Rise and Shine!");
            }
            else if (time > 12 && time < 18)
            {
                Console.WriteLine("Top to the morning to ya!");
            }
            else if (time > 18 && time < 24)
            {
                Console.WriteLine("You snooze, you lose!");
            }
            else if (time > 0 && time < 5)
            {
                Console.WriteLine("Why! Are! You! Still! Up?!");
            }
            if (time == 5 || time == 12 || time == 18)//check out FEASTING V2
            {
                Console.WriteLine("FEASTING TIME!");
            }
            bool isVip = false;
            int markdown = 10;
            int price = 18;
            if (!isVip)
            {
                price += markdown;
            }
            Console.WriteLine("using if, price is " + price);
            int price2 = 39;
            //() inside is condition, ? is if, : is else
            int price3 = (isVip) ? price2 : (price2 + markdown);
            Console.WriteLine("using conditional operators price3 is " + price3);

            // switch/case
            Seasons season = Seasons.Spring; //declare enum from different script
            float hungerLevel = 0f;
            switch (season)
            {
                case Seasons.Spring:
                    hungerLevel = 0.4f;
                    break;
                case Seasons.Summer:
                    hungerLevel = 0.3f;
                    break;
                case Seasons.Autumn:
                    hungerLevel = 0.7f;
                    break;
                case Seasons.Winter:
                    hungerLevel = 0.9f;
                    break;
            }
            Console.WriteLine(hungerLevel);
            switch (time)//just the same as FEASTING V1, but using switch
            {
                case 6:
                case 12:
                case 18:
                    Console.WriteLine("FEASTING V2!");
                    break;
            }

			//For loops
			for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)//very useful to remember for later
                {
                    Console.WriteLine("This is an even number " + i);
                }
                else
                {
                    Console.WriteLine("This is an odd number " + i);
                }
            }
            for (var i = 10; i >= 1; i--)//reverse of above
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("This is an even number " + i);
                }
                else
                {
                    Console.WriteLine("This is an odd number " + i);
                }
            }
            var herName = "Miserona";
            for (var i = 0; i < herName.Length; i++)
            {
                Console.WriteLine(herName[i]);
            }

            //Foreach loops
            var listNames = new string[4]
            {
                "Jold",
                "Per",
                "Tom",
                "Gir"
            };
            foreach (var name in listNames)
            {
                Console.WriteLine(name);
            }
            var hisName = "Laddy Hanks";
            foreach (var character in hisName)
            {
                if (character != ' ')//remember char is one quote
                {
                    Console.WriteLine(character);
                }
            }
            int[] listNumbers = { 10, 20, 30, 40 };
            foreach (var number in listNumbers)
            {
                Console.WriteLine(number);
			}

            //While loops
            var counter = 1;//same as first for loop
            while (counter <= 10)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("Even " + counter);
                }
                else
                {
                    Console.WriteLine("Odd " + counter);
                }
                counter++;
            }
            //this while loop below is purely experimental, I'm unsure if the method
            //used is recommeneded or not
            //ReadKey only reads one key, ReadLine reads a line
            while (true)
            {

                ConsoleKeyInfo keyPressed = new ConsoleKeyInfo();//don't forget to do this
                keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.Enter)
                {
                    break;
                }
                Console.WriteLine();//to skip a line, make console more readable
                Console.WriteLine("You pressed on " + keyPressed.KeyChar);

                Console.Write("Type name : ");
                var inputName = Console.ReadLine();
                if (inputName == String.Empty)
                {
                    break;
                }
                Console.WriteLine("@Admin acc is " + inputName);
                Console.Write("Type your pw : ");
                var inputPw = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(inputPw))
                {
                    Console.WriteLine("@Admin pw is " + inputPw);
                    continue; //goes to next loop directly
                }
                break;
            }

            //Random class
            const int loopLength = 5;
            var random = new Random();
            var arrayData = new int[loopLength];
            for (var i = 0; i < loopLength; i++)
            {
                arrayData[i] = random.Next();
                Console.WriteLine(i + " : " + arrayData[i]);
            }
            for (var i = 0; i < loopLength; i++)
            {
                Console.WriteLine(i + " : " + random.Next(1, 3));
            }
            var password = String.Empty;//Password generator
            for (var i = 0; i < loopLength; i++)
            {
                password += Convert.ToChar(random.Next(97, 123));
            }
            Console.WriteLine("1 : " + password);
            var password2 = String.Empty;//Another password generator
            for (var i = 0; i < loopLength; i++)
            {
                password2 += Convert.ToChar('a' + random.Next(0, 26));
            }
            Console.WriteLine("2 : " + password2);
            var password3 = new char[loopLength];
            for (var i = 0; i < loopLength; i++)
            {
                password3[i] = (char)('a' + random.Next(0, 26));
            }
            var password4 = String.Join("", password3);
            var password5 = new string(password3);
            Console.WriteLine("4 : " + password4);
            Console.WriteLine("5 : " + password5);

			///Constructor
			Examples examples = new Examples();//optional is to make Examples static
            //examples.Reveal();
    		//examples.Mission1();
    		//examples.Mission2();
    		//examples.Mission3();
    		//examples.Mission4();
			Examples2 examples2 = new Examples2();
			//examples2.Mission1();
            //examples2.Mission2();
            //examples2.Mission3();
            //examples2.Mission4();
            //examples2.Mission5();

		}
    }
}
