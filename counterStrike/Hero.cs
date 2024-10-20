using System;

public class Hero : Character
{
	public int LightAbility { get; set; }

	public Hero(string name, int money, int health, int lightAbility) : base(name,money,health)
	{
		LightAbility = lightAbility;
	}

	public override void Attack(Character opponent )
		{
        Console.WriteLine($"{Name} attacks {opponent.Name} with Light Ability");
		opponent.Health -= LightAbility;
        Console.WriteLine($"{opponent.Name}'s health reduced to {opponent.Health}");
		}

	public void Heal(Hero ally, int healAmount )
		{
		if(healAmount <= Health)
			{
            Console.WriteLine($"{Name} heals {ally.Name} for {healAmount} health");
			ally.Health += healAmount;
			Health -= healAmount;
            Console.WriteLine($"{ally.Name}'s health increased to {ally.Health}");
            Console.WriteLine($"{Name}'s health redused to {Health}");
			}
		else
			{
            Console.WriteLine($"{Name} doesn't have enough heal;th to heal");
			}
		}



}
