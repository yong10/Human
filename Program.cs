using System;

namespace Human
{
    class Human
    {
        public string Name;
        public int Strength = 3; 
        public int Intelligence = 3;
        public int Dexterity = 3;
        private int Health = 100;

        public int health
        {
            get {
                return Health;
                }
        }
        public Human(string name)
        {
            Name = name;
            
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health) :this(name)
        {
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        public void Attack(Object target)
        {
            var Tar = (Human) target;
            Tar.Health -= 5 * Dexterity;
            Console.WriteLine($"{Tar.Name} got attacked by enemy and lost {5 * Dexterity} from one's Health!");
            Console.WriteLine($"Current Target's Stats: " + Tar.ToString() );
            
        }
        public override string ToString()
        {
            return 
                $"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {Health}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Human("Attacker");
            var player2 = new Human("Defender", 10, 50, 5, 100);
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            player1.Attack(player2);
            
        }
    }
}