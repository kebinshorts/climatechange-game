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
    public partial class Arctic : Form
    {
        string[] correct_ans = {
            //1 pilocene
            "Coastal cities",
            //2 rock 
            "Yes, employ more satellites to track global warming",
            //3 ice 
            "It acts as the fridge for Earth",
            //4 polar bear
            "They cannot adapt",
            //5 wack area
            "Energy reflected from the sun warms the Arctic faster",
            //6 last 
            "Ice never melts in Inuktitut",
            //7 gallery 
            "Red Foxes",
            //8 info 
            "Urged governments to convert to renewable energy",
            //9 oil 
            "Permafrost and Tundra areas melted"

        };

        //string answer;
        string[] choice1 = {
            //1
             "Warm cities",
             //2
            "",
            //3
            "It acts as the fridge for Earth",
            //4
            "They didn't feel a change",
            //5
            "A type of rollerblades",
            //6
            "When in Rome",
            //7
            "Red Foxes",
            //8
            "Urged governments to convert to renewable energy",
            //9
            "They set a small bomb to destroy ice layer"
           
        };
        string[] choice2 = {
            //1
            "Cities with sunset views",
            //2
            "",
            //3
            "To see how much ice has melted",
            //4
            "They're doing amazing",
            //5
            "Energy reflected from the sun warms the Arctic faster",
            //6
            "When in Inuktitut",
            //7
            "Other White Foxes",
            //8
            "Planned the Raine Island Restoration project",
            //9
            "Permafrost and Tundra areas melted"
           
        };
        string[] choice3 = {
            //1
            "Coastal cities",
            //2 no
            "",
            //3
            "It is not",
            //4
            "They cannot adapt",
            //5
            "Another brand of Fruit Loops",
            //6
            "Ice never melts in Inuktitut",
            //7
            "Blue Birds",
            //8
            "Aided in oil mining in the Arctic",
            //9
            "They use fire to burn the ice"

        };
        string[] attraction = {
            //1
            "Welcome to the Pilocene Arctic!" +
                "\r\nThe Pilocene Arctic was completely different from today's Arctic." +
                "\r\nIt was very warm and there were no ice in the Arctic (ice was only in Antarctica)." +
                "\r\nAs a result, sea levels were 9-15 meters (30-50 feet) higher, locations such as:"+
                "\r\nShanghai, New York, Houston, Seattle Island, Miami, and more coastal cities were underwater.",

            //2
            "This is a Pilocene Rock. Let's learn more."+
                "\r\nWhy were CO2 concentrations during the Pilocene Arctic so high (making it warmer)?"+
                "\r\nEarth natural thermostat: rock break-downs cause CO2 buildup, and  then"+
                "\r\nas CO2 and temp. rises, it takes away the excessive CO2 from the atmosphere naturally." +
                "\r\nThis is called the Rock Weathering Thermostat, that occurs over a span of a few million years.",

            //3
            "Ice = Arctic, Arctic = Ice. What will Artic be without Ice?"+
                "\r\nOver the past 50 years, the average temperature has increased by 2.3°C in the Artic."+
                "\r\nThe Arctic acts as our planet's fridge: it helps cool the Earth."+
                "\r\nCurrently we are in Arctic Amplification: temp. increasing at x2 the rate of global warming.",

            //4
            "This is a trio of polar bears - threading on thin ice."+
                "\r\nThe habitat of polar bears, and other Arctic species, is ice. Now that ice is melting, "+
                "\r\nit means these animals now are losing their habitat to live in. Due to the rapid shrinking of"+
                "\r\nice, Arctic species are unable to adapt to such sudden changes."+
                "\r\nMost affected species: polar bears, walruses, reindeers, narwals, belguas, and bowheads.",

            //5
            "Something is not right here at all. Let's look into it."+
                "\r\nThe Feedback or Albedo effect: when ice and snow relect a majority of the sun's energy into space."+
                "\r\nWhen the ice melts, water and rock absorb the sun energy's, increasing the temperature even more."+ 
                "\r\nAs a result: permafrost melts, releasing CO2 and methane from now unfrozen animals and plants.",

            //6 
            "This is the Last Ice Area project. Let's learn more."+
                "\r\nAn agreement between Canada and the Qikiqtani Inuit Association:"+
                "\r\nTo protect the High Arctic Basin, also Tuvaijuittuq(ice never melts in Inuktitut)."+
                "\r\nThe Last Ice Area is the only area with the lowest temperature for Arctic habitats in the summer.",

            //7
            "The issue of invasive species."+
                "\r\nAs the Arctic is warming up, species from the South poses as threats to existing Arctic species."+
                "\r\nThe Artic Fox's largest competitor, the Red Fox is moving into the now warmer Tundra areas.",
            
            //8 
            "Welcome to the Information Centre! Here are a few orgnanizations and their work."+
                "\r\nWWF:initiated the Last Ice Area project, and urged governments to tranistion towards renewable energy."+
                "\r\nPolar Bears Int.:goal is to maintain long-term sustainability of the Arctic for Polar Bears(uses trackers).",
                
            //9 
            "This is oil drilling the Arctic."+
                "\r\nAs frozen land and fossil fuels warm up, oil drilling is now expanding up North."+
                "\r\nMany petroleum businesses are taking advantage of warmer temperatures." +
                "\r\n(Businesses started Arctic oil production since 2014)"

        };


        string[] challenge = {
            //1
            "What city types would be underwater in the Pilocene era?",

            //2
            "",

            //3
            "Why is the Arctic important?",

            //4
            "How are Arctic species adapting to a warmer Arctic?",

            //5
            "What is the Feedback/Albedo loop?",

            //6
            "What does Tuvaijuittuq mean in English?",

            //7
            "Who is the Arctic Fox's largest competitor?",

            //8
            "What contributions did WWF make towards the cause?",

            //9
            "How can companies conduct oil production in the Arctic?"
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

        public Arctic()
        {
            InitializeComponent();
            lbl_welcome.Text = "Welcome to The Arctic" + "\r\nAre you ready for your Marvellous journey?" + "\r\nClick on any attraction to get started";
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
                //MessageBox.Show("Congrats! Hope you had fun swimming in the Great Barrier Reef"+"\r\nKeep looking around"+"\r\nYour score is"+ Global.score +"/8"));
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

        private void btn_complete_Click(object sender, EventArgs e)
        {
            pnl_arctic.Visible = false;

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
                MessageBox.Show("Congrats! Hope you had fun trekking in the Arctic" + "\r\nKeep looking around" + "\r\nYour score is " + score+ "/8");
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
        private void Arctic_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1200, 800);
        }

        private void pic_1_Click(object sender, EventArgs e)
        {
            pnl_arctic.Show();
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
            pnl_arctic.Show();
            choices_hide();
            //btn_challenge.Show();
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
            pnl_arctic.Show();
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
            pnl_arctic.Show();
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
            pnl_arctic.Show();
            choices_hide();
            btn_challenge.Show();
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
            pnl_arctic.Show();
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
            pnl_arctic.Show();
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
            pnl_arctic.Show();
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
            pnl_arctic.Show();
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
            pnl_arctic.Visible = false;

        }
    }
}
