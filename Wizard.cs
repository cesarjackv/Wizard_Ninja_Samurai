public class Wizard : Human{

    public Wizard(string name) : base(name, 3, 25, 3, 50){
        Name = name;
    }

    public override int Attack(Human target){
        int dmg = Intelligence * 3;
        target.Health -= dmg;
        this.Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage and healed for {dmg} points!");
        return target.Health;
    }

    public int Heal(Human target){
        int heal = Intelligence * 3;
        target.Health += heal;
        Console.WriteLine($"{Name} healed {target.Name} for {heal} points!");
        return target.Health;
    }
}