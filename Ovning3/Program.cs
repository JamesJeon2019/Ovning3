using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ovning3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person();

                      
            PersonHandler person = new PersonHandler();

            List<Animal> animals = new List<Animal>(3);
            //animals.Add("Tom");
            //animals.Add(3);
            //animals.Add(10);
            animals.Add(new Animal() { Name="dog" });
            animals.Add(new Animal() { Name="horse"});


            foreach (Animal an in animals)
            {
                Console.WriteLine(an.Name);
               
            }

            //PropertyDescriptorCollection props = TypeDescriptor.GetProperties(proper);

            //foreach (PropertyDescriptor pd in props)

            //{
            //    Console.WriteLine(pd.DisplayName, pd.DisplayAge, pd.DisplayWeight,);

            //}

            // 3. Skapa en lista ​Animals ​ i program.cs som tar emot djur.  

            // 4. Skapa några djur (av olika typ) i din lista.  

            //  5. Skriv ut vilka djur som finns i listan med hjälp av en ​foreach-loop

        }

        List<UserError> text = new List<UserError>();

        text.Add(new UserError() { Mie = 1 });
           
    }
}
//  polymorfism låter oss definiera ett interface och ha flera implementationer.
// Interface kan ses som ett specialfall av abstrakta klasser. Dessa innehåller 
// enbart definitioner av metoder, och ingen implementering alls
//hhh