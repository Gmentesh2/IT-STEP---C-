using System;

public class Villain : Character
{	
	public int DarkAbility {  get; set; }
	public Villain(string name, int money , int health , int darkAbility) : base(name,money,health)
	{
		DarkAbility = darkAbility;
	}

	public override void Attack(Character opponent )
		{
        Console.WriteLine($"{Name} attacks {opponent.Name} with Dark Ability");
		opponent.Health -= DarkAbility;
        Console.WriteLine($"{opponent.Name}'s health reduced to {opponent.Health}");
		}



}
