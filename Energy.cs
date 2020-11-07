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
    public partial class Energy : Form
    {
        string[] correct_ans = { 
           //fossil empty
            "",

            //nuclear
            "No, it's not. The air pollution is bad near nuclear power plants",

            //wind
            "It is a great idea since it's renewable and there's no harmful emission",

            //solar
            "Definitely more solar panels. It is a renewable energy",

            //lignite
            "It is usually mined near the power plant",

            //hardcoal empty
            "",

            //CHP
            "Switching to combined heat and power will help our energy use more efficient",

            //ETS
             "The coal may be imported by other countries and cause more pollution",

            //phase out
            "It might be hard, but worth the effort to push renewable energy",

            //distribution
            "It's looking good since we are using more renewable energy"

        };

        string[] choice1 = { 
            //fossil empty
            "",

            //nuclear
            "Yes, it is a renewable energy since we are not burning fossil fuels",

            //wind
            "It is a great idea since it's renewable and there's no emission",

            //solar
            "What happens if it rains everyday?",

            //lignite
            "They still produces a lot of electricity and power",

            //hardcoal empty
            "",

            //CHP
            "It's gonna be more expensive, isn't it?",

            //ETS
            "The coal may be imported by other countries and cause more pollution",

            //phase out
            "No, we should keep it like now",

            //distribution
            "Are we producting less and less energy?"

        };

        string[] choice2 = { 
            //fossil empty
            "",

            //nuclear
            "No, it's not. The air pollution is bad near nuclear power plants",

            //wind
            "Wind produces enough energy? Jokes",

            //solar
            "No, they are expensive to install",

            //lignite
            "It is hard to switch to other forms of energy",

            //hardcoal empty
            "",

            //CHP
            "Switching to combined heat and power will help our energy use more efficient",

            //ETS
            "Because Germany wants to keep the coal to themselves",

            //phase out
            "It might be hard, but worth the effort to push renewable energy",

            //distribution
            "Well, lignite is still cheaper to use, keep lignite"

        };
        string[] choice3 = { 
            //fossil empty
            "",

            //nuclear
            "Definitely, Uranium doesn't run out",

            //wind
            "What if there is no wind?",

            //solar
            "Definitely more solar panels. It is a renewable energy",

            //lignite
            "It does not make as much pollution as hard coal does",

            //hardcoal empty
            "",

            //CHP
            "It sounds complicated, people may not like it",

            //ETS
            "Because EU is not giving Germany good deals",

            //phase out
            "I think it is impossible to do it",

            //distribution
            "It's looking good since we are using more renewable energy"

        };
        string[] attraction = { 
            //fossil
            "Germany’s largest source of domestic fossil fuel is coal, " +
                "\r\nthe main energy consumption also came from fossil fuel" +
                "\r\nbut its consumption decreased dramatically in 2019 and of 2020 due to the phase-out plan.",

            //nuclear
            "Germany has six nuclear power reactors in operation, and is still phasing out of nuclear power" +
                "\r\nIn 2019, NPPs contributed approximately 12.4% to the gross electricity production - 75.1 TWh" +
                "\r\nThe pashing out plan is due to the nuclear disasters happened in history" +
                "\r\nand the deadly amount of air pollution",

            //wind
            "Wind-generated electricity produced the largest share of renewable energy"+
                "\r\nIt took up nearly 49% fo renewable energy production in 2017."+
                "\r\nGermany has 29,844 wind turbines" +
                "\r\nwhich account for nearly 56 GW of installed wind power capacity",

            //solar
            "In 2019, Solar Power porduced about eight percent of the counter's new power consumption"+
                "\r\nSolar power takes up 43% of the total renewable energy share" +
                "\r\nOverall, solar power arrays fed over 47 TWh of power into the grid in 2019",

            //lignite
            "Lignite still enjoys a competitive advantage on the energy market" +
                "\r\nIt is mined very near the power stations and therefore cheap to produce and use for utilities." +
                "\r\nThe share of power from lignite fell from 31.1 percent in 1990 to 22.5 percent in 2018." +
                "\r\nIn 2018, hard coal provided 12.8 percent of Germany’s gross power generation, down from 25.6 percent in 1990.",

            //hard coal
            "83 billion tonnes of hard coal still in the ground in Germany, " +
                "\r\nonly 36 million tonnes are considered mineable" +
                "\r\nThe hard mining process makes hard coal much more expensive in the market",

            //CHP
            "Combined heat and power is part of both the heat and the electricity markets." +
                "\r\nAn increasing number of homes will be heated using heat pumps that run on electricity." +
                "\r\nAs the electricity and heat sectors are transformed," +
                "\r\nthe role that CHP plays for these two sectors is changing as well",

            //ETS
            "As Germnay phases out of coal" +
                "\r\nthe demand for emission allowances in EU's Emission Tradition System will fall" +
                "\r\nGermany is planng to cancel the ETS to avoid the coal will be used elsewhere in Europe",

            //phase out
            "Germany is planing to reduced the use of lignite and hard coal to:" +
                "\r\n15 gigawatt (GW) hard coal and 15 GW lignite capacity by the end of 2022" +
                "\r\n8 GW hard coal and about 9 GW lignite are to remain by 2030"+
                "\r\nBy the end of 2038 at the latest, " +
                "\r\nthere will be no coal power capacities left as the phase-out is completed",

            //distribution
            "Solar, wind and other renewables accounted for 78% of Germany’s electricity output in 2019" +
                "\r\nUp to 46.1% of energy supplying is coming from renewable energy"

        };

        string[] challenge = { 
            //fossil empty
            "",

            //nuclear
            "Is Nuclear Power Energy considered a clean/renewablw energy?",

            //wind
            "What do you think about the increasing wind power plants?",

            //solar
            "Should Germany install more solar panels?",

            //lignite
            "what is about lignite that it is still competitive in the market",

            //hardcoal empty
            "",

            //CHP
            "Should we swtich more communities to combined heat and power?",

            //ETS
            "What makes Germany want to quit ETS?",

            //phase out
            "Do you agree with Germany's phase out plan?",

            //distribution
            "Do you think the trend of energy distribution is looking good over years?"

        };


        public Energy()
        {
            InitializeComponent();
            lbl_energyWel.Text = "Welcome to Germany" + "\r\nAre you ready to live in a clean energy world?" + "\r\nClick on any attraction to learn about how Germany is greener than ever";
            pnl_prompt.Hide();
        }
       

        private void Energy_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1200, 800);
        }

        int fossilFuel= 0;
        int nuclear = 1;
        int wind = 2;
        int solar = 3;
        int lignite = 4;
        int hardCoal = 5;
        int CHP = 6;
        int ETS = 7;
        int phaseOut = 8;
        int distribution = 9;


        int counter = 0;
        int score = 0;
        int i = 0;


        // a bool for each attraction to signify if it is completed already
        // need this to disable the collision after the attraction is finished
        bool fossilCompleted = false;
        bool nuclearCompleted = false;
        bool windCompleted = false;
        bool solarCompleted = false;
        bool ligniteCompleted = false;
        bool hardCoalCompleted = false;
        bool CHPCompleted = false;
        bool ETSCompleted = false;
        bool phaseOutCompleted = false;
        bool distributionCompleted = false;

        bool choice1WasClicked = false;
        bool choice2WasClicked = false;
        bool choice3WasClicked = false;

        public bool completion()
        {
            if (counter == 0)
            {
                fossilCompleted = true;
                return true;

            }
            else if (counter == 1)
            {
                nuclearCompleted = true;
                return true;

            }
            else if (counter == 2)
            {
                windCompleted = true;
                return true;
            }
            else if (counter == 3)
            {
                solarCompleted = true;
                return true;
            }
            else if (counter == 4)
            {
                ligniteCompleted = true;
                return true;
            }
            else if (counter == 5)
            {
                hardCoalCompleted = true;
                return true;
            }
            else if (counter == 6)
            {
                CHPCompleted = true;
                return true;
            }
            else if (counter == 7)
            {
                ETSCompleted = true;
                return true;
            }
            else if (counter == 8)
            {
                phaseOutCompleted = true;
                return true;
            }
            else if (counter == 9)
            {
                distributionCompleted = true;
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

        //no challenge
        private void picBox_fossil_Click(object sender, EventArgs e)
        {
            pnl_prompt.Show();
            choices_hide();
            btn_task.Hide();
            btn_done.Show();
            counter = fossilFuel;
            lbl_context.Text = attraction[counter];
            hardCoalCompleted = true;
            btn_Exit.Enabled = true;
            if (fossilCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_wind_Click(object sender, EventArgs e)
        {
            pnl_prompt.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = wind;
            lbl_context.Text = attraction[counter];
            if (windCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_nuclear_Click(object sender, EventArgs e)
        {
            pnl_prompt.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = nuclear;
            lbl_context.Text = attraction[counter];
            if (nuclearCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_lignite_Click(object sender, EventArgs e)
        {
            pnl_prompt.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = lignite;
            lbl_context.Text = attraction[counter];
            if (ligniteCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_distribution_Click(object sender, EventArgs e)
        {
            pnl_prompt.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = distribution;
            lbl_context.Text = attraction[counter];
            if (distributionCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_ETS_Click(object sender, EventArgs e)
        {
            pnl_prompt.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = ETS;
            lbl_context.Text = attraction[counter];
            if (ETSCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_solar_Click(object sender, EventArgs e)
        {
            pnl_prompt.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = solar;
            lbl_context.Text = attraction[counter];
            if (solarCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        //no challenge
        private void picBox_hardCoal_Click(object sender, EventArgs e)
        {
            pnl_prompt.Show();
            choices_hide();
            btn_task.Hide();
            btn_done.Show();
            counter = hardCoal;
            lbl_context.Text = attraction[counter];
            hardCoalCompleted = true;
            btn_Exit.Enabled = true;
            if (hardCoalCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_CHP_Click(object sender, EventArgs e)
        {
            pnl_prompt.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = CHP;
            lbl_context.Text = attraction[counter];
            if (CHPCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void picBox_phaseOut_Click(object sender, EventArgs e)
        {
            pnl_prompt.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = phaseOut;
            lbl_context.Text = attraction[counter];
            if (phaseOutCompleted == true)
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            pnl_prompt.Hide();
        }

        private void btn_task_Click(object sender, EventArgs e)
        {
            lbl_context.Text = challenge[counter];
            Choices_show(choice1[counter], choice2[counter], choice3[counter]);
            buttons_enable();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            pnl_prompt.Hide();
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

        private void btn_leave_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowForm3();
        }
    }
}
