using System;

class Player{
    private string name;
    private float maxHp;
    private float hp;
    private string status;
    public EventHandler<CurrentHPArgs> HPCheck;

    public Player(string name="Player", float maxHp=100f){
        this.name = name;
        if(maxHp <= 0){
            maxHp = 100f;
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
        this.status = this.name + " is ready to go!";
        this.HPCheck = this.CheckStatus;
    }
    public void PrintHealth(){
        System.Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
    public void TakeDamage(float damage){
        if(damage < 0)
            damage = 0;
        System.Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        damage = this.hp - damage;
        ValidateHP(damage);
    }
    public void HealDamage(float heal){
        if(heal < 0)
            heal = 0;
        System.Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        heal += this.hp;
        ValidateHP(heal);
    }
    public void ValidateHP(float newHp){
        if(newHp < 0)
            this.hp = 0;
        else if(newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
        this.OnCheckStatus(new CurrentHPArgs(this.hp));
    }
    public float ApplyModifier(float baseValue, Modifier modifier){
        if(modifier == Modifier.Weak)
            return baseValue * .5f;
        else if(modifier == Modifier.Strong)
            return baseValue * 1.5f;
        else
            return baseValue;
    }

    private void CheckStatus(object sender, CurrentHPArgs e){
        if(this.hp == this.maxHp)
            this.status = this.name + " is in perfect health!";
        else if(this.hp >= (this.maxHp / 2))
            this.status = this.name + " is doing well!";
        else if(this.hp >= (this.maxHp / 4))
            this.status = this.name + " isn't doing too great...";
        else if(this.hp > 0)
            this.status = this.name + " needs help!";
        else
            this.status = this.name + " is knocked out!";
        System.Console.WriteLine(this.status);

    }
    private void HPValueWarning(object sender, CurrentHPArgs e){
        if(this.hp == 0)
            System.Console.WriteLine("Health has reached zero!");
        else
            System.Console.WriteLine("Health is low!");
    }
    private void OnCheckStatus(CurrentHPArgs e){
        if(this.hp <= (this.maxHp / 4))
            this.HPCheck += this.HPValueWarning;
        else
            this.HPCheck -= this.HPValueWarning;
        this.HPCheck(this, e);
    }
}
/// Delegate for health calculations
public delegate void CalculateHealth(float num);
/// enum for damage modifiers
public enum Modifier{
    /// does half
    Weak,
    /// does normal
    Base,
    /// does 1.5 times
    Strong
}
/// Delegate that modifies damage
public delegate float CalculateModifier(float baseValue, Modifier modifier);

class CurrentHPArgs : EventArgs{
    public readonly float currentHp;
    public CurrentHPArgs(float newHp){
        this.currentHp = newHp;
    }
}