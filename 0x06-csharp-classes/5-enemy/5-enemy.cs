using System;

namespace Enemies
{
    class Zombie
    {
        private int health;
        private string name = "(No name)";
        public string Name{
            get => name;
            set => name = value;
        }
        public Zombie(){
            this.health = 0;
        }
        public Zombie(int value){
            if(value < 0){
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                this.health = value;
            }
        }
        public int GetHealth(){
            return this.health;
        }
        public override string ToString()
        {
            return $"Zombie Name: {this.name} / Total Health: {this.health}";
        }
    }
}