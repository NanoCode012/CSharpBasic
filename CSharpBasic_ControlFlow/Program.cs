using System;

namespace CSharpBasic_ControlFlow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // if/else
            int time = 12;//24hour format
			if (time>5 && time<12)
            {
                Console.WriteLine("Rise and Shine!");
            }
            else if (time>12 && time<18)
            {
                Console.WriteLine("Top to the morning to ya!");
            }
            else if (time>18 && time <24)
            {
                Console.WriteLine("You snooze, you lose!");
            }
            else if (time>0 && time<5)
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
			Console.WriteLine("using if, price is " +price);
            int price2 = 39;
            //() inside is condition, ? is if, : is else
            int price3 = (isVip) ? price2 : (price2+markdown);
            Console.WriteLine("using conditional operators price3 is " +price3);
            // switch/case
            Seasons season = Seasons.Spring;
            float hungerLevel;
            switch(season)
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
                default:
                    hungerLevel = 0.5f;
                    break;
            }
            Console.WriteLine(hungerLevel);
            switch(time)//just the same as FEASTING V1, but with switch
            {
                case 6:
                case 12:
                case 18:
                    Console.WriteLine("FEASTING V2!");
                    break;
            }

            //Construct and start Example.cs
            Examples example = new Examples();
            example.Reveal();//Starts method in another class

        }
	}
}
