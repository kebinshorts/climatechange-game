using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa_Game
{
    public class eye //": className" for inheritance (c# only allows single inherit.) 
    {
        //kinda forgot the whole static private public stuff again AAA
        public string name;
        public static double life;
        public eye(String name)
        {
            this.name = name;
            life = 100.0;
        }
        //public static void name doesn't return 
        //public int/string/bah name returns 

        //jus playin around aha
        public static void decreaseLife(double damage)
        {
            life -= damage;
        }
    }
}
