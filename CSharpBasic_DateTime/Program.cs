using System;

namespace CSharpBasic_DateTime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //DateTime
            //dateTime objects are immutable
            var dateTime = new DateTime(2017, 09, 12);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("now.Day : " +now.Day);
            Console.WriteLine("now.Hour : " +now.Hour);
            Console.WriteLine("now.Minute : " +now.Minute);

            now = now.AddDays(1);//another instance is created per modification
            Console.WriteLine("now.Day : " +now.Day);
            now = now.AddHours(-90);
            Console.WriteLine("now.Day : " +now.Day);

            Console.WriteLine("today longDate : " + today.ToLongDateString());
            Console.WriteLine("today shortDate : " + today.ToShortDateString());
            Console.WriteLine("today longTime : " + today.ToLongTimeString());//time is default
                                                                            //cuz DateTime.Today
                                                                            //only set date
            Console.WriteLine("today shortTime : " + today.ToShortTimeString());
            Console.WriteLine("today DateTime : " + today.ToString("dd-MM-yyyy HH:mm"));

            //TimeSpan
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);//for specific control, use this
            var timeSpan2 = TimeSpan.FromHours(1);//for readability, use this one

            var start = DateTime.Now;
            var end = start.AddHours(4);
            var duration = end - start;//returns a TimeSpan
            Console.WriteLine("duration : " + duration);

            Console.WriteLine("minutes : " + timeSpan.Minutes);
            Console.WriteLine("totalMinutes : " + timeSpan.TotalMinutes);

            var duration2 = timeSpan.Add(duration);
            var duration3 = timeSpan.Add(-duration);
            Console.WriteLine("duration2 : " +duration2);
            Console.WriteLine("duration3 : " + duration3);

            Console.WriteLine("timeSpan.ToString : " +timeSpan.ToString());//not necessarily
                                                                           //need ToString, cuz
                                                                           //WrileLine does that automatically
            Console.WriteLine("timeSpan.Parse : " + TimeSpan.Parse("5:30").ToString());


        }
    }
}
