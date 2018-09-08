using System;

using System.Windows.Forms;

namespace RoverCamController
{
    public partial class Form1 : Form
    {
        ConnectionHandler conn = new ConnectionHandler();

        public void Status (string text)
        {
            StatusBox.Clear();
            StatusBox.Paste(text);
        }

        public Form1()
        {
            InitializeComponent();
            Status("Push \"Connect\" to begin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Status(conn.Send("up"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Status(conn.Send("left"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Status(conn.Send("right"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Status(conn.Send("down"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Status(conn.Send("center"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool state = conn.State();
            if (state == false)
            {
                Status("Connecting...");
                Status(conn.Connect());
            }
            else
            {
                Status("Disconnecting...");
                Status(conn.Disconnect());
            }
        }

        private void Up2_Click(object sender, EventArgs e)
        {
            Status(conn.Send("up2"));
        }

        private void Up3_Click(object sender, EventArgs e)
        {
            Status(conn.Send("up3"));
        }

        private void Left2_Click(object sender, EventArgs e)
        {
            Status(conn.Send("right2"));
        }

        private void Left3_Click(object sender, EventArgs e)
        {
            Status(conn.Send("right3"));
        }

        private void Right2_Click(object sender, EventArgs e)
        {
            Status(conn.Send("left2"));
        }

        private void Right3_Click(object sender, EventArgs e)
        {
            Status(conn.Send("left3"));
        }

        private void Down2_Click(object sender, EventArgs e)
        {
            Status(conn.Send("down2"));
        }

        private void Down3_Click(object sender, EventArgs e)
        {
            Status(conn.Send("down3"));
        }

        private void Save_position_Click(object sender, EventArgs e)
        {
            Status(conn.Send("save_pos"));
            Status(conn.Recieve());
        }
    }
}
