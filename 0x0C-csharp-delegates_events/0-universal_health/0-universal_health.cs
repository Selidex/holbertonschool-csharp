using System;

class Player{
    private string name;
    private float maxHp;
    private float hp;
    public Player(string name="Player", float maxHp=100f){
        this.name = name;
        if(maxHp <= 0){
            maxHp = 100f;
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }
    public void PrintHealth(){
        System.Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
}