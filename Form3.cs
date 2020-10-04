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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Global.timer.Tick += new EventHandler(timer1_Tick);
            Global.timer.Start();
            
            this.DoubleBuffered = true;
            Global.timer.Interval = 1000;

        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowForm2();
            Global.timer.Stop();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1100, 700);
        }

        //navigate to great barrier reef
        private void picBox_greatBarrierReef_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowReef();
        }

        //navigate to arctic
        private void picBox_arctic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowArctic();
        }

        //navigate the tar sands
       /* private void picBox_tarSands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowTarSands();
        }*/

        //TIMER STUFF 
        private void timer1_Tick(object sender, EventArgs e)
        {
            Global.endTime--;
            lbl_mins.Text = (Global.endTime / 60).ToString() + ":" + (Global.endTime % 60).ToString();  

        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            pnl_quit.Visible = true;
            Global.timer.Stop();
        }

        private void btn_quitGame_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pnl_quit.Visible = false;
            Global.timer.Start();
        }

      
    }
}
