using System;

public class Weapon
    {
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Price { get; set; }

    public Weapon( string name, int damage, int price )
        {
        Name = name;
        Damage = damage;
        Price = price;
        }
    }