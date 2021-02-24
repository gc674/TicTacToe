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
        private static List<string> Xor0 = new List<string> { "X", "0" };
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Box_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (turnCounter == 0 || turnCounter % 2 == 0)
            {
                button.Text = Xor0[0];
                button.Enabled = false;
            }
            else
            {
                button.Text = Xor0[1];
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
        public bool CheckBoxes(Button Button1, Button Button2, Button Button3)
        {
            if ((Xor0.Contains(Button1.Text, StringComparer.OrdinalIgnoreCase)) && Button1.Text == Button2.Text && Button2.Text == Button3.Text)
            {
                Button1.BackColor = Color.LightBlue;
                Button2.BackColor = Color.LightBlue;
                Button3.BackColor = Color.LightBlue;
                return true;
            }
            return false;
        }
        public bool CheckRows()
        {

            if (CheckBoxes(Box1, Box2, Box3) || CheckBoxes(Box4, Box5, Box6) || CheckBoxes(Box7, Box8, Box9))
                return true;
            //if((Xor0.Contains(Box1.Text, StringComparer.OrdinalIgnoreCase)) && Box1.Text == Box2.Text && Box2.Text == Box3.Text)
            //{
            //    Box1.BackColor = Color.LightBlue;
            //    Box2.BackColor = Color.LightBlue;
            //    Box3.BackColor = Color.LightBlue;
            //    return true;
            //}
            //if ((Xor0.Contains(Box4.Text, StringComparer.OrdinalIgnoreCase)) && Box4.Text == Box5.Text && Box5.Text == Box6.Text)
            //{
            //    Box4.BackColor = Color.LightBlue;
            //    Box5.BackColor = Color.LightBlue;
            //    Box6.BackColor = Color.LightBlue;
            //    return true;
            //}
            //if ((Xor0.Contains(Box7.Text, StringComparer.OrdinalIgnoreCase)) && Box7.Text == Box8.Text && Box8.Text == Box9.Text)
            //{
            //    Box7.BackColor = Color.LightBlue;
            //    Box8.BackColor = Color.LightBlue;
            //    Box9.BackColor = Color.LightBlue;
            //    return true;
            //}
            return false;
        }
        public bool CheckLines()
        {
            if (CheckBoxes(Box1, Box4, Box7) || CheckBoxes(Box2, Box5, Box8) || CheckBoxes(Box3, Box6, Box9))
                return true;
            //if ((Xor0.Contains(Box1.Text, StringComparer.OrdinalIgnoreCase)) && Box1.Text == Box4.Text && Box4.Text == Box7.Text)
            //{
            //    Box1.BackColor = Color.LightBlue;
            //    Box4.BackColor = Color.LightBlue;
            //    Box7.BackColor = Color.LightBlue;
            //    return true;
            //}
            //if ((Xor0.Contains(Box2.Text, StringComparer.OrdinalIgnoreCase)) && Box2.Text == Box5.Text && Box5.Text == Box8.Text)
            //{
            //    Box2.BackColor = Color.LightBlue;
            //    Box5.BackColor = Color.LightBlue;
            //    Box8.BackColor = Color.LightBlue;
            //    return true;
            //}
            //if ((Xor0.Contains(Box3.Text, StringComparer.OrdinalIgnoreCase)) && Box3.Text == Box6.Text && Box6.Text == Box9.Text)
            //{
            //    Box3.BackColor = Color.LightBlue;
            //    Box6.BackColor = Color.LightBlue;
            //    Box9.BackColor = Color.LightBlue;
            //    return true;
            //}
            return false;
        }
        public bool CheckDiagonal()
        {
            if (CheckBoxes(Box1, Box5, Box9) || CheckBoxes(Box3, Box5, Box7))
                return true;
            //if ((Xor0.Contains(Box1.Text, StringComparer.OrdinalIgnoreCase)) && Box1.Text == Box5.Text && Box5.Text == Box9.Text)
            //{
            //    Box1.BackColor = Color.LightBlue;
            //    Box5.BackColor = Color.LightBlue;
            //    Box9.BackColor = Color.LightBlue;
            //    return true;
            //}
            //if ((Xor0.Contains(Box3.Text, StringComparer.OrdinalIgnoreCase)) && Box3.Text == Box5.Text && Box5.Text == Box7.Text)
            //{
            //    Box3.BackColor = Color.LightBlue;
            //    Box5.BackColor = Color.LightBlue;
            //    Box7.BackColor = Color.LightBlue;
            //    return true;
            //}
            return false;
        }


    }
}
