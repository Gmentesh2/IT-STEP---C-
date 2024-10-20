using System;

public class Character
{
	public string Name { get; set; }
	public int Money { get; set; }
	public int Health { get; set; }



	public Character(string name, int money, int health)
	{
		Name = name;
		Money = money;
		Health = health;
	}

	public virtual void Attack(Character opponent )
		{

		}


}
