using System;

namespace ConsoleApplication.Class.ConstructorAndInheritance
{
    class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber) // im passing the registration number to the base class, If i'm not doing this the code is not compiled
        {
            Console.WriteLine($"Car is being initialized {registrationNumber}");
        }
    }
}
