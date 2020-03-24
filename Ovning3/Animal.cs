using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ovning3
{
    class Animal
    {

        public int Age { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        //Animal proper = new Animal();

               public Animal()
        {
            
        }

       

        //9. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då? 
        //de samtliga egenskaper gällande djur måste vara i Animal 
        public abstract Animal ​Stats()
        {
            // Metoden ska returnera alla egenskaper (​properties) ​ som 
            //djuret har
            Animal proper = new Animal();

            Name = "Tom";
            Age = 3;
            Weight = 45;

            Console.WriteLine(Name,Age,Weight);

           
        return;
        }



    }
}
