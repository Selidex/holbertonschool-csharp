﻿using System;

class Base{
    public string name;
    public override string ToString(){
        return name + " is a " + this.GetType().Name;
    }
}
