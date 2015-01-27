using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Lesson04_Part2
{
    class Hero
    {
        //PRIVATE PROPERTIES
        private bool bravery = true;
        private int health;
        private int smart;
        private string gender;

        //CONSTRUCTOR +++++++++++++++++++
        public Hero(int health, int smart, string gender) 
        {
            this.health = health;
            this.smart = smart;
            this.gender = gender;
        }

        //PUBLIC METHODS
        public void doesGoodThings()
        {
            Console.WriteLine("Doin' good things... YEAH!");
        }
    }
}
