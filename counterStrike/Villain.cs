using System;

public class Villain : Character
    {
    public int DarkAbility { get; set; }

    public Villain( string name, int money, int health, int darkAbility ) : base(name, money, health)
        {
        DarkAbility = darkAbility;
        }

    public override void Attack( Character opponent )
        {
      
        if (opponent == null)
            {
            Console.WriteLine($"{Name} has no one to attack.");
            return;
            }

        int damage = EquippedWeapon != null ? EquippedWeapon.Damage : DarkAbility;

        Console.WriteLine($"{Name} attacks {opponent.Name} with Dark Ability, dealing {damage} damage!");
        opponent.Health -= damage;

        if (opponent.Health <= 0)
            {
            Console.WriteLine($"{opponent.Name} has been defeated!");
            }
        else
            {
            Console.WriteLine($"{opponent.Name}'s health reduced to {opponent.Health}.");
            }
        }
    }