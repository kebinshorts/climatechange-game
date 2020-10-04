using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasa_Game
{
    //class to declare all global variables (can be used in every method/function) 
    class Global
    {
        //stores the player's name bc why not let's make it personal 
        public static String playerName;
        //score
        public static int score;
        //stuff to displayer the timer 
        public static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public static int endTime = 1200;
        


        //arctic  
        public static bool spaceUnlocked = false;
        //tar sands and factory 
        //public static bool renewableEnergyUnlocked = false;
        //city
        //public static bool factoryUnlocked = false;

        //completed places 
        public static bool arcticComplete = false;
        public static bool reefComplete = false;
        //public static bool tarSandsComplete = false;
        public static bool spaceComplete = false;
        public static bool energyComplete = false;
        //public static bool agricultureComplete = false;
        //public static bool factoryComplete = false;
        public static bool cityComplete = false;
        public static bool rainforestComplete = false;

        public static void ShowForm1()
        {
            form1.Show();
            timer.Stop();
        }

        public static Form1 form1 = null;
        public static void ShowForm2()
        {
            if(form2 == null)
            {
                form2 = new Form2();    
            }
            form2.Show();
            timer.Stop();

        }
        public static Form2 form2 = null;

        public static void ShowForm3()
        {
            if (form3 == null)
            {
                form3 = new Form3();
            }
            form3.Show();
            timer.Start();

        }
        public static Form3 form3 = null;

        //start here
        public static void ShowArctic()
        {
            if (a == null)
            {
                a = new Arctic();
            }
            a.Show();
            timer.Start();
        }
        public static Arctic a = null;
        //end here 
        public static void ShowReef()
        {
            if (r == null)
            {
                r = new Reef();
            }
            r.Show();
            timer.Start();

        }
        public static Reef r = null;

       /* public static void ShowTarSands()
        {
            if (ts == null)
            {
                ts = new TarSands();
            }
            ts.Show();
            timer.Start();

        }
        public static TarSands ts = null;*/

        //variables in each place to save progress

        //lock and unlock 
        //time limit 
        //exit in form2 
        //edit instructions

        public static bool IsSpaceUnlocked()
        {
            if (arcticComplete)
            {
                spaceUnlocked = true;
                return true;
            }
            return false;
        }

        //when click on space
        //check isSpaceUnlocked()
        //if true then this.Hide() and ShowSpace();
        //else have a label become visible with the text saying "locked" 

        //inside arctic, when complete have Global.arcticComplete = true;

       /* public static bool IsEnergyUnlocked()
        {
            if (tarSandsComplete && factoryComplete)
            {
                renewableEnergyUnlocked = true;
                return true;
            }
            return false;
        }*/



    }
}
