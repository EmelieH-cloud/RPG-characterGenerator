using System;

namespace RPG_characterGenerator
{


    public class SpecialAttack
    {

        public string Name { get; set; }
        public Type type { get; set; }

        public SpecialAttack(string n, Type t)
        {
            Name = n;
            type = t;
        }

        SpecialAttack s1 = new SpecialAttack("Fireball", typeof(Wizard));
        SpecialAttack s2 = new SpecialAttack("Frostbolt", typeof(Wizard));
        SpecialAttack s3 = new SpecialAttack("Magic Missile", typeof(Wizard));

        SpecialAttack s4 = new SpecialAttack("Rage", typeof(Fighter));
        SpecialAttack s5 = new SpecialAttack("Charge", typeof(Fighter));
        SpecialAttack s6 = new SpecialAttack("Shield", typeof(Wizard));

        SpecialAttack s7 = new SpecialAttack("Jump", typeof(Player));
        SpecialAttack s8 = new SpecialAttack("Invisibility", typeof(Player));
        SpecialAttack s9 = new SpecialAttack("Stealth", typeof(Player));

    }


}