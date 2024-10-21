using System;

public class Hero : Character
    {
    public int LightAbility { get; set; }

    public Hero( string name, int money, int health, int lightAbility ) : base(name, money, health)
        {
        LightAbility = lightAbility;
        }

    public override void Attack( Character opponent )
        {
       
        if (opponent == null)
            {
            Console.WriteLine($"{Name} has no one to attack.");
            return;
            }

       
        int damage = EquippedWeapon != null ? EquippedWeapon.Damage : LightAbility;

        Console.WriteLine($"{Name} attacks {opponent.Name} with Light Ability, dealing {damage} damage!");
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

    public void Heal( Character ally, int healAmount )
        {
        if (ally == null)
            {
            Console.WriteLine($"{Name} has no ally to heal.");
            return;
            }

        if (healAmount <= Health)
            {
            ally.Health += healAmount;
            Health -= healAmount;

            Console.WriteLine($"{Name} heals {ally.Name} for {healAmount} health.");
            Console.WriteLine($"{ally.Name}'s health increased to {ally.Health}.");
            Console.WriteLine($"{Name}'s health reduced to {Health}.");
            }
        else
            {
            Console.WriteLine($"{Name} doesn't have enough health to heal.");
            }
        }
    }
