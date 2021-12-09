﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace JennySienceTestbench
{
    public partial class Form1 : Form
    {
        TcpClient client;
        
        

        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
            btn_disconnect.Enabled = false;
            btn_send_message.Enabled = false;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                client= new TcpClient("127.0.0.1", 1302);  
                stream = client.GetStream();
                btn_connect.Enabled = false;
                btn_disconnect.Enabled = true;
                btn_send_message.Enabled =true;
            }
            catch
            {
                MessageBox.Show("keine Verbindung zum Server");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try { client.Close(); }
            catch { }
            Application.Exit();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = true;
            btn_disconnect.Enabled = false;
            btn_send_message.Enabled = false;
            client.Close();
        }

        private void btn_send_message_Click(object sender, EventArgs e)
        {
            string messageToSend = txtBx_command.Text;
            int byteCount = Encoding.ASCII.GetByteCount(messageToSend + 1);
            byte[] sendData = new byte[byteCount];
            sendData = Encoding.ASCII.GetBytes(messageToSend);

            stream.Write(sendData, 0, sendData.Length);
            

            StreamReader sr = new StreamReader(stream);
           // string response = sr.ReadLine();
            //txtBox_communication.Text = response;
        }
    }
}
