namespace Ovning3
{
   class Worm : Animal
    {
        public override void Stats()
        {

            Name = "worm";
            Age = 3;
            Weight = 5;
            return;
        }
        public bool IsPoisonous { get; set; } 


    }
}
