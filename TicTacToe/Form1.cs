using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_game
{
    public partial class Form1 : Form
    {
        bool turn=true;
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Крестики-нолики игра реализованная на С#. Как только кто-то выиграл, начинайте новую игру.");
        }

      
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn)
                b.Text = "x";
            else
                b.Text = "0";
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkwinner();
        }

        private void checkwinner()
        {
            bool win = false;
            if((A1.Text==A2.Text)&&(A2.Text==A3.Text)&&(!A1.Enabled))
                    win = true;
           else if ((b1.Text == b2.Text) && (b2.Text == b3.Text)&& (!b1.Enabled))
                win = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text)&& (!c1.Enabled))
                win = true;

            if ((A1.Text == b1.Text) && (b1.Text == c1.Text) && (!A1.Enabled))
                win = true;
            else if ((A2.Text == b2.Text) && (b2.Text == c2.Text) && (!A2.Enabled))
                win = true;
            else if ((A3.Text == b3.Text) && (b3.Text == c3.Text) && (!A3.Enabled))
                win = true;

            if ((A1.Text == b2.Text) && (b2.Text == c3.Text) && (!A1.Enabled))
                win = true;
            else if ((A3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
                win = true;
          

            if (win)
            {
                string winner = "";
                if (turn)
                    winner = "0";
                else
                    winner = "X";

                MessageBox.Show(winner + " выиграл");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Ничья");
                }
            }
        }


        private void disablebutton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
