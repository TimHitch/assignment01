
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
// Assignment: 01 The Hero class
// Student: Tim Hitchcock 300801451
// Date: Jan 30 2015
{
    class Hero
    {
        //Private properties++++++++++++++++++++++++++++++++
        private int strength; 
        private int speed;
        private int health;
        public string name;
        Random ability = new Random();

        //Public Properties++++++++++++++++++++++++++++++++++
        public Hero(string name) 
        // The	constructor	Method should take one parameter, name (string)	and	
        // pass its value to the name property. It will also call the generateAbilities method
                                
        {
            this.name = name;
            generateAbilities();
        }
        private void generateAbilities() 
        //A private generateAbilities Method randomly generates the ability	
        // numbers	for	the strength, speed	and	health	properties
        {
            this.strength = ability.Next(1, 100);
            this.speed = ability.Next(1, 100);
            this.health = ability.Next(1, 100);
        }
        public void fight() 
        // A public fight Method calls the hitAttempt method. If hitAttempt	returns	true,	
        //then it will call the hitDamage method. The damage will then be displayed in a message on the Console
        {
            int damage = 0;
            if (hitAttempt())
            {
                damage = hitDamage();
                Console.WriteLine("The damage caused to opponent: {0}", damage);
            }
        }
        private bool hitAttempt() 
        // A private hitAttempt Method that will randomly determine if the Hero hits 
        // (this should be 20% of the time) otherwise it will return false

        {
            double strikeSpeed = ability.Next(1, 100);
            if (strikeSpeed >= 1 && strikeSpeed <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int hitDamage() 
        // A private hitDamage Method that calculates the damage the Hero causes to 
        // the target on a hit
        {
            int damage = this.strength * ability.Next(1, 6);
            return damage;
        }
        public void show() 
        // show method to display abilities
        {
            Console.WriteLine("Strength: {0}", this.strength);
            Console.WriteLine("Speed: {0}", this.speed);
            Console.WriteLine("Health: {0}", this.health);
        }
        static void Main(string[] args)
        {
            Hero hero = new Hero("Master Tim");
            hero.show();
            hero.fight();

        }
    }
}

