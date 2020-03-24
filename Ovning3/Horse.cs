namespace Ovning3
{
    class Horse : Animal
    {
        public override void Stats()
        {
            Name = "horse";
            Age = 3;
            Weight = 45;
             return;
        }
        
            //  2. Skriv en ​override ​ för ​Stats() ​i Subklasserna för ​Animal ​ 
            //så den returnerar alla ​properties ​ för  det djuret.  

            // 5. Ge dessa minst en unik ​egenskap ​ var. 
            //Vilken egenskap det är är inte det viktiga här.  Exempel ​Worm ​ ​IsPoisonous, 

            public string HorseBreed { get; set; }
    }    


}
