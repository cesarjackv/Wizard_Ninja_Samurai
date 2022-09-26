public class Wizard : Human{

    public Wizard() : base("Wizard", 3, 25, 3, 50){
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