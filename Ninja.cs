public class Ninja : Human{

    public Ninja(string name) : base(name, 3, 3, 75, 100){
        Name = name;
    }

    public override int Attack(Human target){
        Random rand = new Random();
        int crit = 0;
        Dictionary<string, bool> execute = new Dictionary<string, bool>();
        if(rand.Next(6) == 5){
            crit = 10;
        }else{
            crit = 0;
        }
        int dmg = Dexterity + crit;
        if(target.Health > 0){
            if(!execute.ContainsKey($"{target.Name}")){
                execute.Add($"{target.Name}", false);
            }
            if(dmg < target.Health){
                target.Health -= dmg;
            }else{
                target.Health = 0;
                Console.WriteLine("FINISH HIM!");
            }
        }else{
            if(execute[$"{target.Name}"] == false){
                if(dmg > Dexterity){
                    Console.WriteLine($"{Name} stabs {target.Name} in the chest with 5 exploding kunai. \n{target.Name} is now meat chunks on the floor \nBRUTALITY");
                    execute[$"{target.Name}"] = true;
                }else{
                    Console.WriteLine($"{Name} decapitates {target.Name} and slices their head in half mid-air. \nFATALITY");
                    execute[$"{target.Name}"] = true;
                }
            }else{
                Console.WriteLine($"There is nothing left of {target.Name}\n{Name}: \"Threat eliminated.\"");
            }
        }
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }

    public int Steal(Human target){
        int dmg;
        if(target.Health > 4){
            dmg = 5;
            target.Health -= dmg;
            this.Health += dmg;
        }else{
            dmg = target.Health;
            target.Health -= dmg;
            Health += dmg;
        }
        Console.WriteLine($"{Name} stole {dmg}hp from {target.Name}!");
        return target.Health;
    }
}