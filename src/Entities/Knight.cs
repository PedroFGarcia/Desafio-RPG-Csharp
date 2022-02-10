namespace Desafio_RPG_CSharp.src
{
    public class Knight : Hero
    {
        public Knight(string Name, int level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }


        public override string Attack()
        {
            return this.Name + " atacou com sua espada";
        }

        public override string ToString()
        {
            return this.Name + " tem " + this.HP + " pontos vida " + "e " + this.MP + " pontos de magia";
        }


        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " atacou com bonus de estamina de " + Bonus;
            } else{
                return this.Name + " atacou com pouca estamina";
            }
        }
    }
}