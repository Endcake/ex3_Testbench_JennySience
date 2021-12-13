using System;
using System.Collections.Generic;
using System.IO;
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
        private string data="nill";

        public string Data
        {
            get => data;
            set => data = value;
        }

        // Data: text to be send to server(axis controller)
        private string echo = "null";

        public string Echo
        {
            get => echo;
            set => echo = value;
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

        public bool killConnection()
        {
            try
            {
                client.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool sendDataTiming()
        {
            var task = Task.Run(() =>
            {

                return sendData();
            });

            bool isCompletedSuccessfully = task.Wait(TimeSpan.FromMilliseconds(3000));

            if (isCompletedSuccessfully)
            {
                return task.Result;
            }
            else
            {
                throw new TimeoutException("The function has taken longer than the maximum time allowed.");
            }

        }
        private bool sendData()
        {
            try 
            {
                data = data + "\r\n";
                int byteCount = Encoding.ASCII.GetByteCount(data + 1);
                byte[] sendData = new byte[byteCount];
                sendData = Encoding.ASCII.GetBytes(data);
                stream.Write(sendData, 0, sendData.Length);
                StreamReader sr = new StreamReader(stream);
                echo = sr.ReadLine();
                           
                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool checkEcho(string test)
        {
            if (echo == test)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
