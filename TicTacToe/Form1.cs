using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private static int turnCounter = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Box_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (turnCounter == 0 || turnCounter % 2 == 0)
            {
                button.Text = "X";
                button.Enabled = false;
            }
            else
            {
                button.Text = "0";
                button.Enabled = false;
            }
            CheckWinner();
            
            turnCounter++;
        }

        public void CheckWinner()
        {
            if(CheckRows() || CheckLines() || CheckDiagonal())
            {
                MessageBox.Show("Congrats, you won!");
                ChangeButtonStatus(false);
            }
        }
        public void ChangeButtonStatus(bool active)
        {

            foreach (var button in Controls.OfType<Button>())
            {

                if (button.Name != "NewGame")
                {
                    button.Enabled = active;
                    if (active)
                    {
                        button.Text = "";
                        button.BackColor = Color.Gray;
                    } 
                }
            }
        }
        private void NewGame_Click(object sender, EventArgs e)
        {
            ChangeButtonStatus(true);
            turnCounter = 0;
        }

        public bool CheckRows()
        {
            if((Box1.Text.ToLower() == "x" || Box1.Text == "0") && Box1.Text == Box2.Text && Box2.Text == Box3.Text)
            {
                Box1.BackColor = Color.LightBlue;
                Box2.BackColor = Color.LightBlue;
                Box3.BackColor = Color.LightBlue;
                return true;
            }
            if ((Box4.Text.ToLower() == "x" || Box4.Text == "0") && Box4.Text == Box5.Text && Box5.Text == Box6.Text)
            {
                Box4.BackColor = Color.LightBlue;
                Box5.BackColor = Color.LightBlue;
                Box6.BackColor = Color.LightBlue;
                return true;
            }
            if ((Box7.Text.ToLower() == "x" || Box7.Text == "0") && Box7.Text == Box8.Text && Box8.Text == Box9.Text)
            {
                Box7.BackColor = Color.LightBlue;
                Box8.BackColor = Color.LightBlue;
                Box9.BackColor = Color.LightBlue;
                return true;
            }
            return false;
        }

        public bool CheckLines()
        {
            if ((Box1.Text.ToLower() == "x" || Box1.Text == "0") && Box1.Text == Box4.Text && Box4.Text == Box7.Text)
            {
                Box1.BackColor = Color.LightBlue;
                Box4.BackColor = Color.LightBlue;
                Box7.BackColor = Color.LightBlue;
                return true;
            }
            if ((Box2.Text.ToLower() == "x" || Box2.Text == "0") && Box2.Text == Box5.Text && Box5.Text == Box8.Text)
            {
                Box2.BackColor = Color.LightBlue;
                Box5.BackColor = Color.LightBlue;
                Box8.BackColor = Color.LightBlue;
                return true;
            }
            if ((Box3.Text.ToLower() == "x" || Box3.Text == "0") && Box3.Text == Box6.Text && Box6.Text == Box9.Text)
            {
                Box3.BackColor = Color.LightBlue;
                Box6.BackColor = Color.LightBlue;
                Box9.BackColor = Color.LightBlue;
                return true;
            }
            return false;
        }

        public bool CheckDiagonal()
        {
            if ((Box1.Text.ToLower() == "x" || Box1.Text == "0") && Box1.Text == Box5.Text && Box5.Text == Box9.Text)
            {
                Box1.BackColor = Color.LightBlue;
                Box5.BackColor = Color.LightBlue;
                Box9.BackColor = Color.LightBlue;
                return true;
            }
            if ((Box3.Text.ToLower() == "x" || Box3.Text == "0") && Box3.Text == Box5.Text && Box5.Text == Box7.Text)
            {
                Box3.BackColor = Color.LightBlue;
                Box5.BackColor = Color.LightBlue;
                Box7.BackColor = Color.LightBlue;
                return true;
            }
            return false;
        }


    }
}
