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

class TestObject : Base, ICollectable, IBreakable, IInteractive{
    public void Collect(){}
    public void Break(){}
    public void Interact(){}
    public bool isCollected{ get; set;}
    public int durability {get; set;}
}

