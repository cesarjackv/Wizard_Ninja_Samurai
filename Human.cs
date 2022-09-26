﻿public class Human{
    // Properties for Human
    public string Name {get; set;}
    public int Strength {get; set;}
    public int Intelligence {get; set;}
    public int Dexterity {get; set;}
    public int Health {get; set;}
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    private Human(string name){
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    // Add a constructor to assign custom values to all fields
    public Human(string name, int str, int intel, int dex, int hp){
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
    }
    
    // Build Attack method
    public virtual int Attack(Human target){
        int dmg = Strength * 3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
}

