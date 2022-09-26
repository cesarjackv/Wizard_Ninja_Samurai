public class Samurai : Human{

    public Samurai() : base("Samurai", 3, 3, 3, 200){
    }

    public override int Attack(Human target){
        base.Attack(target);
        if(target.Health < 50){
            target.Health = 0;
            Console.WriteLine($"{Name} executed {target.Name}!");
        }
        return target.Health;
    }

    public int Meditate(){
        if(this.Health < 200){
            this.Health = 200;
        }
        Console.WriteLine($"{Name} meditated! {Name} is back at full health!");
        return this.Health;
    }
}