public class Wizard : Human{

    public Wizard(string name) : base(name, 3, 25, 3, 50){
        Name = name;
    }

    public override int Attack(Human target){
        int dmg = Intelligence * 3;
        if(target.Health > 0){
            if(target.Health > dmg){
                target.Health -= dmg;
                this.Health += dmg;
            }else{
                Health += target.Health;
                target.Health = 0;
            }
        }else{
            Console.WriteLine($"{Name} burns {target.Name} to a crisp.");
        }
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage and healed for {dmg} points!");
        return target.Health;
    }

    public int Heal(Human target){
        int heal = Intelligence * 3;
        if(target.Health > 0){
            target.Health += heal;
            Console.WriteLine($"{Name} healed {target.Name} for {heal} points!");
        }else{
            Console.WriteLine($"{Name} tried to heal {target.Name}, but they're already dead!");
        }
        return target.Health;
    }
}