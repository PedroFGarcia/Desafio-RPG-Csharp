namespace Desafio_RPG_CSharp.src
{
    public abstract class Hero
    {
        public Hero(string Name, int level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public Hero(){

        }

        public string Name;
        public int level;
        public string HeroType;
        public int HP;
        public int MP;

        public override string ToString()
        {
            return this.Name + " " + this.level + " " + this.HeroType + " " + this.HP + " " + this.MP;
        }

        public virtual string Attack()
        {
            return this.Name;
        }

    }
}

