using System.Collections.Generic;

namespace RPG_characterGenerator
{
    internal class Player
    {
        private string Name { get; set; }
        private int Strength { get; set; }
        private int Intelligence { get; set; }

        public Player(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + ", Strength: " + this.Strength + ", IQ: " + this.Intelligence;
        }
    }

    class Fighter : Player
    {
        private string Armor { get; set; }
        List<SpecialAttack> SpecialAttacks { get; set; }
        public Fighter(string n, int s, int i, string armor) : base(n, s, i)
        {
            Armor = armor;
        }

        public string GetArmor()
        {
            return this.Armor;
        }

    }

    class Wizard : Player
    {
        private string Mana { get; set; }
        public Wizard(string n, int s, int i, string mana) : base(n, s, i)
        {
            Mana = mana;
        }

        public string GetMana()
        {
            return this.Mana;
        }


    }



}
