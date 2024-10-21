using System;
public class Character
    {
    public string Name { get; set; }
    public int Money { get; set; }
    public int Health { get; set; }
    public Weapon EquippedWeapon { get; set; }

    public Character( string name, int money, int health )
        {
        Name = name;
        Money = money;
        Health = health;
        EquippedWeapon = null;
        }

    public virtual void Attack( Character opponent )
        {
        if (opponent == null)
            {
            Console.WriteLine($"{Name} has no one to attack.");
            return;
            }

      
        int damage = EquippedWeapon != null ? EquippedWeapon.Damage : 10;

       
        Console.WriteLine($"{Name} attacks {opponent.Name} with {EquippedWeapon?.Name ?? "bare hands"}, dealing {damage} damage!");
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

    public void BuyWeapon( Weapon weapon )
        {
        if (Money >= weapon.Price)
            {
            Money -= weapon.Price;
            EquippedWeapon = weapon;
            Console.WriteLine($"{Name} bought a {weapon.Name} for {weapon.Price} money.");
            }
        else
            {
            Console.WriteLine($"{Name} doesn't have enough money to buy {weapon.Name}.");
            }
        }
    }