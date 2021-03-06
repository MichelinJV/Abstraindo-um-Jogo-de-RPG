namespace rpg.src.Entities
{
    public class Ninja: Hero
    {
        public Ninja(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
        }

        public string Attack(int Skill)
        {
            switch(Skill){
                case 1: return this.Name + " Usou um ninjutsu!";
                
                case 2: return this.Name + " Usou um genjutsu!";
                
                case 3: return this.Name + " Usou um taijutsu!";
                
                default: return this.Name + " Falhou em atacar";
            }
            
        }
    }
}