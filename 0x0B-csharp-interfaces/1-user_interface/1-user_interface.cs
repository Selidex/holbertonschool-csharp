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

interface ICollectable{
    bool isCollected{get; set;}
    void Collect();
}

interface IBreakable{
    int durability {get; set;}
    void Break();
}



class TestObject : Base, IInteractive, IBreakable,  ICollectable{
    public bool isCollected{ get; set;}
    public int durability {get; set;}
    public void Collect(){}
    public void Break(){}
    public void Interact(){}
}

