public class Ninja : Human{

    public Ninja() : base("Ninja", 3, 3, 75, 100){
    }

    public override int Attack(Human target){
        Random rand = new Random();
        int crit = 0;
        if(rand.Next(6) == 5){
            crit = 10;
        }else{
            crit = 0;
        }
        int dmg = Dexterity + crit;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }

    public int Steal(Human target){
        int dmg = 5;
        target.Health -= dmg;
        this.Health += dmg;
        Console.WriteLine($"{Name} stole {dmg}hp from {target.Name}!");
        return target.Health;
    }
}