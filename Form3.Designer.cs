namespace Nasa_Game
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.picBox_renewableEnergy = new System.Windows.Forms.PictureBox();
            this.picBox_city = new System.Windows.Forms.PictureBox();
            this.picBox_greatBarrierReef = new System.Windows.Forms.PictureBox();
            this.picBox_amazon = new System.Windows.Forms.PictureBox();
            this.picBox_arctic = new System.Windows.Forms.PictureBox();
            this.picBox_space = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_mins = new System.Windows.Forms.Label();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.pnl_quit = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_quitGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_renewableEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_city)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_greatBarrierReef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_amazon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_arctic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_space)).BeginInit();
            this.pnl_quit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 945);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1002, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your journey to save the world starts here...";
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(1504, 33);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(100, 46);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // picBox_renewableEnergy
            // 
            this.picBox_renewableEnergy.Image = ((System.Drawing.Image)(resources.GetObject("picBox_renewableEnergy.Image")));
            this.picBox_renewableEnergy.Location = new System.Drawing.Point(784, 210);
            this.picBox_renewableEnergy.Name = "picBox_renewableEnergy";
            this.picBox_renewableEnergy.Size = new System.Drawing.Size(175, 160);
            this.picBox_renewableEnergy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_renewableEnergy.TabIndex = 3;
            this.picBox_renewableEnergy.TabStop = false;
            // 
            // picBox_city
            // 
            this.picBox_city.Image = ((System.Drawing.Image)(resources.GetObject("picBox_city.Image")));
            this.picBox_city.Location = new System.Drawing.Point(1313, 325);
            this.picBox_city.Name = "picBox_city";
            this.picBox_city.Size = new System.Drawing.Size(175, 160);
            this.picBox_city.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_city.TabIndex = 5;
            this.picBox_city.TabStop = false;
            // 
            // picBox_greatBarrierReef
            // 
            this.picBox_greatBarrierReef.Image = ((System.Drawing.Image)(resources.GetObject("picBox_greatBarrierReef.Image")));
            this.picBox_greatBarrierReef.Location = new System.Drawing.Point(1429, 543);
            this.picBox_greatBarrierReef.Name = "picBox_greatBarrierReef";
            this.picBox_greatBarrierReef.Size = new System.Drawing.Size(175, 160);
            this.picBox_greatBarrierReef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_greatBarrierReef.TabIndex = 6;
            this.picBox_greatBarrierReef.TabStop = false;
            this.picBox_greatBarrierReef.Click += new System.EventHandler(this.picBox_greatBarrierReef_Click);
            // 
            // picBox_amazon
            // 
            this.picBox_amazon.Image = ((System.Drawing.Image)(resources.GetObject("picBox_amazon.Image")));
            this.picBox_amazon.Location = new System.Drawing.Point(460, 571);
            this.picBox_amazon.Name = "picBox_amazon";
            this.picBox_amazon.Size = new System.Drawing.Size(175, 160);
            this.picBox_amazon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_amazon.TabIndex = 7;
            this.picBox_amazon.TabStop = false;
            // 
            // picBox_arctic
            // 
            this.picBox_arctic.Image = ((System.Drawing.Image)(resources.GetObject("picBox_arctic.Image")));
            this.picBox_arctic.Location = new System.Drawing.Point(192, -1);
            this.picBox_arctic.Name = "picBox_arctic";
            this.picBox_arctic.Size = new System.Drawing.Size(175, 160);
            this.picBox_arctic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_arctic.TabIndex = 8;
            this.picBox_arctic.TabStop = false;
            this.picBox_arctic.Click += new System.EventHandler(this.picBox_arctic_Click);
            // 
            // picBox_space
            // 
            this.picBox_space.Image = ((System.Drawing.Image)(resources.GetObject("picBox_space.Image")));
            this.picBox_space.Location = new System.Drawing.Point(299, 308);
            this.picBox_space.Name = "picBox_space";
            this.picBox_space.Size = new System.Drawing.Size(175, 160);
            this.picBox_space.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_space.TabIndex = 10;
            this.picBox_space.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_mins
            // 
            this.lbl_mins.AutoSize = true;
            this.lbl_mins.Font = new System.Drawing.Font("Orbitron", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mins.Location = new System.Drawing.Point(761, 1011);
            this.lbl_mins.Name = "lbl_mins";
            this.lbl_mins.Size = new System.Drawing.Size(228, 67);
            this.lbl_mins.TabIndex = 11;
            this.lbl_mins.Text = "20:00";
            // 
            // btn_Quit
            // 
            this.btn_Quit.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(1504, 96);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(100, 46);
            this.btn_Quit.TabIndex = 12;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // pnl_quit
            // 
            this.pnl_quit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_quit.Controls.Add(this.btn_cancel);
            this.pnl_quit.Controls.Add(this.btn_quitGame);
            this.pnl_quit.Controls.Add(this.label2);
            this.pnl_quit.Location = new System.Drawing.Point(1121, 96);
            this.pnl_quit.Name = "pnl_quit";
            this.pnl_quit.Size = new System.Drawing.Size(483, 211);
            this.pnl_quit.TabIndex = 13;
            this.pnl_quit.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Ink Free", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_cancel.Location = new System.Drawing.Point(308, 100);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 52);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_quitGame
            // 
            this.btn_quitGame.Font = new System.Drawing.Font("Ink Free", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitGame.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_quitGame.Location = new System.Drawing.Point(65, 100);
            this.btn_quitGame.Name = "btn_quitGame";
            this.btn_quitGame.Size = new System.Drawing.Size(102, 52);
            this.btn_quitGame.TabIndex = 1;
            this.btn_quitGame.Text = "Quit";
            this.btn_quitGame.UseVisualStyleBackColor = true;
            this.btn_quitGame.Click += new System.EventHandler(this.btn_quitGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Are you sure you want to Quit 20.9.1.?";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1746, 1244);
            this.Controls.Add(this.pnl_quit);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.lbl_mins);
            this.Controls.Add(this.picBox_space);
            this.Controls.Add(this.picBox_arctic);
            this.Controls.Add(this.picBox_amazon);
            this.Controls.Add(this.picBox_greatBarrierReef);
            this.Controls.Add(this.picBox_city);
            this.Controls.Add(this.picBox_renewableEnergy);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Navigation Map";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_renewableEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_city)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_greatBarrierReef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_amazon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_arctic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_space)).EndInit();
            this.pnl_quit.ResumeLayout(false);
            this.pnl_quit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.PictureBox picBox_renewableEnergy;
        private System.Windows.Forms.PictureBox picBox_city;
        private System.Windows.Forms.PictureBox picBox_greatBarrierReef;
        private System.Windows.Forms.PictureBox picBox_amazon;
        private System.Windows.Forms.PictureBox picBox_arctic;
        private System.Windows.Forms.PictureBox picBox_space;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_mins;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Panel pnl_quit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_quitGame;
        private System.Windows.Forms.Label label2;
    }
}