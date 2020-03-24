
using System;
using System.Collections.Generic;

namespace Ovning3
{
    internal class Dog : Animal
    {
        public string bark = "hav_hav   ";
      public override void Stats()
        {

            Name = "dog";
            Age = 3;
            Weight = 45;
            return ;
        }

        List<Dog> dogs = new List<Dog>(3);
       
        dogs.Add(new Dog() { Name = "dog1" });
        dogs.Add(new Dog() { Name = "dog2" });
        dogs.Add(new Dog() { Name = "dog3" });
        dogs.Add(new Horse() { Name = "horse1" });    //7. F: Försök att lägga till en häst i listan av hundar.Varför fungerar inte det?
           
        // F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans? 

            foreach (Dog d in dogs)
            {
                Console.WriteLine(d.Name);
            }
    public  string SomeMethod()
    {
      Animal  Name = "dog5";
        return Name;
    }

    }

}
