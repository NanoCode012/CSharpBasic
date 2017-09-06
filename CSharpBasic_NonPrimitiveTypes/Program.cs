﻿using CSharpBasic_NonPrimitiveTypes.Math;
using static System.Console; //suggested by Intellisense(IS)


namespace CSharpBasic_NonPrimitiveTypes
{
	enum ShippingMethods
	{
		WeGo = 0,
		Nuggat = 1,
		NotsoFast = 2
	}
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Initiate object 'john'. Can use var, cuz Intellisense(IS)
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Nodes";
            john.Introduce();
            WriteLine(Calculator.Add(4, 8));

            //Arrays
            int[] numbers = { 0, 1, 2 };    //<- this is simplified version of
                                            //int[] a = new int[#];
            WriteLine(numbers[0]);
            WriteLine(numbers[1]);
            WriteLine(numbers[2]);
            var name = new string[3];
            name[0] = "Melly";
            name[1] = "Boon";
            WriteLine(name[0]);
            WriteLine(name[1]);
            WriteLine(name[2]);
            var isDone = new bool[3];
            isDone[0] = true;
            WriteLine(isDone[0]);
            WriteLine(isDone[1]);
            WriteLine(isDone[2]);

            //Strings
            var firstName = "Lazzy";
            var lastName = "Tools";
            var fullName = firstName + " " + lastName;//contaconation
            var myFullName = string.Format("Name is {0} {1}", firstName, lastName);//format string
            var names = new string[2] { firstName, lastName };
            var newFullName = string.Join(", ", names);//seperator string
            WriteLine(fullName);
            WriteLine(myFullName);
            WriteLine(newFullName);
            var verbatimString =
@"Look into the following path.
D:\folder9\folder10."; //use @ sign to render escape signs useless
            WriteLine(verbatimString);

            //Enums
            var deliver = ShippingMethods.WeGo;
            WriteLine((int)deliver);
            var deliveryID = 2;
            WriteLine((ShippingMethods)deliveryID);//Cast, change int to enum
            WriteLine(CheckExit(2));//this works too!
            WriteLine(System.Convert.ToString(deliver));//Change enum to string
            WriteLine(deliver.ToString());//Same as above, without System namespace
            //Parse from string to enum
            var deliverName = "Nuggat";
            var DeliverName = (ShippingMethods)System.Enum.Parse(typeof(ShippingMethods), deliverName);
            WriteLine(DeliverName);

            //Reference types(class) and Value types(struct)
            var a = 10;//primitive types are struct
            var c = a;//value is copied
			c++;
            WriteLine(string.Format("{0} {1}", a, c));
            int[] array1 = { 5, 6, 7 };//arrays are classes
            var array2 = array1;//reference point is copied
			array2[1] = 0;
            WriteLine("{0} {1}", array1[1], array2[1]);

            var number = 3;
            IncreaseByTen(number);
            WriteLine(number);
            var car = new Car() { Age = 5 };
            Oldify(car);
            WriteLine(car.Age.ToString());
        }

        public static void IncreaseByTen(int number)//testing with value types
        {
            number += 10;
        }
        public static void Oldify(Car car)  //testing with reference types
        {                                   //Car is class, reference point for 
            car.Age += 20;                  //object 'car' is copied
        }

        //Apparently, not the same topic, should I move?
        public static ShippingMethods CheckExit(int a)
        {
            ShippingMethods typo;
            switch (a)
            {
                case 0:
                    typo = ShippingMethods.WeGo;
                    break;
                case 1:
                    typo = ShippingMethods.Nuggat;
                    break;
                case 2:
                    typo = ShippingMethods.NotsoFast;
                    break;
                default:
                    typo = ShippingMethods.WeGo;
                    break;
            }
            return typo;
        }




    }

	public class Point
	{
		public int X;
		public int Y;
	}

	public class Car
    {
        public int Age;
    }

}
