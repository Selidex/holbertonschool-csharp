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