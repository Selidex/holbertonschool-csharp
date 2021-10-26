using System;

class Base{
    public string name {get; set;}
    public override string ToString(){
        return name + " is a " + this.GetType().Name;
    }
}

interface IInteractive{
    void Interact();
}

interface IBreakable{
    int durability {get; set;}
    void Break();
}

interface ICollectable{
    bool isCollected{get; set;}
    void Collect();
}

class Door : Base, IInteractive{
    public Door(string val="Door"){
        name = val;
    }
    public void Interact(){
        System.Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}

class Decoration : Base, IInteractive, IBreakable{
    public bool isQuestItem;
    public int durability{get; set;}
    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false){
        this.name = name;
        if(durability < 1){
            throw new ArgumentException("Durability must be greater than 0");
        }
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    public void Interact(){
        if(durability < 1){
            System.Console.WriteLine("The {0} has been broken.", this.name);
        }
        else if(isQuestItem == true){
            System.Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        }
        else{
            System.Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
        }
    }

    public void Break(){
        durability--;
        if(durability > 0){
            System.Console.WriteLine("You hit the {0}. It cracks.", this.name);
        }
        else if(durability == 0){
            System.Console.WriteLine("You smash the {0}. What a mess.",this.name);
        }
        else{
             System.Console.WriteLine("The {0} is already broken.",this.name);
        }
    }
}