using System;

namespace CSharpBasic_PrimitivetypesExpression
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            //Declare primitive types
            byte Number = 9;
            short Hell = 22222;
            float Duck = 2.98f;
            char Let = 'P';
            string Book = "Do me a favor \n ?";
            bool Happy = false;

            Console.WriteLine("Number :" +Number);
            Console.WriteLine("Hell :" +Hell);
            Console.WriteLine("Duck :" +Duck);
            Console.WriteLine("Let :" +Let);
            Console.WriteLine("Book :" +Book);
            Console.WriteLine("Happy :" +Happy);
			Console.WriteLine("Hello World!");

            //This is a string format {arg#}
            Console.WriteLine("Byte range :{0}->{1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Float range :{0}->{1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Double range :{0}->{1}", double.MinValue, double.MaxValue);

            //Constants
            const float Pi = 3.14f;
            Console.WriteLine(FindArea(4));
            float FindArea(float radius)//this works :P
                                        //check enscapulation, this method only 
                                        //allowed in Main() method
			{
				float a;
				a = Pi * (radius * radius);
				return a;
			}

            //Implicit type conversion
            byte b = 1; //1 byte = 8 bit 
            int i = b; //integer = 4 bytes = 32 bit hence Int32
            Console.WriteLine("i : " +i);//no data loss

            //Explicit type conversion using cast
            int i2 = 1000;
            byte b2 = (byte)i2;
            Console.WriteLine("b2 : " +b2);//has data loss, check bit conversion

            //Conversion between non-compatible types
            string s = "50";
            int i3 = Convert.ToInt32(s);
            Console.WriteLine("i3 : " +i3);
            string s2 = "true";
            bool B = Convert.ToBoolean(s2);
            Console.WriteLine(B);

            //Exception handling, so if it 'catches' an exeption in try block,
            //it will run the 'catch' block respectively
            try
            {
				string s3 = "1000";
				byte b3 = Convert.ToByte(s3);
				Console.WriteLine("b3 : " + b3);
            }
            catch (Exception)
            {
                Console.WriteLine(  "An error occured. The number didn't "
                                  + "fit the given range"); //seperate to fit
            }

            //Logical Operators
            byte b4 = 12;
            byte b5 = 6;
            byte b6 = 18;

            Console.WriteLine("b4 : " +b4);
            Console.WriteLine("b5 : " + b5);
            Console.WriteLine("b6 : " + b6);
            Console.WriteLine("b4+b5 : " + (b4+b5));
            Console.WriteLine("b4-b5 : " + (b4-b5));
            Console.WriteLine("b4*b5 : " + (b4*b5));
            Console.WriteLine("b4/b5 : " + (b4/b5));
            Console.WriteLine("b4>b5 : " + (b4 > b5));
            Console.WriteLine("b4==b5 : " + (b4 == b5));
            Console.WriteLine("b4!=b5 : " + (b4 != b5 ));
            Console.WriteLine("b6>b4 && b6>b5 : " + (b6 > b4 && b6 > b5));
            Console.WriteLine("b6>b4 && b6==b5 : " + (b6 > b4 && b6 == b5));
            Console.WriteLine("b6>b4 || b6==b5 : " + (b6 > b4 || b6 == b5));
            Console.WriteLine("!(b6>b4 || b6==b5) : " + !(b6 > b4 || b6 == b5));
        }
    }
}
