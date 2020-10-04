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
    public partial class Form1 : Form
    {
        public Form1()
        {
            //at initialization of the program: 
            InitializeComponent();
            btn_startGame.Text = "Continue";
            btn_instructions.Visible = false;



            //check if player is coming back from instructions page 
            if (Global.playerName!= null)
            {
                UpdateStartScreen();
            }

        }
        public void UpdateStartScreen()
        {
            btn_startGame.Text = "Start Game!";
            btn_instructions.Visible = true;
            txtBox_playerName.Visible = false;
            lbl_Welcome.Text = "Welcome " + Global.playerName + "!";
            lbl_startScreenText.Visible = false;
        }

        private void btn_startGame_Click_1(object sender, EventArgs e)
        {
            //when the start game button is clicked, the start screen panel yeets out 
            if (btn_startGame.Text == "Start Game!")
            {
                this.Hide();
                Global.ShowForm3();
                
            }
            else
            {
                UpdateStartScreen();
            }
            //being safe 
            if (String.IsNullOrEmpty(txtBox_playerName.Text))
            {
                txtBox_playerName.Text = "Please input a valid name";
            }

        }

        //event for pressing any key down 
        private void txtBox_playerName_KeyDown(object sender, KeyEventArgs e)
        {
            //when user presses the enter key
            if (e.KeyCode == Keys.Enter)
            {
                //if they decide to- yeah that 
                
                if (String.IsNullOrEmpty(txtBox_playerName.Text))
                {
                    txtBox_playerName.Text = "Please input a valid name";
                }
                
                //if they accidentally hit the enter key again lmao 
                else if (txtBox_playerName.Text == "Please input a valid name")
                {
                    txtBox_playerName.Text = "";
                }
                else
                {
                    //pressing enter == pressing continue button
                    btn_startGame.PerformClick();
                    //save inputted text in textbox as name var
                    Global.playerName = txtBox_playerName.Text;
                    //player obj instantiation woo, passing in the name 
                    
                    //user user = new user(Global.playerName);
                    UpdateStartScreen();
                }
            }
        }
        private void btn_instructions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowForm2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1055, 725);

            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
