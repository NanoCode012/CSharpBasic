using System;

namespace CSharpBasic_NonPrimitiveTypes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + FirstName + " " + LastName);
        }

    }


}
