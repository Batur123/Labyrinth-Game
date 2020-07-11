using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player.Text = "Oyuncu";
           // MessageBox.Show(Player.Location.X.ToString());
           // x 64 y 114
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            if (e.KeyChar == (char)Keys.Space)
            {
            //    int temp = 10;

            //    Player.Location = new Point(Player.Location.X+10, Player.Location.Y);
            }
           
          //  if(input)
 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D)
            {
                Player.Location = new Point(Player.Location.X + 1, Player.Location.Y);
            }
            if (e.KeyCode == Keys.W)
            {
                Player.Location = new Point(Player.Location.X, Player.Location.Y - 1);
            }
            if (e.KeyCode == Keys.A)
            {
                Player.Location = new Point(Player.Location.X - 1, Player.Location.Y);
            }
            if (e.KeyCode == Keys.S)
            {
                Player.Location = new Point(Player.Location.X , Player.Location.Y + 1);
            }
            //if(e.KeyCode == Keys.S || e.KeyCode == Keys.D)
            //{
            //    Player.Location = new Point(Player.Location.X + 5, Player.Location.Y + 5);
            //}
            //if (e.KeyCode == Keys.W || e.KeyCode == Keys.D)
            //{
            //    Player.Location = new Point(Player.Location.X + 5, Player.Location.Y - 5);
            //}
            //if (e.KeyCode == Keys.A || e.KeyCode == Keys.D)
            //{
            //    Player.Location = new Point(Player.Location.X - 5 , Player.Location.Y - 5);
            //}
            //if (e.KeyCode == Keys.A || e.KeyCode == Keys.S)
            //{
            //    Player.Location = new Point(Player.Location.X - 5, Player.Location.Y + 5);
            //}

            if(Player.Location.X == 55 && Player.Location.Y == 73)
            {
                MessageBox.Show("Duvara çarptınız!");
                Player.Location = new Point(55,38);
            }
        }
    }
}
