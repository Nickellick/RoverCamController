using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace RoverCamController
{
    class ConnectionHandler
    {
        private static string ip_address;
        private static int port;
        private IPEndPoint ip_point = new IPEndPoint(IPAddress.Parse(ip_address), port);
        private Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private bool conn_state = false;


        static ConnectionHandler()
        {
            ip_address = "192.168.0.62";
            port = 8082;
        }

        public void Send(string message)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                try
                {
                    socket.Send(data);
                    form.Status("Command sent");
                }
                catch(System.ObjectDisposedException)
                {
                    conn_state = false;
                    form.Status("Server disconnected. Try to connect again");
                }
            }
            catch(System.Net.Sockets.SocketException)
            {
                conn_state = false;
                form.Status("Socket is closed. Try again");
            }
        }


        public void Recieve()
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
                form.Status("Recieved: " + builder.ToString());
            }
            catch (System.ObjectDisposedException)
            {
                conn_state = false;
                form.Status("Server disconnected. Try to connect again");
            }
        }


        public void Connect()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ip_point);
                conn_state = true;
                form.Status("Connected to " + ip_address + ":" + port);
            }
            catch (System.Net.Sockets.SocketException)
            {
                conn_state = false;
                form.Status("Server with IP " + ip_address + "not found");
            }
        }


        public void Disconnect()
        {
            Send("disconnect");
            socket.Close();
            conn_state = false;
            form.Status("Disconnected by demand");
        }


        public bool State()
        {
            return conn_state;
        }
    }
}
