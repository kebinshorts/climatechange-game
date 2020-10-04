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
    public partial class City : Form
    {
        public City()
        {
            InitializeComponent();
        }

        private void City_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(930, 700);
        }

        int slums = 0;
        int garbage = 1;
        int light = 2;
        int sprawl = 3;
        int water = 4;
        int energy = 5;
        int noise = 6;
        int traffic = 7;

        int counter = 0;
        int score = 0;
        int chance = 1;

        int i = 0;


        bool slumsCompleted = false;
        bool garbageCompleted = false;
        bool lightCompleted = false;
        bool sprawlCompleted = false;
        bool waterCompleted = false;
        bool energyCompleted = false;
        bool noiseCompleted = false;
        bool trafficCompleted = false;



        bool choice1WasClicked = false;
        bool choice2WasClicked = false;
        bool choice3WasClicked = false;

        string[] correct_ans = {
            //slums
            "Use physical intervention to provide infrastructure such as gutters, public toilets, and primary schools",
            //garbage
            "Look towards sorting and recycling to reduce the amount of landfill waste",
            //light
            "Replace lighting systems with warm-coloured, dimmable LED lighting",
            //sprawl
            "Revitalize existing urban areas to incorporate a balance of commercial and residential",
            //water
            "Reduce water usage within households and install water efficient faucets",
            //energy
            "Increase city density to incorporate efficient technologies and pedestrian areas",
            //noise
            "Establish regulations for noise limits within certain areas and increase city distances from airports",
            //traffic
            "Introduce adaptive traffic signals that change based on traffic flow",
        };

        //string answer;
        string[] choice1 = {
            //slums
            "Tear down and redevelop slums and give some money to the residents",
             //garbage
            "Look towards sorting and recycling to reduce the amount of landfill waste",
            //light
            "Set a curfew and shut down all city lights after the designated time",
            //sprawl
            "Revitalize existing urban areas to incorporate a balance of commercial and residential",
            //water
            "Cut off plumping systems when treatment plants are overwhelmed",
            //energy
            "Cut off electricity to buildings that are not economically important",
            //noise
            "Establish regulations for noise limits within certain areas and increase city distances from airports",
            //traffic
            "Give money to people who walk and bike to work"

        };
        string[] choice2 = {
            //slums
            "Use physical intervention to provide infrastructure such as gutters, public toilets, and primary schools",
            //garbage
            "Keep trash stored inside our homes in an enclosed area",
            //light
            "Replace lighting systems with warm-coloured, dimmable LED lighting",
            //sprawl
            "Set a boundary on the edge of the city in order to stop development beyond that point",
            //water
            "Create underground storage for excess waste water",
            //energy
            "Invest in charity events to fundraise solar panels for all buildings across the city",
            //noise
            "Set quiet hours after sunset and introduce fines for anyone who disobeys",
            //traffic
            "Introduce adaptive traffic signals that change based on traffic flow"
        };
        string[] choice3 = {
            //slums
            "Donate to the people through reputable charities",
            //garbage
            "Reduce garbage days in order to promote waste management within households",
            //light
            "Increase electricity taxes so businesses have less incentive to leave lighting on",
            //sprawl
            "Build taller skyscrapers in order to reduce the need of building outwards",
            //water
            "Reduce water usage within households and install water efficient faucets",
            //energy
            "Increase city density to incorporate efficient technologies and pedestrian areas",
            //noise
            "Install insulating material coupled with sound meters to dampen noises",
            //traffic
            "Enforce expensive tolls at highway entrances in order to deter highway traffic",
        };

        string[] attraction = {
            //attraction slums
            "Urban slums are neighbourhoods or city regions that cannot provide the basic living" +
                "\r\nconditions necessary for its inhabitants to live in a safe and healthy environment." +
                "\r\nHmm...",

            //Attraction garbage
            "Many waste materials that end up in the garbage contain toxic substances. Over time,"+
                "\r\nthese toxins leach into our soil and groundwater, and become environmental hazards for"+
                "\r\nyears. Hmm...",

            //Attraction light
            "Light pollution occurs as a result of excessive, bright man-made lighting disrupting the"+
                "\r\nnight sky. This not only hampers nocturnal wildlife (e.g. fireflies rely on light signals to"+
                "\r\nmate), but in addition, residents have reported trouble sleeping with strong neon lights"+
                "\r\nshining through their bedroom windows. Hmm...",


            //Attraction sprawl
            "Urban sprawl is the outward spread of development from urban centers into rural areas."+
                "\r\nIt is typically unorganized and poorly planned, cutting off wildlife habitats while wreaking"+
                "\r\nhavoc on natural land. Hmm...",

            //Attraction water
            "An overabundance of wastewater can overwhelm water treatment systems. If there’s"+
                "\r\nmore waste than the plant was designed to treat, untreated waste can be released to"+
                "\r\nsurface water. Hmm...",

            //Attraction energy
            "Urban cities use up 70% of global energy and these figures are projected to only"+
                "\r\nincrease overtime. How should we most effectively manage our energy use?",

            //Attraction noise
            "Noise pollution also impacts the health and well-being of wildlife. Studies have shown"+
                "\r\nthat loud noises cause caterpillars’ hearts to beat faster and bluebirds to have fewer"+
                "\r\nchicks. Hmm...",
            
            //Attraction traffic 
            "Traffic congestion increases vehicle emissions and degrades ambient air quality, and"+
                "\r\nincreases mortality for drivers, commuters and individuals living near major roadways."+
                "\r\nHmm...",

        };


        string[] challenge = {
            //slums Question
            "How should we go about improving living conditions for residents of these slums?",
            //garbage Question
            "How should we go about reducing waste contamination?",
            //light Question
            "How should we reduce harsh light pollution?",
            //sprawl
            "How should we better develop our cities?",
            //water
            "How should we ensure waste water stays within treatment plants?",
            //energy
            "How should we more effectively manage our energy use?",
            //noise question
            "How should we go about reducing loud noises from cities?",
            //traffic
            "How should we combat rush hour blues?",
        };

        public bool completion()
        {
            if (counter == 0)
            {
                slumsCompleted = true;
                return true;

            }
            else if (counter == 1)
            {
                garbageCompleted = true;
                return true;

            }
            else if (counter == 2)
            {
                lightCompleted = true;
                return true;
            }
            else if (counter == 3)
            {
                sprawlCompleted = true;
                return true;
            }
            else if (counter == 4)
            {
                waterCompleted = true;
                return true;
            }
            else if (counter == 5)
            {
                energyCompleted = true;
                return true;
            }
            else if (counter == 6)
            {
                noiseCompleted = true;
                return true;
            }
            else if (counter == 7)
            {
                trafficCompleted = true;
                return true;
            }
            return false;
        }
        private void reward()
        {
            if (slumsCompleted == true &&
             garbageCompleted == true &&
             lightCompleted == true &&
             sprawlCompleted == true &&
             waterCompleted == true &&
             energyCompleted == true &&
             noiseCompleted == true &&
             trafficCompleted == true)
            {
                //MessageBox.Show("Congrats! Hope you had fun in the city"+"\r\nKeep looking around"+"\r\nYour score is"+(score/8));
                this.Close();
                var form3 = new Form3();
                form3.Show();
            }
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            pnl_prompts.Hide();
        }

        private void btn_done_Click_1(object sender, EventArgs e)
        {
            pnl_prompts.Hide();
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
                        btn_done.Enabled = true;
                    }
                    else
                    {
                        result3();
                        choice1WasClicked = false;
                        i = 0;
                        btn_done.Enabled = true;
                    }
                }

                else if (i == 1 && choice2WasClicked == true)
                {
                    if (Choice2 == correct_ans[counter])
                    {
                        result2();
                        choice2WasClicked = false;
                        i = 0;
                        btn_done.Enabled = true;
                    }
                    else
                    {
                        result3();
                        choice2WasClicked = false;
                        i = 0;
                        btn_done.Enabled = true;
                    }
                }
                else if (i == 1 && choice3WasClicked == true)
                {
                    if (Choice3 == correct_ans[counter])
                    {
                        result2();
                        choice3WasClicked = false;
                        i = 0;
                        btn_done.Enabled = true;
                    }
                    else
                    {
                        result3();
                        choice3WasClicked = false;
                        i = 0;
                        btn_done.Enabled = true;
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
            //Global.endTime += 20;
        }

        private void result2()
        {
            lbl_feedback.Show();
            lbl_feedback.Text = "Phew, you made the right decision";
            Global.score += 1;
            score += 1;
            chance = 1;
            btn_done.Show();
            buttons_disable();
            //Global.endTime += 5;
            completion();
        }

        private void result3()
        {
            lbl_feedback.Show();
            lbl_feedback.Text = "The correct answer is" + "\r\n" + correct_ans[counter];
            chance = 1;
            btn_done.Show();
            buttons_disable();
        }

        private void result4()
        {
            lbl_feedback.Show();
            lbl_feedback.Text = "Ding! Try again! Earth needs you";
            chance = 2;
            //Global.endTime -= 20;
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            if (score < 6)
            {
                MessageBox.Show("Dont leave yet! You haven't finished exploring around");
            }
            else
            {
                this.Close();
                var f3 = new Form3();
                f3.Show();
                //reward();
                MessageBox.Show("Congrats! Hope you had fun walking around the city" + "\r\nKeep looking around" + "\r\nYour score is " + score + "/ 8");
            }
        }

        private void btn_task_Click(object sender, EventArgs e)
        {
            lbl_context.Text = challenge[counter];
            Choices_show(choice1[counter], choice2[counter], choice3[counter]);
            buttons_enable();
        }

        private void btn_Choice1_Click(object sender, EventArgs e)
        {
            choice1WasClicked = true;
            Evaluation(choice1[counter], choice2[counter], choice3[counter]);
        }

        private void btn_Choice2_Click(object sender, EventArgs e)
        {
            choice2WasClicked = true;
            Evaluation(choice1[counter], choice2[counter], choice3[counter]);
        }

        private void btn_Choice3_Click(object sender, EventArgs e)
        {
            choice3WasClicked = true;
            Evaluation(choice1[counter], choice2[counter], choice3[counter]);
        }

        private void pic_slums_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = slums;
            lbl_context.Text = attraction[counter];
            if (slumsCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }

        }

        private void pic_garbage_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = garbage;
            lbl_context.Text = attraction[counter];
            if (garbageCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }

        }

        private void pic_light_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = light;
            lbl_context.Text = attraction[counter];
            if (lightCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_sprawl_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = sprawl;
            lbl_context.Text = attraction[counter];
            if (sprawlCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_water_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = water;
            lbl_context.Text = attraction[counter];
            if (waterCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_energy_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = energy;
            lbl_context.Text = attraction[counter];
            if (energyCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_noise_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = noise;
            lbl_context.Text = attraction[counter];
            if (noiseCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_traffic_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = traffic;
            lbl_context.Text = attraction[counter];
            if (trafficCompleted == true)
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

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            pnl_prompts.Hide();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            pnl_prompts.Hide();
        }
    }
}
