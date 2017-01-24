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
    class Sending
    {

        Synapse hh = new Synapse();
        public void df()
        {
            hh.port = new SerialPort();
           // MessageBox.Show("dd");
            

        }



        public void Datareceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            byte[] data = new byte[2048];

            int nbrDataRead = hh.port.Read(data, 0, data.Length);

            string result = System.Text.Encoding.UTF8.GetString(data);

            
          //  Synapse hh = new Synapse();

         //   Invoke((MethodInvoker)(() => hh..AppendText(result)));
            data = new byte[2048];
            //return result;
            Synapse dd = new Synapse();
          //  dd.hah(result);
            
        }
        
    }
}
