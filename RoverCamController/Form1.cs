using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace RoverCamController
{
    public partial class Form1 : Form
    {
        public static string chc = "chc";
        public static int port = 8082;
        public static string address = "192.168.0.61";
        public static IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);
        public static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static bool conn_stat = false;

        public void StatusText (string text)
        {
            textBox1.Clear();
            textBox1.Paste(text);
        }

        public void send_data(string str)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(str);
                try
                {
                    socket.Send(data);
                }
                catch (System.ObjectDisposedException)
                {
                    StatusText("Server is disconnected. Try to connect again");
                    conn_stat = false;
                }
            }
            catch (System.Net.Sockets.SocketException)
            {
                StatusText("Server was disconnected\r\n");
                conn_stat = false;
            }
        }

        public string recv_data()
        {
            try
            {
                byte[] data = new byte[1024];
                StringBuilder builder = new StringBuilder();
                int bytes = 0;

                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.ASCII.GetString(data, 0, bytes));
                }
                while (socket.Available > 0);
                return builder.ToString();
            }
            catch (System.ObjectDisposedException)
            {
                StatusText("Server is disconnected. Try to connect again");
                conn_stat = false;
                return "";
            }
        }

        public void connect()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipPoint);
                StatusText("Connected to " + address + ":" + port + "\r\n");
                conn_stat = true;
            }
            catch (System.Net.Sockets.SocketException)
            {
                StatusText("Server not found\r\n");
                conn_stat = false;
            }
        }

        public void disconnect()
        {
            send_data("disconnect");
            socket.Close();
            conn_stat = false;
            StatusText("Disconnected by demand\r\n");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            send_data("up");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            send_data("left");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            send_data("right");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            send_data("down");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            send_data("center");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (conn_stat == false)
            {
                connect();
            }
            else
            {
                disconnect();
            }
        }

        private void Up2_Click(object sender, EventArgs e)
        {
            send_data("up2");
        }

        private void Up3_Click(object sender, EventArgs e)
        {
            send_data("up3");
        }

        private void Left2_Click(object sender, EventArgs e)
        {
            send_data("right2");
        }

        private void Left3_Click(object sender, EventArgs e)
        {
            send_data("right3");
        }

        private void Right2_Click(object sender, EventArgs e)
        {
            send_data("left2");
        }

        private void Right3_Click(object sender, EventArgs e)
        {
            send_data("left3");
        }

        private void Down2_Click(object sender, EventArgs e)
        {
            send_data("down2");
        }

        private void Down3_Click(object sender, EventArgs e)
        {
            send_data("down3");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
