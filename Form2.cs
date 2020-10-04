using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasa_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lbl_headLine.Text = "You have 20 minutes - 1200 seconds - to save our Earth. ";
            lbl_instructions.Text =
                "There are 6 global Areas heavily affected by Climate Change. ";
            lbl_mission.Text =
                "\r\nYour mission: ";
            lbl_mission2.Text = 
                "\r\nCLEAR all 6 Areas before the Timer hits 00:00";
            lbl_clearArea.Text = 
            "How to CLEAR an Area: ";
            lbl_ca.Text =
                " Each area is filled with attractions " +
                "\r\n Some attractions have questions " + "\r\n " +
                "\r\n           You have 3 chances to answer: " + "\r\n " +
                "\r\n-> Answer correctly: +15 seconds to the Timer " + "\r\n" +
                "\r\n-> Answer incorrectly: -20 seconds from the Timer" + "\r\n " +
                "\r\n-> Answer correctly on 2nd try: +5 seconds " + "\r\n " +
                "\r\n-> Answer incorrectly on 2nd try: no -/+ time " + "\r\n " +
                "\r\nTo Clear:" +
                "\r\n1) score at least 6/8 questions correct"+  "\r\n2) complete all questions" + "\r\n " +
                "\r\n-> Special reward for each Area CLEARed";
            lbl_lockedAreas.Text =
                "Locked Areas:";
            lbl_la.Text =
                "Space: must CLEAR Arctic ";
                //"\r\nFactory: must CLEAR City " + "\r\n" +
                //"\r\nRenewable Energy: must CLEAR Factory and Tar Sands ";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowForm1();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowForm3();
            //TIME TIME TIME 
            Global.timer.Start();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;*/
            //change sizes 
            this.Size = new Size(1240, 900);
            /*btn_start.Location = new Point(150, 500);
            btn_back.Location = new Point(400, 500);*/

            
        }

        private void btn_quitGame_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
