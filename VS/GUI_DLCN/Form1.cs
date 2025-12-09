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
using System.Xml.Linq;
using System.Management;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] Baudrate = { "1200", "2400", "4800", "9600", "115200" };
            cboBaudrate.Items.AddRange(Baudrate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butOn_Click(object sender, EventArgs e)
        {
            string data = "00000001011";
            serCom.Write(data);
        }

        private void butOff_Click(object sender, EventArgs e)
        {
            string data = "00000000011";
            serCom.Write(data);
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            string dulieu = textSendData.Text;
            serCom.Write(dulieu);
        }
        private StringBuilder receivedBuffer = new StringBuilder();
        private void SerCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string Rx_Data = serCom.ReadLine().Trim();
            lbxRx_Data.Items.Add(Rx_Data);

        }

        private void textSendData_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboComPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxReceiveData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string data = "0001002D011";
            serCom.Write(data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = "0001005A011";
            serCom.Write(data);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data = "000100B4011";
            serCom.Write(data);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string data = "00010168011";
            serCom.Write(data);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string data = "00020000011";
            serCom.Write(data);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string data = "00020001011";
            serCom.Write(data);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string data = "00030001011";
            serCom.Write(data);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string data = "00030000011";
            serCom.Write(data);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string data = "00030010011";
            serCom.Write(data);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string data = "00030011011";
            serCom.Write(data);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string data = "0004FFFF011";
            serCom.Write(data);
        }

       

     
    }

}

