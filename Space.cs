using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Nasa_Game
{
    public partial class Space : Form
    {
        string[] correct_ans = {
            //terra
            "Yes, invest more on satellites so we can monitor climate change globally",

            //Modis
            "Yes, employ more satellites to track global warming",

            //Misr
            "Emission in urban area",

            //calfire
            "Increase carbon dioxide emission into the atmosphere",

            //reef
            "",

            //calipso
            "",

            //junk
            "Orbital debris are dangerous for satellites since they are traveling in a fast speed",

            //net
            "Yes, definitely. They are dangerous",

            //laser
            "Yes, it is a great proposal to clean up the sapce environment",

            //tracking
            "Yes, more tracking system can help us determine the collision risk"
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
            //attraction Terra
            "This Satellite is named Terra, an Earth Observing System flagship" +
                "\r\nTerra has 9 cameras, allowing us to explore the connections " +
                "\r\nbetween earth's atmosphere, land, snow and ice, ocent and energy balance" +
                "\r\nWith all these analytical cameras, " +
                "\r\nwe can understnad Climate on Earth and climate change" +
                "\r\nThis can also help us to map the impact of human activities, " +
                "\r\nand the impact of natural disasters on our ecosystems",

            //Attraction Modis
            "With multiple individual fires bruing throughtout the state"+
                "\r\nthe accumluated smoke makes the flaming hotspots to hard to be spotted"+
                "\r\nModis ia a Moderate Resolution Imaging Spectroradiometer"+
                "\r\nthat can see the longer wavelengths of nonvisible light" +
                "\r\nor infrared radiation produced by the heat coming from actively burning wildfires",

            //Attraction MISR
            "MISR on Nasa's Terra satellite is a Multi-angle Imaging Spectroradiometer"+
                "\r\nIt has 9 different cameres collect snapshot of earth simultaneously"+
                "\r\nScientists look at those different perspectives to calculate the "+
                "\r\nextent and height of the smoke plume downwind"+
                "\r\nas well as the height nearest the source of the fire, called the injection height." +
                "\r\nThat information is essential for determining how far the smoke will travel.",

            //Attraction calfire
            "The California Wildfire has been burning for 3,4 months,"+
                "\r\nabout 4 Million Acres has been burned away."+
                "\r\nNasa's Terra Satellite helps sciences the officials " +
                "\r\nto track the spread of the wildfire and smoke,"+
                "\r\nand determine how much we have lost in this wildfire",

            //Attraction Reef
            "Did you know that The Great Barrier Reed can be seen from Outer Space?"+
                "\r\nIt is the world's biggest and the only organism that is visible from out space"+
                "\r\nIsn't this nature's gift so beautiful? How can we leave it in danger?",

            //Attraction calipso
            "The Calipso and Suomi NPP helps us to track how the smoke move"+
                "\r\nCALIPSO has a laser onboard that shoots bursts of laser light toward Earth"+
                "\r\nWhen that light hits something, such as particles in a wildfire smoke plume,"+
                "\r\nit is reflected back to sensors on CALIPSO",

            //Attraction junk
            "More than 500,000 pieces of debris, or “space junk,” are tracked as they orbit the Earth."+
                "\r\nSuch debris includes nonfunctional spacecraft, abandoned launch vehicle stages, " +
                "\r\nmission-related and fragmentation debris."+
                "\r\nThey all travel at speeds up to 17,500 mph(fast enough for a small piece of orbital debris)",
            
            //Attraction net junk 
            "Satellites are laucnhed to space with a giant net"+
                "\r\nSuch practice is similar to the searching bodies in wide water"+
                "\r\nThe giant net is used to capture and gather junk together",
                

            //Attraction laser Junk
            "A proposed way to clean space junk is to use hugher-energy pulse laser radiation"+
                "\r\nThe laser is shot from a ground based system"+
                "\r\nthe travelling trajectory of the debris has to be accurately calculated prior to the laser boom",


            //Attraction tracking
            "NASA and the DoD track the satellite (including orbital debris) environment cooperatively."+
                "\r\nThey categorize the debris into sizes and determine their collision risk",

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

        public Space()
        {
            InitializeComponent();
            lbl_spaceWel.Text = "Welcome to Space" + "\r\nAre you ready for your Marvellous journey?" + "\r\nClick on any attraction to get started";
            pnl_prompts.Hide();

        }

        private void Space_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1200, 800);
        }

        int terra = 0;
        int modis = 1;
        int misr = 2;
        int calfire = 3;
        int reef = 4;
        int calipso = 5;
        int junk = 6;
        int net_junk = 7;
        int laser_junk = 8;
        int tracking = 9;


        int counter = 0;
        int score = 0;
       

        // a bool for each attraction to signify if it is completed already
        // need this to disable the collision after the attraction is finished
        bool terraCompleted = false;
        bool modisCompleted = false;
        bool misrCompleted = false;
        bool calfireCompleted = false;
        bool reefCompleted = false;
        bool calipsoCompleted = false;
        bool junkCompleted = false;
        bool netCompleted = false;
        bool laserCompleted = false;
        bool trackingCompleted = false;

        bool choice1WasClicked = false;
        bool choice2WasClicked = false;
        bool choice3WasClicked = false;


        public  bool completion () {
            if (counter == 0)
            {
                terraCompleted = true;
                return true;

            }
            else if (counter == 1)
            {
                modisCompleted = true;
                return true;

            }
            else if (counter == 2)
            {
                misrCompleted = true;
                return true;
            }
            else if (counter == 3)
            {
                calfireCompleted = true;
                return true;
            }
            else if (counter == 4)
            {
                reefCompleted = true;
                return true;
            }
            else if (counter == 5)
            {
                calipsoCompleted = true;
                return true;
            }
            else if (counter == 6)
            {
                junkCompleted = true;
                return true;
            }
            else if (counter == 7)
            {
                netCompleted = true;
                return true;
            }
            else if (counter == 8)
            {
                laserCompleted = true;
                return true;
            }
            else if (counter == 9)
            {
                trackingCompleted = true;
                return true;
            }
            return false;
        }

        private void choices_hide()
        {
            btn_Choice1.Hide();
            btn_Choice2.Hide();
            btn_Choice3.Hide();
            btn_done.Hide();
            lbl_feedback.Hide();
        }
        private void Choices_show(string Choice1, string Choice2, string Choice3)
        {
            btn_Choice1.Text = Choice1;
            btn_Choice1.Show();
            btn_Choice2.Text = Choice2;
            btn_Choice2.Show();
            btn_Choice3.Text = Choice3;
            btn_Choice3.Show();
            btn_done.Hide();
            lbl_feedback.Hide();

        }
        private void buttons_disable()
        {
            btn_Choice1.Enabled = false;
            btn_Choice2.Enabled = false;
            btn_Choice3.Enabled = false;
            btn_task.Enabled = false;
            btn_previous.Enabled = false;
        }

        private void buttons_enable()
        {
            btn_Choice1.Enabled = true;
            btn_Choice2.Enabled = true;
            btn_Choice3.Enabled = true;
            btn_task.Enabled = true;
            btn_previous.Enabled = true;
        }

        private void reward()
        {
            if(terraCompleted == true &&
             modisCompleted == true &&
             misrCompleted == true &&
             calfireCompleted == true &&
             reefCompleted == true &&
             calipsoCompleted == true &&
             junkCompleted == true &&
             netCompleted == true &&
             laserCompleted == true &&
             trackingCompleted == true)
            {
                //MessageBox.Show("Congrats! Hope you had fun floating in the space"+"\r\nKeep looking around"+"\r\nYour score is"+(score/8));
                this.Close();
                Global.ShowForm3();
            }
        }

        private void Evaluation(string Choice1, string Choice2, string Choice3)
        {
            for (int i = 0; i <= 1; i++)
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
                        }
                        else
                        {
                            result3();
                            choice1WasClicked = false;
                        }
                    }

                    else if (i == 1 && choice2WasClicked == true)
                    {
                        if (Choice2 == correct_ans[counter])
                        {
                            result2();
                            choice2WasClicked = false;
                        }
                        else
                        {
                            result3();
                            choice2WasClicked = false;
                        }
                    }
                    else if (i == 1 && choice3WasClicked == true)
                    {
                        if (Choice3 == correct_ans[counter])
                        {
                            result2();
                            choice3WasClicked = false;
                        }
                        else
                        {
                            result3();
                            choice3WasClicked = false;
                        }
                    }


                }
            }
        }

        private void result1()
        {
            lbl_feedback.Show();
            lbl_feedback.Text = "Great, you made a step closer to save Earth";
            Global.score += 1;
            score += 1;
            btn_done.Show();
            completion();
            buttons_disable();
            Global.endTime += 20;
        }

        private void result2()
        {
            lbl_feedback.Show();
            lbl_feedback.Text = "Phew, you made the right decision";
            Global.score += 1;
            score += 1;

            btn_done.Show();
            buttons_disable();
            Global.endTime += 5;
            completion();
        }

        private void result3()
        {
            lbl_feedback.Show();
            lbl_feedback.Text = "The correct answer is" + "\r\n" + correct_ans[counter];

            btn_done.Show();
            buttons_disable();
        }

        private void result4()
        {
            lbl_feedback.Show();
            lbl_feedback.Text = "Ding! Try again! Earth needs you";

            Global.endTime -= 20;
        }

        private void picBox_terra_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = terra;
            lbl_context.Text = attraction[counter];
            if (terraCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }

        }

        private void picBox_laser_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = laser_junk;
            lbl_context.Text = attraction[counter];
            if (laserCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }

        }

        private void picBox_reef_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Hide();
            btn_done.Show();
            counter = reef;
            lbl_context.Text = attraction[counter];
            reefCompleted = true;
            btn_Exit.Enabled = true;
            if (reefCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_tracking_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = tracking;
            lbl_context.Text = attraction[counter];
            if (trackingCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_modis_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = modis;
            lbl_context.Text = attraction[counter];
            if (modisCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_calipso_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Hide();
            btn_done.Show();
            counter = calipso;
            lbl_context.Text = attraction[counter];
            calipsoCompleted = true;
            btn_Exit.Enabled = true;
            if (calipsoCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_junk_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = junk;
            lbl_context.Text = attraction[counter];
            if (junkCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_MISR_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = misr;
            lbl_context.Text = attraction[counter];
            if (misrCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_calFire_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = calfire;
            lbl_context.Text = attraction[counter];
            if (calfireCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_netJunk_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = net_junk;
            lbl_context.Text = attraction[counter];
            if (netCompleted == true)
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

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            pnl_prompts.Hide();
        }

        private void btn_task_Click(object sender, EventArgs e)
        {
            lbl_context.Text = challenge[counter];
            Choices_show(choice1[counter], choice2[counter], choice3[counter]);
            buttons_enable();
        }

        private void btn_done_Click_1(object sender, EventArgs e)
        {
            pnl_prompts.Hide();
        }

        private void btn_Choice1_Click_1(object sender, EventArgs e)
        {
            choice1WasClicked = true;
            Evaluation(choice1[counter], choice2[counter], choice3[counter]);

        }

        private void btn_Choice2_Click_1(object sender, EventArgs e)
        {
            choice2WasClicked = true;
            Evaluation(choice1[counter], choice2[counter], choice3[counter]);

        }

        private void btn_Choice3_Click_1(object sender, EventArgs e)
        {
            choice3WasClicked = true;
            Evaluation(choice1[counter], choice2[counter], choice3[counter]);

        }

        private void btn_leave_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Global.ShowForm3();

        }

    }

}
