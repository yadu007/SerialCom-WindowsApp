using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Net;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WindowsFormsApplication7
{
    public partial class SerialCom : Form
    {
        SerialPort SerialPortCommunication;
        
       public SerialCom()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Baud_Rate.Items.Add(300);
            Baud_Rate.Items.Add(600);
            Baud_Rate.Items.Add(1200);
            Baud_Rate.Items.Add(2400);
            Baud_Rate.Items.Add(4800);
            Baud_Rate.Items.Add(9600);
            Baud_Rate.Items.Add(14400);
            Baud_Rate.Items.Add(19200);
            Baud_Rate.Items.Add(38400);
            Baud_Rate.Items.Add(57600);
            Baud_Rate.SelectedItem = 300;

            StopBits_Inputs.Items.Add(1);
            StopBits_Inputs.Items.Add(2);
            StopBits_Inputs.SelectedItem = 2;

            DataBits_Input.Items.Add(7);
            DataBits_Input.Items.Add(8);
            DataBits_Input.SelectedItem = 8;

            Parity_Input.Items.Add("Even");
            Parity_Input.Items.Add("Odd");
            Parity_Input.Items.Add("None");
            Parity_Input.SelectedItem = "None";

            try
            {
                string[] Check_Available_Ports = null;
              //  int index = -1;
               // string ComPortName = null;

                Check_Available_Ports = SerialPort.GetPortNames();
               
                foreach(string Get_Available_ports in Check_Available_Ports)
                {
                    Port_Name.Items.Add(Get_Available_ports);
                    
                }
                Port_Name.Text = Check_Available_Ports[0];

            }
            catch
            {
                
                MessageBox.Show("No Ports are available hit Refresh", "Port_error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
               // MessageBox.Show("No Ports are available hit Refresh");
            }

          //  port = new SerialPort();
         //   port.PortName = portname.Text;
         //   port.Open();

        }

       
        private void baudrate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (SerialPortCommunication.IsOpen)
                {

                    SerialPortCommunication.WriteLine(input_box.Text);


                    SerialPortCommunication.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEventHandler);
                }
                else
                {
                    MessageBox.Show("Port is not open", "Port_error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch {

                MessageBox.Show("No SerialPort detected", "Port_error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

 
        private void DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {

                        byte[] DataBuffer = new byte[2048];
                       
                        int ReadDataSerial =SerialPortCommunication.Read(DataBuffer, 0, DataBuffer.Length);
            
                        string SerialReceiveData = System.Text.Encoding.UTF8.GetString(DataBuffer);


                        Invoke((MethodInvoker)(() => response_box.AppendText(SerialReceiveData)));
                        DataBuffer = new byte[2048];

        }


        private void button10_Click(object sender, EventArgs e)
        {
            response_box.Clear();
        }

        private void response_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            int Input_Buad_rate = Convert.ToInt32(Baud_Rate.Text);
            int Input_Data_Bits = Convert.ToInt32(DataBits_Input.Text);

            String Input_Parity = Parity_Input.Text;
            Parity Set_parity = new Parity();
            if (Input_Parity == "Odd")
            {
                Set_parity = Parity.Odd;
            }
            else if (Input_Parity == "Even")
            {
                Set_parity = Parity.Even;
            }

            int Input_Stop_Bits = Convert.ToInt32(StopBits_Inputs.Text);
            StopBits Set_Stop_Bits = new StopBits();
            if (Input_Stop_Bits == 1)
            {
                Set_Stop_Bits = StopBits.One;
            }
            else if (Input_Stop_Bits == 2)
            {
                Set_Stop_Bits = StopBits.Two; ;

            }

            try
            {
                SerialPortCommunication = new SerialPort();
                SerialPortCommunication.PortName = Port_Name.Text;
                SerialPortCommunication.BaudRate = Input_Buad_rate;
                SerialPortCommunication.Parity = Set_parity;
                SerialPortCommunication.StopBits = Set_Stop_Bits;
                SerialPortCommunication.DataBits = Input_Data_Bits;
                SerialPortCommunication.Open();
                SerialPortCommunication.WriteLine(input_box.Text);

            }
            catch
            {
                MessageBox.Show("Error Occured\rCheck the Port is being used by another process");
            }


            SerialPortCommunication.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEventHandler);

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {


            try
            {
                string[] Check_Available_Ports = null;
           
                Check_Available_Ports = SerialPort.GetPortNames();

                foreach (string Get_Available_ports in Check_Available_Ports)
                {
                    Port_Name.Items.Add(Get_Available_ports);

                }
                Port_Name.Text = Check_Available_Ports[0];

            }
            catch
            {
                MessageBox.Show("No Ports are available hit Refresh", "Port_error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
