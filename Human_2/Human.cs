using System;

namespace Human_2
{
    class Human
    {
        public string Name;
        public int Strength = 3;
        public int Intelligence = 3;
        public int Dexterity = 3;
        public int Health = 100;
        public Human(string name)
        {
            Name = name;
        }
        public Human(string name, int str, int intell, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intell;
            Dexterity = dex;
            Health = hp;
        }
        public void Attack(object humans)
        {
            Human enemy = humans as Human;
            if(enemy != null){
                enemy.Health -= 5 * Strength;
            }
        }
    }
}