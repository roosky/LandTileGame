using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private int _ticker;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.W)
            //{
            //    Character.moveSprite("up", pictureBox1);
            //}
            //else if (e.KeyCode == Keys.D)
            //{
            //    Character.moveSprite("down", pictureBox1);
            //}

            //CharacterCommands.moveSprite(e.KeyCode, pictureBox1);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticker++;
            string ticker = _ticker.ToString();
            label_Time_Counter.Text = ticker;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (button_Start.Text == "Start")
            {
                button_Start.Text = "Restart";
                timer1.Start();
                button_Stop.Visible = true;
            }
            else
            {
                _ticker = 0;
            }
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            button_Stop.Visible = false;
            timer1.Stop();
            button_Start.Text = "Start";
            _ticker = 0;
            label_Time_Counter.Text = "0";
        }

        public void button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.BackColor != Color.Lime)
            {
                button.BackColor = Color.Lime;
            }
            else
            {
                button.BackColor = Color.White;
            }
        }
    }
}
