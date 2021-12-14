using System;
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
using ps90func;

namespace JennySienceTestbench
{
    public partial class Form1 : Form
    {
        CPS90Win PS90;
        
        TcpClient client;
        
        

        NetworkStream stream_Jenny_X;
        NetworkStream stream_Jenny_Y;
        axis_jenny j1 = new axis_jenny();
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_connect_jenny_X_Click(object sender, EventArgs e)
        {
            try
            {
               client= new TcpClient(txtBx_ip1.Text, Convert.ToInt32(txtBx_port1.Text));
                //client = new TcpClient("127.0.0.1", 1302);
                stream_Jenny_X = client.GetStream();
            }
            catch
            {
                MessageBox.Show("keine Verbindung zum Server");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try { j1.killConnection(); }
            catch { }
            Application.Exit();
        }

        private void btn_disconnect_jenny_X_Click(object sender, EventArgs e)
        {
            btn_connect_jenny_X.Enabled = true;
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

            stream_Jenny_X.Write(sendData, 0, sendData.Length);
            

            StreamReader sr = new StreamReader(stream_Jenny_X);
           // string response = sr.ReadLine();
            //txtBox_communication.Text = response;
        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // zweiter Port
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void btn_connect_jenny_Y_Click(object sender, EventArgs e)
        {
            try
            {
                if (!j1.Connection)
                {
                    j1.IP = txtBx_ip2.Text;

                    j1.Port = Int32.Parse(txtBx_port2.Text);
                    j1.connect2Controller();
                }
            }
            catch
            {
                MessageBox.Show("keine Verbindung zum Server");
            }
        }

        private void btn_disconnectjenny_Y_Click(object sender, EventArgs e)
        {
            j1.killConnection();
        }

        private void btn_send2_Click(object sender, EventArgs e)
        {
            try
            {
                j1.Data = txtBx_command2.Text;
                j1.sendDataTiming();
                txtBox_communication.Text = "Timing OK";
            }
            catch { txtBox_communication.Text = "Timing NOT OK";
                MessageBox.Show("error");
            }

            txtBox_communication.Text = j1.Echo;
        }

        private void btn_get_postion_Click(object sender, EventArgs e)
        {
            try
            {
                j1.Data ="TP";
                j1.sendDataTiming();

                txtBox_communication.Text = j1.Echo;
            }
            catch
            {
                txtBox_communication.AppendText("error  ");
            }
        }

        private void btn_connect_ps90_Click(object sender, EventArgs e)
        {
            PS90 = new CPS90Win();
            
        }
    }
}
