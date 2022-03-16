
namespace La1500_StartScreen
{
    partial class shopScreen
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
            this.backBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buyBtn3 = new System.Windows.Forms.Button();
            this.buyBtn2 = new System.Windows.Forms.Button();
            this.buyBtn1 = new System.Windows.Forms.Button();
            this.shopTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(591, 406);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 29);
            this.backBtn.TabIndex = 22;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Impossible-Modus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Up-to-Down Modus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Left-To-Right Modus";
            // 
            // buyBtn3
            // 
            this.buyBtn3.Location = new System.Drawing.Point(409, 285);
            this.buyBtn3.Name = "buyBtn3";
            this.buyBtn3.Size = new System.Drawing.Size(114, 43);
            this.buyBtn3.TabIndex = 18;
            this.buyBtn3.Text = "Buy";
            this.buyBtn3.UseVisualStyleBackColor = true;
            // 
            // buyBtn2
            // 
            this.buyBtn2.Location = new System.Drawing.Point(409, 203);
            this.buyBtn2.Name = "buyBtn2";
            this.buyBtn2.Size = new System.Drawing.Size(114, 45);
            this.buyBtn2.TabIndex = 17;
            this.buyBtn2.Text = "Buy";
            this.buyBtn2.UseVisualStyleBackColor = true;
            // 
            // buyBtn1
            // 
            this.buyBtn1.Location = new System.Drawing.Point(409, 124);
            this.buyBtn1.Name = "buyBtn1";
            this.buyBtn1.Size = new System.Drawing.Size(114, 43);
            this.buyBtn1.TabIndex = 16;
            this.buyBtn1.Text = "Buy";
            this.buyBtn1.UseVisualStyleBackColor = true;
            this.buyBtn1.Click += new System.EventHandler(this.buyBtn1_Click);
            // 
            // shopTitle
            // 
            this.shopTitle.AutoSize = true;
            this.shopTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shopTitle.Location = new System.Drawing.Point(209, 32);
            this.shopTitle.Name = "shopTitle";
            this.shopTitle.Size = new System.Drawing.Size(314, 54);
            this.shopTitle.TabIndex = 15;
            this.shopTitle.Text = "This is the shop";
            // 
            // shopScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buyBtn3);
            this.Controls.Add(this.buyBtn2);
            this.Controls.Add(this.buyBtn1);
            this.Controls.Add(this.shopTitle);
            this.Name = "shopScreen";
            this.Text = "shopScreen";
            this.Load += new System.EventHandler(this.homeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buyBtn3;
        private System.Windows.Forms.Button buyBtn2;
        private System.Windows.Forms.Button buyBtn1;
        private System.Windows.Forms.Label shopTitle;
    }
}