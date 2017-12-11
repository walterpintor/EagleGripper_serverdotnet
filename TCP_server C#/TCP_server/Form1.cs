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
using System.IO;
using System.Threading;

namespace TCP_server
{
    public partial class Form1 : Form
    {
        TcpListener tcpListener = new TcpListener(IPAddress.Parse("192.168.56.1"), 5004);

        private bool updateButtonClicked = false;
        private bool setLimitButtonClicked = false;
        private bool rotateButtonClicked = false;
        private bool disconnectButtonClicked = false;
        

        public Form1()
        {
            InitializeComponent();
            

            //ipBox.Text = GetLocalIP(); // Use when under the same PC (Not applicable for VM)

        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "192.168.56.1";
        }
               
        private void Form1_Load(object sender, EventArgs e)
        {                  
            disconnectButton.Enabled = false;
            
            updateControlButton.Enabled = false;
            rotateButton.Enabled = false;
            setLimitButton.Enabled = false;
        }
        
        private void connectButton_Click(object sender, EventArgs e)
        {            
            try
            {
                Thread tcpServerRunThread = new Thread(new ThreadStart(TcpServerRun));
                tcpServerRunThread.Start();                

                Console.Write("Connected");
                //MessageBox.Show("Connected to Client");
                connectButton.Enabled = false;

                disconnectButton.Enabled = true;
                
                updateControlButton.Enabled = true;
                rotateButton.Enabled = true;
                setLimitButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                         
        }

        private void TcpServerRun()
        {
            
            tcpListener.Start();
            updateUI("Listening...");
            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                updateUI("Connected");
                Thread tcpHandlerThread = new Thread(new ParameterizedThreadStart(tcpHandler));
                tcpHandlerThread.Start(client);

                
            }

            
        }



        private void updateUI(string s)
        {
            Func<int> del = delegate ()
            {
                statusLabel.Text = String.Format("Status update: ", s);                
                return 0;
            };
            Invoke(del);
        }

