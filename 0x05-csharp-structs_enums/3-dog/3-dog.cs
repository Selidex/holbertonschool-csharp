using System;

public enum Rating{
    Good,
    Great,
    Excellent
    }
public struct Dog{
    public  Rating rating;
    public string name;
    public string owner;
    public float age;
    public Dog(string name, float age, string owner, Rating rating){
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }
    public override string ToString(){
        return $"Dog Name: {this.name}\nAge: {this.age}\nOwner: {this.owner}\nRating: {this.rating}";
    }

}