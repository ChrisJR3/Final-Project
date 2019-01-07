using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class mainForm : UserControl
    {
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;
        int playX, playY, playSize, playSpeed;
        SolidBrush heroBrush = new SolidBrush(Color.Black);

        public mainForm()
        {
            InitializeComponent();
            InitializeGameValues();
        }

        public void InitializeGameValues()
        { 
            playX = 100;
            playY = 100;
            playSize = 20;
            playSpeed = 5;
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && gameTimer.Enabled)
            {
                gameTimer.Enabled = false;
                rightArrowDown = leftArrowDown = upArrowDown = downArrowDown = false;

                DialogResult result = PauseForm.Show();

                if (result == DialogResult.Cancel)
                {
                    gameTimer.Enabled = true;
                }
                else if (result == DialogResult.Abort)
                {
                    mainForm.ChangeScreen(this, "MenuScreen");
                }
            }

            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
            }
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            mainScreenLabel.Visible = false;
            playGameButton.Visible = false;
            leaveButton.Visible = false;
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
