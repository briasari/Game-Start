using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //required to commands like Thread.Sleep();
using System.Media; //required to use media in properties (audio, etc.)

namespace Game_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer countDownPlayer = new SoundPlayer(Properties.Resources.countdown); //creating countdown sound
            countDownPlayer.Play(); //playing sound

            outputLabel.Visible = true;
            outputLabel.Refresh();
            Thread.Sleep(300);
            //make countdown appear

            outputLabel.Text = "Game starting in 3";
            outputLabel.Refresh();
            Thread.Sleep(300);

            outputLabel.Text = "Game starting in 3.";
            outputLabel.Refresh();
            Thread.Sleep(300);

            outputLabel.Text = "Game starting in 3..";
            outputLabel.Refresh();
            Thread.Sleep(300);

            outputLabel.Text = "Game starting in 3...";
            outputLabel.Refresh();
            Thread.Sleep(300);


            countDownPlayer.Play();

            outputLabel.Text = "Game starting in 2";
            outputLabel.Refresh();
            Thread.Sleep(300);

            outputLabel.Text = "Game starting in 2.";
            outputLabel.Refresh();
            Thread.Sleep(300);

            outputLabel.Text = "Game starting in 2..";
            outputLabel.Refresh();
            Thread.Sleep(300);

            outputLabel.Text = "Game starting in 2...";
            outputLabel.Refresh();
            Thread.Sleep(300);


            countDownPlayer.Play();

            outputLabel.Text = "Game starting in 1";
            outputLabel.Refresh();
            Thread.Sleep(300);

            outputLabel.Text = "Game starting in 1.";
            outputLabel.Refresh();
            Thread.Sleep(300);

            outputLabel.Text = "Game starting in 1..";
            outputLabel.Refresh();
            Thread.Sleep(300);

            outputLabel.Text = "Game starting in 1...";
            outputLabel.Refresh();
            Thread.Sleep(500);

            SoundPlayer startPlayer = new SoundPlayer(Properties.Resources.go);
            startPlayer.Play();
            gameScreen.Visible = true;
            outputLabel.Visible = false;
            beginLabel.Parent = gameScreen;
            //parent links it to whatever it's supposed to be with
            //use parent when trying to make certain things appear on top of others
            beginLabel.Visible = true;
            Refresh();
        }
        //change demo
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
