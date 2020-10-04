using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasa_Game
{
    public partial class Reef : Form
    {
        string[] correct_ans = {
            //1 genome 
            "Their genome is different from other coral types",
            //2 lady elliot island 
            "Yes, coral reefs are essential to marine life",
            //3 raine island
            "No, it is not okay",
            //4 sea turtle 
            "640,000",
            //5 seeps
            "",
            //6 bleached
            "White",
            //7 cyclone
            "Yugen",
            //8 info
            "Successfully restored Raine Island",
            //9 birds eye view 
            "Do nothing about it"
        };

        //string answer;
        string[] choice1 = {
            //1 genome
             "Because they are red",
             //2 lady 
            "Use the funding & resources on making plastic straws instead",
            //3 raine
            "Doesn't matter",
            //4 tur
            "640,000",
            //5 seeps
            "",
            //6 bleach
            "Red",
            //7 cyclone
            "Drought",
            //8 info 
            "Successfully restored Raine Island",
            // birds eye 
            "Talk to a friend about the issue"

        };
        string[] choice2 = {
            //1 YES
            "Their genome is different from other coral types",
            //2
            "Yes, so we can dig gold mines on land",
            //3
            "If there's no nearby trash, then I will litter",
            //4
            "Not sure",
            //5
            "",
            //6
            "White",
            //7
            "Hurricane",
            //8
            "Produced the Turtle Song",
            //9
            "Do further research online"
        };
        string[] choice3 = {
            //1
            "Red Corals have the ability to release Serotonin",
            //2 YES
            "Yes, coral reefs are essential to marine life",
            //3
            "No, it is not okay",
            //4
            "40,000",
            //5
            "",
            //6
            "The colours of the rainbow",
            //7
            "Yugen",
            //8
            "Sending the first turtle to moon",
            //9
            "Do nothing about it"

        };
        string[] attraction = {
            //1
            "This is the Red Coral. Why is it so special?" +
                "\r\nDue to climate change causing rising average sea temperatures, " +
                "\r\nmany corals out of a total of 400 types have fallen victim to the negative effects." +
                "\r\n(Corals face heat stresses and bleaching effects, decreasing capacity for corals to build skeletons)." +
                "\r\nBut recently, scientists discovered something unique about Red Corals: " +
                "\r\nthey can survive despite higher sea temperatures causing other coral types to die off.",

            //2
            "Welcome to Lady Elliot Island! Let's learn more about the island."+
                "\r\nLady Elliot Island is a reef island, home to many species dependant on both Island and Ocean."+
                "\r\nThis Island is currently one of many projects for local organizations:"+
                "\r\nto restore all reef islands along the Great Barrier Reef to protect those vulnerable species.",

            //3 
            "Welcome to Raine Island! Let's learn more about the island."+
                "\r\nRaine island is special because it was a successful predecessor of the "+
                "\r\ncurrently ongoing Lady Elliot Island Restoration Project."+
                "\r\nRaine island is one of the world's largest green turtle breeding area" +
                "\r\nthat was filled with trash. This caused green turtle population to drop" +
                "\r\n over recent years. Luckily, the island restoration project was successful.",


            //4 
            "This is a Green Sea Turtle."+
                "\r\nAround 64,000 green turtles nest at Raine Island per season." +
                "\r\nThat's around 90% of the Great Barrier Reef's northern turtle population!"+
                "\r\nGreen sea turtle population before restoration of Raine Island: around 6000"+
                "\r\nGreen sea turtle population after restoration of Raine Island: over 27,500!",

            //5
            "This is a Volanic Seep. Let's learn more!"+
                "\r\nVolanic seeps are nature's labratory: scientists can study the ecosystem's response"+
                "\r\nto the effects of Ocean Acidification (changed Ocean chemistry from absorbing excessive CO2)"+
                "\r\nWhat is investigated? How the high levels of carbon dioxide impact coral reefs.",

            //6
            "Corals come in many colours. But this coral is different. It's bleached."+
                "\r\nThere are 2 main causes of coral bleaching: "+
                "\r\nRising sea temperature: reduces ability for corals to create habitat for marine life."+
                "\r\nOcean acidification: reefs become more vulnerable to damage from changes in Ocean pH levels.",

            //7 
            "This is a natural disaster called a Cyclone."+
                "\r\nEver since the effects of climate change started taking place, "+
                "\r\nthere has been increased severity and frequency of storms" + 
                "(hurricanes, drought, floods, cyclones, extra precipitation levels, and more).",
            
            //8
            "Welcome to the Information Centre! Here are a few orgnanizations and their work."+
                "\r\nGreat Barrier Reef Foundation: conducted the island restoration projects, volcanic seeps labs, and more!"+
                "\r\nWWF, together with the Australian Marine Conservation Society: leads the Fight For the Reef campaign!",
                

            //9
            "The Great Barrier Reef and its habitants are in danger. How can YOU help?"+
                "\r\nEducate yourself further on the issue (organizations, causes, effects)."+
                "\r\nSpread awareness amongst your friends, family, school, community, and more!"

        };

        string[] challenge = {
            //1
            "Why do you think Red Corals can live at higher sea temperatures?",
            //2
            "Should we restore as much reef islands as we can?",
            //3
            "Is it ok to litter on Raine Island's beach?",
            //4
            "Take a guess! How many baby turtles hatched this year?",
            //5 
            "",
            //6 
            "What does a bleached coral look like?",
            //7 
            "Which of the following is not a storm?",
            //8
            "What did the Great Barrier Reef organization contribute towards the cause?",
            //9
            "What should you not do after learning about this issue?"
            
        };

        int a1 = 0;
        int a2 = 1;
        int a3 = 2;
        int a4 = 3;
        int a5 = 4;
        int a6 = 5;
        int a7 = 6;
        int a8 = 7;
        int a9 = 8;

        int i = 0;

        int counter = 0;
        int score = 0;
        int chance = 1;

        bool a1Completed = false;
        bool a2Completed = false;
        bool a3Completed = false;
        bool a4Completed = false;
        bool a5Completed = false;
        bool a6Completed = false;
        bool a7Completed = false;
        bool a8Completed = false;
        bool a9Completed = false;

        bool choice1WasClicked = false;
        bool choice2WasClicked = false;
        bool choice3WasClicked = false;
        public Reef()
        {
            InitializeComponent();    
            lbl_welcome.Text = "Welcome to The Great Barrier Reef" + "\r\nAre you ready for your Marvellous journey?" + "\r\nClick on any attraction to get started";
        }

        public bool completion()
        {
            if (counter == 0)
            {
                a1Completed = true;
                return true;

            }
            else if (counter == 1)
            {
                a2Completed = true;
                return true;

            }
            else if (counter == 2)
            {
                a3Completed = true;
                return true;
            }
            else if (counter == 3)
            {
                a4Completed = true;
                return true;
            }
            else if (counter == 4)
            {
                a5Completed = true;
                return true;
            }
            else if (counter == 5)
            {
                a6Completed = true;
                return true;
            }
            else if (counter == 6)
            {
                a7Completed = true;
                return true;
            }
            else if (counter == 7)
            {
                a8Completed = true;
                return true;
            }
            else if (counter == 8)
            {
                a9Completed = true;
                return true;
            }
            return false;
        }

        private void reward()
        {
            if (a1Completed == true &&
             a2Completed == true &&
             a3Completed == true &&
             a4Completed == true &&
             a5Completed == true &&
             a6Completed == true &&
             a7Completed == true &&
             a8Completed == true &&
             a9Completed == true)
            {
                //MessageBox.Show("Congrats! Hope you had fun swimming in the Great Barrier Reef"+"\r\nKeep looking around"+"\r\nYour score is"+(score/8));
                this.Close();
                Global.ShowForm3();
            }
        }
        private void choices_hide()
        {
            btn_c1.Hide();
            btn_c2.Hide();
            btn_c3.Hide();
            btn_complete.Hide();
            lbl_feedBack.Hide();
        }
        private void Choices_show(string Choice1, string Choice2, string Choice3)
        {
            btn_c1.Text = Choice1;
            btn_c1.Show();
            btn_c2.Text = Choice2;
            btn_c2.Show();
            btn_c3.Text = Choice3;
            btn_c3.Show();
            btn_complete.Hide();
            lbl_feedBack.Hide();

        }
        private void buttons_disable()
        {
            btn_c1.Enabled = false;
            btn_c2.Enabled = false;
            btn_c3.Enabled = false;
            btn_challenge.Enabled = false;
            btn_previous.Enabled = false;
        }

        private void buttons_enable()
        {
            btn_c1.Enabled = true;
            btn_c2.Enabled = true;
            btn_c3.Enabled = true;
            btn_challenge.Enabled = true;
            btn_previous.Enabled = true;
        }
        //attraction completed 
        //reset everything 
        private void btn_complete_Click(object sender, EventArgs e)
        {
            pnl_reef.Visible = false;

            btn_c1.Visible = false;
            btn_c2.Visible = false;
            btn_c2.Visible = false;

            lbl_feedBack.Visible = false;

            btn_challenge.Visible = true;

            btn_exit.Visible = true;
            btn_challenge.Visible = false;

        }

        private void Evaluation(string Choice1, string Choice2, string Choice3)
        {

            if (i == 0 && choice1WasClicked == true)
            {
                if (Choice1 == correct_ans[counter])
                {
                    result1();
                    choice1WasClicked = false;
                }
                else
                {
                    result4();
                    choice1WasClicked = false;
                    i = 1;

                }
            }
            else if (i == 0 && choice2WasClicked == true)
            {
                if (Choice2 == correct_ans[counter])
                {
                    result1();
                    choice2WasClicked = false;
                }
                else
                {
                    result4();
                    choice2WasClicked = false;
                    i = 1;
                }
            }
            else if (i == 0 && choice3WasClicked == true)
            {
                if (Choice3 == correct_ans[counter])
                {
                    result1();
                    choice3WasClicked = false;
                }
                else
                {
                    result4();
                    choice3WasClicked = false;
                    i = 1;
                }
            }
            else
            {
                if (i == 1 && choice1WasClicked == true)
                {
                    if (Choice1 == correct_ans[counter])
                    {
                        result2();
                        choice1WasClicked = false;
                        i = 0;
                        buttons_disable();
                        btn_complete.Enabled = true;
                    }
                    else
                    {
                        result3();
                        choice1WasClicked = false;
                        i = 0;
                        btn_complete.Enabled = true;
                    }
                }

                else if (i == 1 && choice2WasClicked == true)
                {
                    if (Choice2 == correct_ans[counter])
                    {
                        result2();
                        choice2WasClicked = false;
                        i = 0;
                        btn_complete.Enabled = true;
                    }
                    else
                    {
                        result3();
                        choice2WasClicked = false;
                        i = 0;
                        btn_complete.Enabled = true;
                    }
                }
                else if (i == 1 && choice3WasClicked == true)
                {
                    if (Choice3 == correct_ans[counter])
                    {
                        result2();
                        choice3WasClicked = false;
                        i = 0;
                        btn_complete.Enabled = true;
                    }
                    else
                    {
                        result3();
                        choice3WasClicked = false;
                        i = 0;
                        btn_complete.Enabled = true;
                    }
                }



            }
        }

        private void result1()
        {
            lbl_feedBack.Show();
            lbl_feedBack.Text = "Great, you made a step closer to save Earth";
            Global.score += 1;
            score += 1;
            btn_complete.Show();
            completion();
            buttons_disable();
            Global.endTime += 20;
        }

        private void result2()
        {
            lbl_feedBack.Show();
            lbl_feedBack.Text = "Phew, you made the right decision";
            Global.score += 1;
            score += 1;
            chance = 1;
            btn_complete.Show();
            buttons_disable();
            Global.endTime += 5;
            completion();
        }

        private void result3()
        {
            lbl_feedBack.Show();
            lbl_feedBack.Text = "The correct answer is" + "\r\n" + correct_ans[counter];
            chance = 1;
            btn_complete.Show();
            buttons_disable();
        }

        private void result4()
        {
            lbl_feedBack.Show();
            lbl_feedBack.Text = "Ding! Try again! Earth needs you";
            chance = 2;
            Global.endTime -= 20;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (score < 6)
            {
                MessageBox.Show("Dont leave yet! You haven't finish exploring around");
            }
            else
            {
                this.Hide();
                Global.ShowForm3();
                MessageBox.Show("Congrats! Hope you had fun swimming in the Great Barrier Reef" + "\r\nKeep looking around" + "\r\nYour score is " + score+  "/8");
            }
            
        }

        private void btn_challenge_Click(object sender, EventArgs e)
        {
            lbl_context.Text = challenge[counter];
            Choices_show(choice1[counter], choice2[counter], choice3[counter]);
            buttons_enable();

        }

        private void btn_c1_Click(object sender, EventArgs e)
        {
            choice1WasClicked = true;
            Evaluation(choice1[counter], choice2[counter], choice3[counter]);
        }

        private void btn_c2_Click(object sender, EventArgs e)
        {
            choice2WasClicked = true;
            Evaluation(choice1[counter], choice2[counter], choice3[counter]);
        }

        private void btn_c3_Click(object sender, EventArgs e)
        {
            choice3WasClicked = true;
            Evaluation(choice1[counter], choice2[counter], choice3[counter]);
        }

        private void Reef_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1200, 800);
        }

        private void pic_1_Click(object sender, EventArgs e)
        {
            pnl_reef.Show();
            choices_hide();
            btn_challenge.Show();
            buttons_enable();
            counter = a1;
            lbl_context.Text = attraction[counter];
            if (a1Completed == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_2_Click(object sender, EventArgs e)
        {
            pnl_reef.Show();
            choices_hide();
            btn_challenge.Show();
            buttons_enable();
            counter = a2;
            lbl_context.Text = attraction[counter];
            if (a2Completed == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_3_Click(object sender, EventArgs e)
        {
            pnl_reef.Show();
            choices_hide();
            btn_challenge.Show();
            buttons_enable();
            counter = a3;
            lbl_context.Text = attraction[counter];
            if (a3Completed == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_4_Click(object sender, EventArgs e)
        {
            pnl_reef.Show();
            choices_hide();
            btn_challenge.Show();
            buttons_enable();
            counter = a4;
            lbl_context.Text = attraction[counter];
            if (a4Completed == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_5_Click(object sender, EventArgs e)
        {
            pnl_reef.Show();
            choices_hide();
            //btn_challenge.Show();
            buttons_enable();
            counter = a5;
            lbl_context.Text = attraction[counter];
            if (a5Completed == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_6_Click(object sender, EventArgs e)
        {
            pnl_reef.Show();
            choices_hide();
            btn_challenge.Show();
            buttons_enable();
            counter = a6;
            lbl_context.Text = attraction[counter];
            if (a6Completed == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_7_Click(object sender, EventArgs e)
        {
            pnl_reef.Show();
            choices_hide();
            btn_challenge.Show();
            buttons_enable();
            counter = a7;
            lbl_context.Text = attraction[counter];
            if (a7Completed == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_8_Click(object sender, EventArgs e)
        {
            pnl_reef.Show();
            choices_hide();
            btn_challenge.Show();
            buttons_enable();
            counter = a8;
            lbl_context.Text = attraction[counter];
            if (a8Completed == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_9_Click(object sender, EventArgs e)
        {
            pnl_reef.Show();
            choices_hide();
            btn_challenge.Show();
            buttons_enable();
            counter = a9;
            lbl_context.Text = attraction[counter];
            if (a9Completed == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            choices_hide();
            lbl_context.Text = attraction[counter];
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            pnl_reef.Visible = false;
        }
    }
}
