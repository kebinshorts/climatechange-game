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
            "Yes, invest more on satellites so we can monitor climate change globally",
            //2 rock 
            "Yes, employ more satellites to track global warming",
            //3 ice 
            "Emission in urban area",
            //polar bear
            "Increase carbon dioxide emission into the atmosphere",
            //wack area
            "",
            //last 
            "",
            //gallery 
            "Orbital debris are dangerous for satellites since they are traveling in a fast speed",
            //info 
            "Yes, definitely. They are dangerous",
            //oil 
            "Yes, it is a great proposal to clean up the sapce environment"
            
        };

        //string answer;
        string[] choice1 = {
            //terra
             "Yes, invest more on satellites so we can monitor climate change globally",
             //Modis
            "We can feel global warming, there is no need",
            //Misr
            "Global warming",
            //calfire
            "Increase carbon dioxide emission into the atmosphere",
            //reef
            "",
            //calipso
            "",
            //junk
            "They are staying where they are, there's no worries",
            //net
            "Yes, definitely. They are dangerous",
            //laser
            "Isn't there too much radiation? Bad for health",
            //tracking
            "There's too many of them, forget it"

        };
        string[] choice2 = {
            //terra
            "No, save up money to send more people to outerspace so we can escape",
            //Modis
            "Yes, employ more satellites to track global warming",
            //Misr
            "To see how much ice has melt in arctic",
            //calfire
            "we can have more farming land",
            //reef
            "",
            //calipso
            "",
            //junk
            "Orbital debris are dangerous for satellites since they are traveling in a fast speed",
            //net
            "No, it looks like a fishing technique",
            //laser
            "Yes, it is a great proposal to clean up the sapce environment",
            //tracking
            "Will it create more jobs?"
        };
        string[] choice3 = {
            //terra
            "Maybe, we can invest later when climate change gets worse",
            //Modis
            "No, we have enough satellites",
            //Misr
            "Emission in urban area",
            //calfire
            "We can build more houses",
            //reef
            "",
            //calipso
            "",
            //junk
            "No, orbital bedris looks beautiful",
            //net
            "We shouldnt send more satellites",
            //laser
            "This sounds unrealistic",
            //tracking
            "Yes, more tracking system can help us determine the collision risk"

        };
        string[] attraction = {
            //1
            "Welcome to the Pilocene Arctic!" +
                "\r\n" +
                "\r\nbetween earth's atmosphere, land, snow and ice, ocent and energy balance" +
                "\r\nWith all these analytical cameras, we can understnad Climate on Earth and climate change" +
                "\r\nThis can also help us to map the impact of human activities, " +
                "\r\nand the impact of natural disasters on our ecosystems",

            //2
            "This is a Pilocene Rock. Let's learn more."+
                "\r\nthe accumluated smoke makes the flaming hotspots to hard to be spotted"+
                "\r\nModis ia a Moderate Resolution Imaging Spectroradiometer"+
                "\r\nthat can see the longer wavelengths of nonvisible light" +
                "\r\nor infrared radiation produced by the heat coming from actively burning wildfires",

            //3
            "Ice = Arctic, Arctic = Ice. What will Artic be without Ice?"+
                "\r\nIt has 9 different cameres collect snapshot of earth simultaneously"+
                "\r\nScientists look at those different perspectives to calculate the extent and height of the smoke plume downwind"+
                "\r\nas well as the height nearest the source of the fire, called the injection height. " +
                "\r\nThat information is essential for determining how far the smoke will travel.",

            //4
            "This is a trio of polar bears - threading on thin ice."+
                "\r\nabout 4 Million Acres has been burned away."+
                "\r\nNasa's Terra Satellite helps sciences the officials to track the spread of the wildfire and smoke,"+
                "\r\nand determine how much we have lost in this wildfire",

            //5
            "Something is not right here at all. Let's look into it."+
                "\r\nIt is the world's biggest and the only organism that is visible from out space"+
                "\r\nIsn't this nature's gift so beautiful? How can we leave it in danger?",

            //6 
            "This is the Last Ice Area project. Let's learn more."+
                "\r\nAn agreement between Canada and the Qikiqtani Inuit Association:"+
                "\r\nTo protect the High Arctic Basin, also Tuvaijuittuq(ice never melts in Inuktitut)."+
                "\r\nThe Last Ice Area is the only area with the lowest temperature for Arctic habitats in the summer.",

            //7
            "The issue of invasive species."+
                "\r\nAs the Arctic is warming up, species from the South poses as threats to existing Arctic species."+
                "\r\nThe Artic Fox's largest competitor, the Red Fox is moving into the now warmer Tundra areas.",
            
            //8 HERE
            "Welcome to the Information Centre!"+
                "\r\nSuch practice is similar to the searching bodies in wide water"+
                "\r\nThe giant net is used to capture and gather junk together",
                
            //9 
            "This is oil drilling the Arctic."+
                "\r\nAs frozen land and fossil fuels warm up, oil drilling is now expanding up North."+
                "\r\nMany petroleum businesses are taking advantage of warmer temperatures." +
                "\r\n(Businesses started Arctic oil production since 2014)"

        };


        string[] challenge = {
            //Terra Question
            "Should we invest more in satellites like Terra to help us monitor our Earth?",
            //Modis Question
            "Should we employ more satellites with thermal dectors and camera to help us further track global warming?",
            //Misr Question
            "Where else can we apply MISR technology on Earth?",
            //Calfire
            "How does california wildfire affect our environment",
            //reef
            "",
            //calipso
            "",
            //Junk question
            "What is bad about orbital debris?",
            //net junk
            "Should we launch more satellites with giant net to clean up debris?",
            //Laser junk
            "Should we invest more into laser boom system to clean up debris?",
            //Tracking Question
            "Should we invest more into debris tracking system to help target cleaning the large pieces?"
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
