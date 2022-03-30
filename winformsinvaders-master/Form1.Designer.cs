namespace WindowsFormsApplication1
{
    partial class frmInvaders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvaders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Shot1 = new System.Windows.Forms.PictureBox();
            this.enemyshot = new System.Windows.Forms.PictureBox();
            this.Barrier2 = new System.Windows.Forms.PictureBox();
            this.Barrier1 = new System.Windows.Forms.PictureBox();
            this.inv18 = new System.Windows.Forms.PictureBox();
            this.inv16 = new System.Windows.Forms.PictureBox();
            this.inv12 = new System.Windows.Forms.PictureBox();
            this.inv10 = new System.Windows.Forms.PictureBox();
            this.inv14 = new System.Windows.Forms.PictureBox();
            this.inv6 = new System.Windows.Forms.PictureBox();
            this.inv8 = new System.Windows.Forms.PictureBox();
            this.inv17 = new System.Windows.Forms.PictureBox();
            this.inv4 = new System.Windows.Forms.PictureBox();
            this.inv11 = new System.Windows.Forms.PictureBox();
            this.inv15 = new System.Windows.Forms.PictureBox();
            this.inv2 = new System.Windows.Forms.PictureBox();
            this.inv9 = new System.Windows.Forms.PictureBox();
            this.inv13 = new System.Windows.Forms.PictureBox();
            this.inv5 = new System.Windows.Forms.PictureBox();
            this.inv7 = new System.Windows.Forms.PictureBox();
            this.inv3 = new System.Windows.Forms.PictureBox();
            this.inv1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnnewgame = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Defender = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Defender)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Defender);
            this.panel1.Controls.Add(this.enemyshot);
            this.panel1.Controls.Add(this.Shot1);
            this.panel1.Controls.Add(this.Barrier2);
            this.panel1.Controls.Add(this.Barrier1);
            this.panel1.Controls.Add(this.inv18);
            this.panel1.Controls.Add(this.inv16);
            this.panel1.Controls.Add(this.inv12);
            this.panel1.Controls.Add(this.inv10);
            this.panel1.Controls.Add(this.inv14);
            this.panel1.Controls.Add(this.inv6);
            this.panel1.Controls.Add(this.inv8);
            this.panel1.Controls.Add(this.inv17);
            this.panel1.Controls.Add(this.inv4);
            this.panel1.Controls.Add(this.inv11);
            this.panel1.Controls.Add(this.inv15);
            this.panel1.Controls.Add(this.inv2);
            this.panel1.Controls.Add(this.inv9);
            this.panel1.Controls.Add(this.inv13);
            this.panel1.Controls.Add(this.inv5);
            this.panel1.Controls.Add(this.inv7);
            this.panel1.Controls.Add(this.inv3);
            this.panel1.Controls.Add(this.inv1);
            this.panel1.Location = new System.Drawing.Point(23, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 540);
            this.panel1.TabIndex = 0;
            // 
            // Shot1
            // 
            this.Shot1.Image = ((System.Drawing.Image)(resources.GetObject("Shot1.Image")));
            this.Shot1.Location = new System.Drawing.Point(724, 459);
            this.Shot1.Name = "Shot1";
            this.Shot1.Size = new System.Drawing.Size(10, 34);
            this.Shot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shot1.TabIndex = 3;
            this.Shot1.TabStop = false;
            this.Shot1.Visible = false;
            // 
            // enemyshot
            // 
            this.enemyshot.Image = ((System.Drawing.Image)(resources.GetObject("enemyshot.Image")));
            this.enemyshot.Location = new System.Drawing.Point(698, 459);
            this.enemyshot.Name = "enemyshot";
            this.enemyshot.Size = new System.Drawing.Size(10, 34);
            this.enemyshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyshot.TabIndex = 3;
            this.enemyshot.TabStop = false;
            this.enemyshot.Visible = false;
            // 
            // Barrier2
            // 
            this.Barrier2.Location = new System.Drawing.Point(510, 458);
            this.Barrier2.Name = "Barrier2";
            this.Barrier2.Size = new System.Drawing.Size(134, 35);
            this.Barrier2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Barrier2.TabIndex = 1;
            this.Barrier2.TabStop = false;
            // 
            // Barrier1
            // 
            this.Barrier1.Location = new System.Drawing.Point(111, 458);
            this.Barrier1.Name = "Barrier1";
            this.Barrier1.Size = new System.Drawing.Size(134, 35);
            this.Barrier1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Barrier1.TabIndex = 1;
            this.Barrier1.TabStop = false;
            // 
            // inv18
            // 
            this.inv18.Image = ((System.Drawing.Image)(resources.GetObject("inv18.Image")));
            this.inv18.Location = new System.Drawing.Point(404, 130);
            this.inv18.Name = "inv18";
            this.inv18.Size = new System.Drawing.Size(40, 38);
            this.inv18.TabIndex = 0;
            this.inv18.TabStop = false;
            // 
            // inv16
            // 
            this.inv16.Image = ((System.Drawing.Image)(resources.GetObject("inv16.Image")));
            this.inv16.Location = new System.Drawing.Point(247, 130);
            this.inv16.Name = "inv16";
            this.inv16.Size = new System.Drawing.Size(40, 38);
            this.inv16.TabIndex = 0;
            this.inv16.TabStop = false;
            this.inv16.Click += new System.EventHandler(this.inv16_Click);
            // 
            // inv12
            // 
            this.inv12.Location = new System.Drawing.Point(420, 73);
            this.inv12.Name = "inv12";
            this.inv12.Size = new System.Drawing.Size(40, 38);
            this.inv12.TabIndex = 0;
            this.inv12.TabStop = false;
            // 
            // inv10
            // 
            this.inv10.Image = ((System.Drawing.Image)(resources.GetObject("inv10.Image")));
            this.inv10.Location = new System.Drawing.Point(263, 73);
            this.inv10.Name = "inv10";
            this.inv10.Size = new System.Drawing.Size(40, 38);
            this.inv10.TabIndex = 0;
            this.inv10.TabStop = false;
            // 
            // inv14
            // 
            this.inv14.Image = ((System.Drawing.Image)(resources.GetObject("inv14.Image")));
            this.inv14.Location = new System.Drawing.Point(93, 130);
            this.inv14.Name = "inv14";
            this.inv14.Size = new System.Drawing.Size(40, 38);
            this.inv14.TabIndex = 0;
            this.inv14.TabStop = false;
            // 
            // inv6
            // 
            this.inv6.Location = new System.Drawing.Point(404, 16);
            this.inv6.Name = "inv6";
            this.inv6.Size = new System.Drawing.Size(40, 38);
            this.inv6.TabIndex = 0;
            this.inv6.TabStop = false;
            this.inv6.Click += new System.EventHandler(this.inv6_Click);
            // 
            // inv8
            // 
            this.inv8.Image = ((System.Drawing.Image)(resources.GetObject("inv8.Image")));
            this.inv8.Location = new System.Drawing.Point(109, 73);
            this.inv8.Name = "inv8";
            this.inv8.Size = new System.Drawing.Size(40, 38);
            this.inv8.TabIndex = 0;
            this.inv8.TabStop = false;
            // 
            // inv17
            // 
            this.inv17.Image = ((System.Drawing.Image)(resources.GetObject("inv17.Image")));
            this.inv17.Location = new System.Drawing.Point(325, 130);
            this.inv17.Name = "inv17";
            this.inv17.Size = new System.Drawing.Size(40, 38);
            this.inv17.TabIndex = 0;
            this.inv17.TabStop = false;
            // 
            // inv4
            // 
            this.inv4.Location = new System.Drawing.Point(247, 16);
            this.inv4.Name = "inv4";
            this.inv4.Size = new System.Drawing.Size(40, 38);
            this.inv4.TabIndex = 0;
            this.inv4.TabStop = false;
            // 
            // inv11
            // 
            this.inv11.Image = ((System.Drawing.Image)(resources.GetObject("inv11.Image")));
            this.inv11.Location = new System.Drawing.Point(341, 73);
            this.inv11.Name = "inv11";
            this.inv11.Size = new System.Drawing.Size(40, 38);
            this.inv11.TabIndex = 0;
            this.inv11.TabStop = false;
            // 
            // inv15
            // 
            this.inv15.Image = ((System.Drawing.Image)(resources.GetObject("inv15.Image")));
            this.inv15.Location = new System.Drawing.Point(171, 130);
            this.inv15.Name = "inv15";
            this.inv15.Size = new System.Drawing.Size(40, 38);
            this.inv15.TabIndex = 0;
            this.inv15.TabStop = false;
            // 
            // inv2
            // 
            this.inv2.Location = new System.Drawing.Point(93, 16);
            this.inv2.Name = "inv2";
            this.inv2.Size = new System.Drawing.Size(40, 38);
            this.inv2.TabIndex = 0;
            this.inv2.TabStop = false;
            this.inv2.Click += new System.EventHandler(this.inv2_Click);
            // 
            // inv9
            // 
            this.inv9.Image = ((System.Drawing.Image)(resources.GetObject("inv9.Image")));
            this.inv9.Location = new System.Drawing.Point(187, 73);
            this.inv9.Name = "inv9";
            this.inv9.Size = new System.Drawing.Size(40, 38);
            this.inv9.TabIndex = 0;
            this.inv9.TabStop = false;
            // 
            // inv13
            // 
            this.inv13.Image = ((System.Drawing.Image)(resources.GetObject("inv13.Image")));
            this.inv13.Location = new System.Drawing.Point(12, 130);
            this.inv13.Name = "inv13";
            this.inv13.Size = new System.Drawing.Size(40, 38);
            this.inv13.TabIndex = 0;
            this.inv13.TabStop = false;
            // 
            // inv5
            // 
            this.inv5.Location = new System.Drawing.Point(325, 16);
            this.inv5.Name = "inv5";
            this.inv5.Size = new System.Drawing.Size(40, 38);
            this.inv5.TabIndex = 0;
            this.inv5.TabStop = false;
            // 
            // inv7
            // 
            this.inv7.Image = ((System.Drawing.Image)(resources.GetObject("inv7.Image")));
            this.inv7.Location = new System.Drawing.Point(28, 73);
            this.inv7.Name = "inv7";
            this.inv7.Size = new System.Drawing.Size(40, 38);
            this.inv7.TabIndex = 0;
            this.inv7.TabStop = false;
            // 
            // inv3
            // 
            this.inv3.Location = new System.Drawing.Point(171, 16);
            this.inv3.Name = "inv3";
            this.inv3.Size = new System.Drawing.Size(40, 38);
            this.inv3.TabIndex = 0;
            this.inv3.TabStop = false;
            // 
            // inv1
            // 
            this.inv1.Location = new System.Drawing.Point(12, 16);
            this.inv1.Name = "inv1";
            this.inv1.Size = new System.Drawing.Size(40, 38);
            this.inv1.TabIndex = 0;
            this.inv1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnnewgame
            // 
            this.btnnewgame.Location = new System.Drawing.Point(23, 570);
            this.btnnewgame.Name = "btnnewgame";
            this.btnnewgame.Size = new System.Drawing.Size(114, 31);
            this.btnnewgame.TabIndex = 1;
            this.btnnewgame.Text = "New Game";
            this.btnnewgame.UseVisualStyleBackColor = true;
            this.btnnewgame.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(591, 576);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 25);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: 0";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Defender
            // 
            this.Defender.ImageLocation = "";
            this.Defender.Location = new System.Drawing.Point(341, 473);
            this.Defender.Name = "Defender";
            this.Defender.Size = new System.Drawing.Size(40, 46);
            this.Defender.TabIndex = 4;
            this.Defender.TabStop = false;
            // 
            // frmInvaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 613);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnnewgame);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmInvaders";
            this.Text = "Space Invaders";
            this.Load += new System.EventHandler(this.frmInvaders_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmInvaders_KeyPress);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Shot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Defender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox inv1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox inv6;
        private System.Windows.Forms.PictureBox inv4;
        private System.Windows.Forms.PictureBox inv2;
        private System.Windows.Forms.PictureBox inv5;
        private System.Windows.Forms.PictureBox inv3;
        private System.Windows.Forms.PictureBox inv18;
        private System.Windows.Forms.PictureBox inv16;
        private System.Windows.Forms.PictureBox inv12;
        private System.Windows.Forms.PictureBox inv10;
        private System.Windows.Forms.PictureBox inv14;
        private System.Windows.Forms.PictureBox inv8;
        private System.Windows.Forms.PictureBox inv17;
        private System.Windows.Forms.PictureBox inv11;
        private System.Windows.Forms.PictureBox inv15;
        private System.Windows.Forms.PictureBox inv9;
        private System.Windows.Forms.PictureBox inv13;
        private System.Windows.Forms.PictureBox inv7;
        private System.Windows.Forms.PictureBox Barrier1;
        private System.Windows.Forms.PictureBox shot1;
        private System.Windows.Forms.PictureBox Barrier2;
        private System.Windows.Forms.Button btnnewgame;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox enemyshot;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox Shot1;
        private System.Windows.Forms.PictureBox Defender;
    }
}

