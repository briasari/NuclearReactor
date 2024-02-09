using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alarm);
            alertPlayer.Play();

            for (int i = 0; i < 5; i++)
            {

                reactor1StateLabel.BackColor = Color.Red;
                reactor2StateLabel.BackColor = Color.Red;
                outputLabel.Text = "Reactors Unstable";
                outputLabel.BackColor = Color.White;
                outputLabel.ForeColor = Color.Red;

                Refresh();
                Thread.Sleep(500);

                reactor1StateLabel.BackColor = Color.White;
                reactor2StateLabel.BackColor = Color.White;
                outputLabel.BackColor= Color.Red;
                outputLabel.ForeColor = Color.White;


                Refresh();
                Thread.Sleep(500);
            }
        }

        private void reactorStableLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
