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
    public partial class Rainforest : Form
    {
        public Rainforest()
        {
            InitializeComponent();
        }

        private void Rainforest_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(930, 600);
        }

        int tree = 0;
        int mine = 1;
        int animal = 2;
        int pet = 3;
        int village = 4;
        int river = 5;
        int fire = 6;
        int dam = 7;

        int i = 0;

        int counter = 0;
        int score = 0;
        int chance = 1;

        bool treeCompleted = false;
        bool mineCompleted = false;
        bool animalCompleted = false;
        bool petCompleted = false;
        bool villageCompleted = false;
        bool riverCompleted = false;
        bool fireCompleted = false;
        bool damCompleted = false;

        bool choice1WasClicked = false;
        bool choice2WasClicked = false;
        bool choice3WasClicked = false;

        string[] correct_ans = {
            //tree
            "Restore damaged ecosystems by replanting trees and support companies that operate ethically",
            //mine
            "Develop other sectors like agroforestry To drive workers away from illegal mining",
            //animal
            "Work in collaboration with rural communities to interrupt the cycle of poverty that drives these practices",
            //pet
            "Increase efforts to detect and seize illegal products at airports and other major gateways to convict those responsible",
            //village
            "Donate to foundations that will support and indigenous and local rainforest communities to help local economy",
            //river
            "",
            //fire
            "",
            //dam
            "Utilize clean energy alternatives like wind and solar energy instead of hydropower",
        };

        //string answer;
        string[] choice1 = {
            //tree
            "Close off forests as untouchable parks and reserves and drive companies out of these areas through physical manipulation",
             //mine
            "Develop other sectors like agroforestry To drive workers away from illegal mining",
            //animal
            "Work in collaboration with rural communities to interrupt the cycle of poverty that drives these practices",
            //pet
            "Conduct random searches of foreign travellers in their accomodations in order to track down suspicious activity",
            //village
            "Donate to foundations that will support and indigenous and local rainforest communities to help local economy",
            //river
            "",
            //fire
            "",
            //dam
            "Plug existing dams so they are no longer able to flow into rainforests"

        };
        string[] choice2 = {
            //tree
            "Restore damaged ecosystems by replanting trees and support companies that operate ethically",
            //mine
            "Enforce police action and heavy punishments for mining workers to scare these illegal organizations",
            //animal
            "The livelihoods of the people behind these acts are more important than the animals",
            //pet
            "Breed these animals and plants in order to sell locally, thus helping the native economy",
            //village
            "Construct new buildings with better infrastructure around the rainforest and move these populations into them",
            //river
            "",
            //fire
            "",
            //dam
            "Operate these dams during scheduled times to reduce the stress they pose on the rainforests"
        };
        string[] choice3 = {
            //tree
            "Set traps around the rainforests to deter enemies",
            //mine
            "Try to reason with illegal organizations and strike a deal through monetary means",
            //animal
            "Give money to rural groups so that they will move away from the rainforest and stop committing these acts",
            //pet
            "Increase efforts to detect and seize illegal products at airports and other major gateways to convict those responsible",
            //village
            "Use police to help protect these communities",
            //river
            "",
            //fire
            "",
            //dam
            "Utilize clean energy alternatives like wind and solar energy instead of hydropower",
        };

        string[] attraction = {
            //attraction tree
            "Rainforest trees are being cut down for timber used in flooring, furniture, and other" +
                "\r\ncommercial items. In addition, nearby power plants and other industries cut and burn" +
                "\r\nthese trees to generate electricity. Through deforestation, animal habitats are being" +
                "\r\nthreatened and climate change is accelerated. Hmm...",

            //Attraction mine
            "Illegal mining practices not only requires clearcutting rainforests, but downstream"+
                "\r\naquatic habitats fare worse. Increased sediment loads and reduced water flows can"+
                "\r\nobliterate affect local fish populations and wipe out fresh water sources. Hmm...",

            //Attraction animal
            "Several species of toucans, parrots and other tropical birds of the South and Central"+
                "\r\nAmerican rainforests are threatened with extinction due to unregulated agriculture and tourism."+
                "\r\nA wide range of mammal species are losing their homes in the rainforest, from"+
                "\r\nthe smallest rodent to the largest predator. Hmm...",

            //Attraction pet
            "Many people take plants and animals from the Amazon to sell abroad as pets, food, and"+
                "\r\nmedicine. Foreigners do not share the enormous profits from these products with the"+
                "\r\ncountry of origin, and trade in these animals leads to declines in wild populations,"+
                "\r\naffecting animals already threatened by habitat destruction and pollution. Hmm...",

            //Attraction village
            "With reduced forests, native rainforest villages are less able to coexist from the natural"+
                "\r\nresources these ecosystems provide. This can lead to increased poverty and"+
                "\r\ndisplacement, as these groups may need to move in order to find a new home. Hmm...",

            //Attraction river
            "Many species of amphibians are also losing their homes due to oil drilling and mining"+
                "\r\npractices that contaminate ponds, rivers and streams, forcing them to find new sources"+
                "\r\nof water for their semi aquatic lifestyles. Threatened and endangered reptile and"+
                "\r\namphibian species include the golden toad, the Madagascar day gecko and iguanas, as"+
                "\r\nwell as several species of poison dart frogs, most notably those of Colombia. Interesting!",

            //Attraction fire
            "Agribusinesses clear vast stretches  of untouched forest to make room for cattle pasture"+
                "\r\nand cropland. The cheapest and quickest way to do this in such humid conditions is to"+
                "\r\ncut down the trees and underbrush with chainsaws, let them dry out for a month, and get"+
                "\r\nrid of the debris by burning it. Burning the rainforest is like creating a huge bonfire,"+
                "\r\nthrowing massive amounts of carbon dioxide into the atmosphere. Carbon dioxide"+
                "\r\n is a 'greenhouse gas', which helps to retain the heat of the sun within the Earth's"+
                "\r\natmosphere. Tropical deforestation contributes 17% of the world’s annual" +
                "greenhouse gas emissions. Interesting!",
            
            //Attraction dam 
            "Dams are often referred to as sources of green energy, but in the tropics, the story is"+
                "\r\nvery different. Dams in the tropics release greenhouse gases in two ways. Carbon is"+
                "\r\nreleased from soil carbon stocks and dying vegetation when the reservoir is flooded, and"+
                "\r\nmethane is formed where organic matter decays under low oxygen conditions at the"+
                "\r\nbottom of the reservoir. Hmm...",

        };


        string[] challenge = {
            //tree Question
            "How should we go about improving living conditions for residents of these tree?",
            //mine Question
            "How should we go about reducing waste contamination?",
            //animal Question
            "How should we reduce harsh animal pollution?",
            //pet
            "How should we better develop our cities?",
            //village
            "How should we ensure waste village stays within treatment plants?",
            //river
            "How should we more effectively manage our river use?",
            //fire question
            "How should we go about reducing loud fires from cities?",
            //dam
            "How should we combat rush hour blues?",
        };

        public bool completion()
        {
            if (counter == 0)
            {
                treeCompleted = true;
                return true;

            }
            else if (counter == 1)
            {
                mineCompleted = true;
                return true;

            }
            else if (counter == 2)
            {
                animalCompleted = true;
                return true;
            }
            else if (counter == 3)
            {
                petCompleted = true;
                return true;
            }
            else if (counter == 4)
            {
                villageCompleted = true;
                return true;
            }
            else if (counter == 5)
            {
                riverCompleted = true;
                return true;
            }
            else if (counter == 6)
            {
                fireCompleted = true;
                return true;
            }
            else if (counter == 7)
            {
                damCompleted = true;
                return true;
            }
            return false;
        }
        private void reward()
        {
            if (treeCompleted == true &&
             mineCompleted == true &&
             animalCompleted == true &&
             petCompleted == true &&
             villageCompleted == true &&
             riverCompleted == true &&
             fireCompleted == true &&
             damCompleted == true)
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
            if (score < 4)
            {
                MessageBox.Show("Dont leave yet! You haven't finished exploring around");
            }
            else
            {
                this.Close();
                var f3 = new Form3();
                f3.Show();
                //reward();
                MessageBox.Show("Congrats! Hope you had fun chilling in the rainforest" + "\r\nKeep looking around" + "\r\nYour score is " + score + "/ 6");
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

        private void pic_tree_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = tree;
            lbl_context.Text = attraction[counter];
            if (treeCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }

        }

        private void pic_mine_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = mine;
            lbl_context.Text = attraction[counter];
            if (mineCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }

        }

        private void pic_animal_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = animal;
            lbl_context.Text = attraction[counter];
            if (animalCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_pet_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = pet;
            lbl_context.Text = attraction[counter];
            if (petCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_village_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = village;
            lbl_context.Text = attraction[counter];
            if (villageCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_river_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Hide();
            btn_done.Show();
            counter = river;
            lbl_context.Text = attraction[counter];
            riverCompleted = true;
            btn_exit.Enabled = true;
            if (riverCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_fire_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Hide();
            btn_done.Show();
            counter = fire;
            lbl_context.Text = attraction[counter];
            fireCompleted = true;
            btn_exit.Enabled = true;
            if (fireCompleted == true)
            {
                MessageBox.Show("You have completed the attraction");
                buttons_disable();
            }
        }

        private void pic_dam_Click(object sender, EventArgs e)
        {
            pnl_prompts.Show();
            choices_hide();
            btn_task.Show();
            buttons_enable();
            counter = dam;
            lbl_context.Text = attraction[counter];
            if (damCompleted == true)
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
