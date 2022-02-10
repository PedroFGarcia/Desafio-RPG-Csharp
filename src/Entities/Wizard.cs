namespace Desafio_RPG_CSharp.src
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;

        }
        public override string Attack()
        {
            return this.Name + " lançou magia";
        }

        public override string ToString()
        {
            return this.Name + " tem " + this.HP + " pontos vida " + "e " + this.MP + " pontos de magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou magia com bonus de " + Bonus;
            } else{
                return this.Name + " lançou uma magia fraca com bonus de " + Bonus;
            }
        }
    }
}