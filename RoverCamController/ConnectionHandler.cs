using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


//TODO: Add normal "Decode" method
//TODO: Comments
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

        public string Send(string message)
        {
            try
            {
                byte[] data = Encode(message);
                try
                {
                    socket.Send(data);
                    return "Command sent";
                }
                catch(System.ObjectDisposedException)
                {
                    conn_state = false;
                    return "Server disconnected. Try to connect again";
                }
            }
            catch(System.Net.Sockets.SocketException)
            {
                conn_state = false;
                return "Socket is closed. Try to reconnect";
            }
        }


        public string Recieve()
        {
            try
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
                    return "Recieved: " + builder.ToString();
                }
                catch (System.ObjectDisposedException)
                {
                    conn_state = false;
                    return "Server disconnected. Try to connect again";
                }
            }
            catch (System.Net.Sockets.SocketException)
            {
                conn_state = false;
                return "Socket is closed. Try to reconnect";
            }
        }


        public string Connect()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ip_point);
                conn_state = true;
                return "Connected to " + ip_address + ":" + port;
            }
            catch (System.Net.Sockets.SocketException)
            {
                conn_state = false;
                return "Rover100101@" + ip_address + ":" + Convert.ToString(port) + " not found";
            }
        }


        public string Disconnect()
        {
            Send("disconnect");
            socket.Close();
            conn_state = false;
            return "Disconnected by demand";
        }


        public bool State()
        {
            return conn_state;
        }

        public byte[] Encode(string data)
        {
            byte[] encoded_data = Encoding.ASCII.GetBytes(data);
            return encoded_data;
        }
    }
}