        private void tcpHandler(object client)
        {
            //Initializing network to listen to client
            TcpClient mclient = (TcpClient)client;
            NetworkStream stream = mclient.GetStream();

            byte[] OKresponse = new byte[1024];
            byte[] GainByte = new byte[1024];
            byte[] KpByte = new byte[1024];
            byte[] KiByte = new byte[1024];
            byte[] KdByte = new byte[1024];
            byte[] currentBytes = new byte[1024];
            byte[] speedBytes = new byte[1024];

            byte[] incomingmessage = new byte[1024];
            byte[] outgoingmessage = new byte[1024];
            byte[] controlBytes = new byte[1024];
            byte[] currentCMDBytes = new byte[1024];
            byte[] speedCMDBytes = new byte[1024];

            while (true)
            {
                
                

                stream.Read(incomingmessage, 0, incomingmessage.Length);
                updateUI("New message = " + Encoding.ASCII.GetString(incomingmessage));
                string firstMessageReceived = Encoding.ASCII.GetString(incomingmessage);
                firstMessageReceived = firstMessageReceived.Replace("\0", string.Empty);
                string firstMessageSent = "startServer";

                if (firstMessageReceived == "startCommClient")
                {
                    MessageBox.Show(Encoding.ASCII.GetString(incomingmessage));

                    outgoingmessage = Encoding.ASCII.GetBytes(firstMessageSent);
                    stream.Write(outgoingmessage, 0, outgoingmessage.Length);
                    Thread.Sleep(1);

                    controlBytes = Encoding.ASCII.GetBytes("getPIDvalues");
                    stream.Write(controlBytes, 0, controlBytes.Length);
                    Console.Write("Get PID values request sent\n\r");

                    stream.Read(OKresponse, 0, OKresponse.Length);
                    string MessageReceived = Encoding.ASCII.GetString(OKresponse);
                    MessageReceived = MessageReceived.Replace("\0", string.Empty);

                    if (MessageReceived == "Roger")
                    {
                        stream.Read(GainByte, 0, GainByte.Length);
                        string gainTCP = Encoding.ASCII.GetString(GainByte);
                        gainTCP = gainTCP.Replace("\0", string.Empty);
                        updateGAIN(gainTCP);
                        Thread.Sleep(1);

                        stream.Read(KpByte, 0, KpByte.Length);
                        string kpTCP = Encoding.ASCII.GetString(KpByte);
                        kpTCP = kpTCP.Replace("\0", string.Empty);
                        updateKp(kpTCP);
                        Thread.Sleep(1);

                        stream.Read(KiByte, 0, KiByte.Length);
                        string kiTCP = Encoding.ASCII.GetString(KiByte);
                        kiTCP = kiTCP.Replace("\0", string.Empty);
                        updateKi(kiTCP);
                        Thread.Sleep(1);

                        stream.Read(KdByte, 0, KdByte.Length);
                        string kdTCP = Encoding.ASCII.GetString(KdByte);
                        kdTCP = kdTCP.Replace("\0", string.Empty);
                        updateKd(kdTCP);
                        Thread.Sleep(1);

                        MessageReceived = "";
                    }

                    while (true)
                    {
                        ////// Set PID Values  
                        if (updateButtonClicked == true)
                        {
                            controlBytes = Encoding.ASCII.GetBytes("setPIDvalues");
                            stream.Write(controlBytes, 0, controlBytes.Length);
                            Console.Write("Set PID values request sent\n");
                            stream.Flush();
                            Thread.Sleep(1);

                            GainByte = Encoding.ASCII.GetBytes(setGainTextBox.Text + "$");
                            stream.Write(GainByte, 0, GainByte.Length);
                            updateGAIN(setGainTextBox.Text);
                            stream.Flush();
                            Thread.Sleep(1);

                            KpByte = Encoding.ASCII.GetBytes(setKpTextBox.Text + "$");
                            stream.Write(KpByte, 0, KpByte.Length);
                            stream.Flush();
                            Thread.Sleep(1);

                            KiByte = Encoding.ASCII.GetBytes(setKiTextBox.Text + "$");
                            stream.Write(KiByte, 0, KiByte.Length);
                            stream.Flush();
                            Thread.Sleep(1);

                            KdByte = Encoding.ASCII.GetBytes(setKdTextBox.Text + "$");
                            stream.Write(KdByte, 0, KdByte.Length);
                            stream.Flush();
                            Thread.Sleep(1);

                            updateButtonClicked = false;
                            break;
                        }

                        if (setLimitButtonClicked == true)
                        {
                            currentCMDBytes = Encoding.ASCII.GetBytes("currentLimit");
                            stream.Write(currentCMDBytes, 0, currentCMDBytes.Length);
                            Console.Write("Set Current limit values request sent\n");
                            stream.Flush();
                            Thread.Sleep(1);

                            currentBytes = Encoding.ASCII.GetBytes(setContinuousCurrentLimitTextBox.Text);
                            stream.Write(currentBytes, 0, currentBytes.Length);                            
                            stream.Flush();
                            Thread.Sleep(1);

                            setLimitButtonClicked = false;
                            break;
                        }

                        if (rotateButtonClicked == true)
                        {
                            speedCMDBytes = Encoding.ASCII.GetBytes("rotateCMD");
                            stream.Write(speedCMDBytes, 0, speedCMDBytes.Length);
                            Console.Write("Set Speed limit values request sent\n");
                            stream.Flush();
                            Thread.Sleep(1);

                            speedBytes = Encoding.ASCII.GetBytes(speedTextBox.Text);
                            stream.Write(speedBytes, 0, speedBytes.Length);
                            stream.Flush();
                            Thread.Sleep(1);


                            rotateButtonClicked = false;
                            break;
                        }

                        if (disconnectButtonClicked == true)
                        {
                            
                            disconnectButtonClicked = false;
                            stream.Close();
                            mclient.Close();
                            break;
                        }

                    }



                        //stream.Close();
                        //mclient.Close();



                    }
                else
                {
                    MessageBox.Show("Message not sent");
                    stream.Close();
                    mclient.Close();
                }

                //stream.Close();
                //stream.Dispose();
                //mclient.Close();

            }
        }



        private void disconnectButton_Click(object sender, EventArgs e)
        {
                disconnectButtonClicked = true;

                disconnectButton.Enabled = false;
                
                updateControlButton.Enabled = false;
                rotateButton.Enabled = false;
                setLimitButton.Enabled = false;

                connectButton.Enabled = true;
            
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            rotateButtonClicked = true;

            if (ccwRadioButton.Checked == true)
            {
                MessageBox.Show("You have selected counter clockwise motion at a speed of "+ speedTextBox.Text +"!!");
                return;
            }
            else if (cwRadioButton.Checked == true)
            {
                MessageBox.Show("You have selected clockwise motion at a speed of " + speedTextBox.Text + "!!");
                return;
            }

        }


        private void updateGAIN(string s)
        {
            Func<int> del = delegate ()
            {
                getGainTextBox.Clear();
                getGainTextBox.AppendText(s + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }

        private void updateKp(string s)
        {
            Func<int> del = delegate ()
            {
                getKpTextBox.Clear();
                getKpTextBox.AppendText(s + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }



        private void updateKi(string s)
        {
            Func<int> del = delegate ()
            {
                getKiTextBox.Clear();
                getKiTextBox.AppendText(s + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }



        private void updateKd(string s)
        {
            Func<int> del = delegate ()
            {
                getKdTextBox.Clear();
                getKdTextBox.AppendText(s + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }



        private void updateControlButton_Click(object sender, EventArgs e)
        {


            

            updateButtonClicked = true;
            
        }

        private void setLimitButton_Click(object sender, EventArgs e)
        {
            setLimitButtonClicked = true;
        }
    }
}
