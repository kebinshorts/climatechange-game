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
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_instructions = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(189, 849);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(149, 76);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back to Start";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "How to play:";
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.AutoSize = true;
            this.lbl_instructions.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instructions.Location = new System.Drawing.Point(277, 74);
            this.lbl_instructions.Name = "lbl_instructions";
            this.lbl_instructions.Size = new System.Drawing.Size(61, 21);
            this.lbl_instructions.TabIndex = 2;
            this.lbl_instructions.Text = "(instr)";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(627, 849);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(149, 76);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start Game!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 977);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_instructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Instructions";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_instructions;
        private System.Windows.Forms.Button btn_start;
    }
}