using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace La1500_StartScreen
{
    public partial class homeScreen : Form
    {
        public homeScreen()
        {
            InitializeComponent();
        }

        private void homeScreen_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startGameBtn_Click_1(object sender, EventArgs e)
        {
            gameScreen gameWindow = new gameScreen();

            gameWindow.Show();
        }

        private void shopButton_Click_1(object sender, EventArgs e)
        {
            shopScreen shopWindow = new shopScreen();

            shopWindow.Show();
        }

        private void helpBtn_Click_1(object sender, EventArgs e)
        {
            helpScreen helpWindow = new helpScreen();

            helpWindow.Show();
        }
    }
}
