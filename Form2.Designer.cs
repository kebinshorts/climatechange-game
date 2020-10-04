namespace Nasa_Game
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_instructions = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.pnl_instr = new System.Windows.Forms.Panel();
            this.lbl_headLine = new System.Windows.Forms.Label();
            this.lbl_clearArea = new System.Windows.Forms.Label();
            this.lbl_lockedAreas = new System.Windows.Forms.Label();
            this.lbl_ca = new System.Windows.Forms.Label();
            this.lbl_la = new System.Windows.Forms.Label();
            this.lbl_mission = new System.Windows.Forms.Label();
            this.lbl_mission2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_quitGame = new System.Windows.Forms.Button();
            this.pnl_instr.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(125, 1236);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(163, 76);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back to Start";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Orbitron", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(764, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "How to play:";
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.AutoSize = true;
            this.lbl_instructions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_instructions.Font = new System.Drawing.Font("Viner Hand ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instructions.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_instructions.Location = new System.Drawing.Point(382, 103);
            this.lbl_instructions.Name = "lbl_instructions";
            this.lbl_instructions.Size = new System.Drawing.Size(111, 45);
            this.lbl_instructions.TabIndex = 2;
            this.lbl_instructions.Text = "(instr)";
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(1556, 1236);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(163, 76);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start Game!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pnl_instr
            // 
            this.pnl_instr.AutoScroll = true;
            this.pnl_instr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_instr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_instr.BackgroundImage")));
            this.pnl_instr.Controls.Add(this.panel2);
            this.pnl_instr.Controls.Add(this.panel1);
            this.pnl_instr.Controls.Add(this.lbl_mission2);
            this.pnl_instr.Controls.Add(this.lbl_mission);
            this.pnl_instr.Controls.Add(this.lbl_headLine);
            this.pnl_instr.Controls.Add(this.lbl_instructions);
            this.pnl_instr.Location = new System.Drawing.Point(125, 108);
            this.pnl_instr.Name = "pnl_instr";
            this.pnl_instr.Size = new System.Drawing.Size(1594, 1107);
            this.pnl_instr.TabIndex = 4;
            // 
            // lbl_headLine
            // 
            this.lbl_headLine.AutoSize = true;
            this.lbl_headLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_headLine.Font = new System.Drawing.Font("Orbitron", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headLine.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_headLine.Location = new System.Drawing.Point(192, 31);
            this.lbl_headLine.Name = "lbl_headLine";
            this.lbl_headLine.Size = new System.Drawing.Size(75, 43);
            this.lbl_headLine.TabIndex = 3;
            this.lbl_headLine.Text = "(hl)";
            // 
            // lbl_clearArea
            // 
            this.lbl_clearArea.AutoSize = true;
            this.lbl_clearArea.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clearArea.Location = new System.Drawing.Point(172, 13);
            this.lbl_clearArea.Name = "lbl_clearArea";
            this.lbl_clearArea.Size = new System.Drawing.Size(194, 33);
            this.lbl_clearArea.TabIndex = 4;
            this.lbl_clearArea.Text = "(clear area)";
            // 
            // lbl_lockedAreas
            // 
            this.lbl_lockedAreas.AutoSize = true;
            this.lbl_lockedAreas.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lockedAreas.Location = new System.Drawing.Point(211, 13);
            this.lbl_lockedAreas.Name = "lbl_lockedAreas";
            this.lbl_lockedAreas.Size = new System.Drawing.Size(234, 33);
            this.lbl_lockedAreas.TabIndex = 5;
            this.lbl_lockedAreas.Text = "(locked areas)";
            // 
            // lbl_ca
            // 
            this.lbl_ca.AutoSize = true;
            this.lbl_ca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ca.Font = new System.Drawing.Font("OCR A Extended", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ca.Location = new System.Drawing.Point(3, 78);
            this.lbl_ca.Name = "lbl_ca";
            this.lbl_ca.Size = new System.Drawing.Size(166, 24);
            this.lbl_ca.TabIndex = 6;
            this.lbl_ca.Text = "(clear area)";
            // 
            // lbl_la
            // 
            this.lbl_la.AutoSize = true;
            this.lbl_la.BackColor = System.Drawing.Color.Transparent;
            this.lbl_la.Font = new System.Drawing.Font("OCR A Extended", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_la.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_la.Location = new System.Drawing.Point(4, 78);
            this.lbl_la.Name = "lbl_la";
            this.lbl_la.Size = new System.Drawing.Size(192, 24);
            this.lbl_la.TabIndex = 7;
            this.lbl_la.Text = "(locked areas)";
            // 
            // lbl_mission
            // 
            this.lbl_mission.AutoSize = true;
            this.lbl_mission.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_mission.Font = new System.Drawing.Font("Orbitron", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mission.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_mission.Location = new System.Drawing.Point(640, 159);
            this.lbl_mission.Name = "lbl_mission";
            this.lbl_mission.Size = new System.Drawing.Size(167, 38);
            this.lbl_mission.TabIndex = 8;
            this.lbl_mission.Text = "(mission)";
            // 
            // lbl_mission2
            // 
            this.lbl_mission2.AutoSize = true;
            this.lbl_mission2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_mission2.Font = new System.Drawing.Font("Viner Hand ITC", 14F);
            this.lbl_mission2.ForeColor = System.Drawing.Color.Orange;
            this.lbl_mission2.Location = new System.Drawing.Point(455, 231);
            this.lbl_mission2.Name = "lbl_mission2";
            this.lbl_mission2.Size = new System.Drawing.Size(161, 45);
            this.lbl_mission2.TabIndex = 9;
            this.lbl_mission2.Text = "(mission2)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.lbl_clearArea);
            this.panel1.Controls.Add(this.lbl_ca);
            this.panel1.Location = new System.Drawing.Point(44, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 665);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_lockedAreas);
            this.panel2.Controls.Add(this.lbl_la);
            this.panel2.Location = new System.Drawing.Point(872, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 665);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(559, 1254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(742, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Now it is on you to save our Planet. Good Luck.";
            // 
            // btn_quitGame
            // 
            this.btn_quitGame.Font = new System.Drawing.Font("Orbitron", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitGame.Location = new System.Drawing.Point(1591, 34);
            this.btn_quitGame.Name = "btn_quitGame";
            this.btn_quitGame.Size = new System.Drawing.Size(128, 48);
            this.btn_quitGame.TabIndex = 5;
            this.btn_quitGame.Text = "Quit Game";
            this.btn_quitGame.UseVisualStyleBackColor = true;
            this.btn_quitGame.Click += new System.EventHandler(this.btn_quitGame_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1806, 1410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_quitGame);
            this.Controls.Add(this.pnl_instr);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Instructions";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnl_instr.ResumeLayout(false);
            this.pnl_instr.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_instructions;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel pnl_instr;
        private System.Windows.Forms.Label lbl_clearArea;
        private System.Windows.Forms.Label lbl_headLine;
        private System.Windows.Forms.Label lbl_la;
        private System.Windows.Forms.Label lbl_ca;
        private System.Windows.Forms.Label lbl_lockedAreas;
        private System.Windows.Forms.Label lbl_mission;
        private System.Windows.Forms.Label lbl_mission2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_quitGame;
    }
}