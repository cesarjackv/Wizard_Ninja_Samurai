public class Samurai : Human{

    public Samurai(string name) : base(name, 3, 3, 3, 200){
        Name = name;
    }

    public override int Attack(Human target){
        if(target.Health > 0){
            if(target.Health >= 50){
                base.Attack(target);
            }

            if(target.Health < 50){
                int execute = target.Health;
                Console.WriteLine($"I, Samurai {Name}, honor you with death brave warrior.");
                target.Health -= execute;
                Console.WriteLine($"{Name} executed {target.Name}!");
            }

        }else{
            Console.WriteLine($"{Name} bows to {target.Name}'s corpse.");
        }

        return target.Health;
    }

    public int Meditate(){
        if(this.Health < 200){
            this.Health = 200;
            Console.WriteLine($"{Name} meditated! {Name} is back at full health!");
        }else{
            Console.WriteLine($"{Name}'s health is already full!");
        }
        return this.Health;
    }
}