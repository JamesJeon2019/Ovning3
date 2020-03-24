namespace Ovning3
{
    class Hedgehog : Animal
    {

        public override void Stats()
        {
            Name = "hedgehok";
            Age = 3;
            Weight = 1;

            return;
        }
        public int NrOfSpikes { get; set; }
    }
}
