using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace JennySienceTestbench
{
    class axis_jenny
    {
        //members

        // IP
        private string ip="x";
        
        public string IP   
        {
            get => ip;
            set => ip = value;
        }


        //Port
        private int port=0;

        public int Port
        {
            get => port;
            set => port = value;
        }
        

        // Data: text to be send to server(axis controller)
        private string data;

        public string Data
        {
            get => data;
            set => data = value;
        }

        //Connection: false-> not connected to server
        private bool connection=false;

        public bool Connection
        {
            get => connection;
            set => connection = value;
        }


        //Client
        private TcpClient client;

        public TcpClient Client
        {
            get => Client;
            set => Client = value;
        }


        //Client
        private NetworkStream stream;

        public NetworkStream Stream
        {
            get => stream;
            set => stream = value;
        }


        // methodes
        public bool connect2Controller()
        {
            try
            {
                client = new TcpClient(ip, port);
                stream = client.GetStream();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
