namespace Classes_Structs_OOP
{
    public class Character
    {
        public string name;
        public int exp = 0;

        //test
        //private string nickname;

        public Character()
        { 
            Reset();
        }

        public Character(string name)
        {
            this.name = name;
        }

        public void PrintStatsInfo()
        {
            //test
            //this.nickname = "Billy";

            Console.WriteLine("Hero: " + this.name + " - " +this.exp + " EXP");
        }

        //encapsulation example - can't access private method outside of class
        private void Reset()
        {
            this.name = "Not assigned";
            this.exp = 0;
        }
    }

    //inheritance
    public class Paladin: Character
    {
        //composition
        public Weapon weapon;
        public Paladin(string name, Weapon weapon) : base(name)
        {
            this.name = name;
            this.weapon = weapon;
        }
    }

    public struct Weapon 
    {
        public string name;
        public int damage;

        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;   
        }

        public void PrintWeaponStats()
        {
            Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            hero.PrintStatsInfo();

            Character heroine = new Character("Agatha");
            heroine.PrintStatsInfo();

            //testing reference types
            Character villain = hero;
            villain.name = "Sir Kane the Brave";
            hero.PrintStatsInfo();
            villain.PrintStatsInfo();

            Weapon huntingBow = new Weapon("Hunting Bow", 150);
            huntingBow.PrintWeaponStats();

            //testing value types
            Weapon crossbow = huntingBow;
            crossbow.name = "crossbow";
            crossbow.damage = 250;
            huntingBow.PrintWeaponStats();
            crossbow.PrintWeaponStats();

            Paladin knight = new Paladin("Sir Arthur", huntingBow);
            knight.PrintStatsInfo();
        }
    }
}
