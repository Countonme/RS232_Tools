using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS232_Tools
{
    public partial class FrmMain : UIForm
    {
        private SerialPort _serialPort;
        private bool comOpenStatus;
        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmRs232_Load;
            this.rToolStripMenuItem.Click += RToolStripMenuItem_Click;
            this.btnClose.Click += BtnClose_Click;
            this.btnOpen.Click += BtnOpen_Click;
            this.FormClosing += FrmRs232_FormClosing;
            this.btnSendString.Click += BtnSend_Click;
            this.btnSendByte.Click += BtnSendByte_Click;

        }

        private void BtnSendByte_Click(object sender, EventArgs e)
        {
            if (!(_serialPort is null) && _serialPort.IsOpen)
            {
                SendByteMessage($"{txtmessage.Text}");

                return;
            }
            this.ShowErrorNotifier("COM No Open,Please open the com to continue");
        }

        /// <summary>
        /// 发送数据 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (!(_serialPort is null) && _serialPort.IsOpen)
            {
                SendStringMessage($"{txtmessage.Text}");

                return;
            }
            this.ShowErrorNotifier("COM No Open,Please open the com to continue");

        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="message"></param>
        public void SendByteMessage(string command)
        {
            if (string.IsNullOrEmpty(command))
            {
                this.ShowErrorNotifier("Message is Empty!");
                return;
            }




            if (cbCR.Checked && cbLF.Checked)
            {
                command = $"{command}\r\n";

            }

            if (cbCR.Checked && !cbLF.Checked)
            {

                command = $"{command}\r";
            }

            if (!cbCR.Checked && cbLF.Checked)
            {

                command = $"{command}\n";
            }

            byte[] commandBytes = Encoding.ASCII.GetBytes(command);

            _serialPort.Write(commandBytes, 0, commandBytes.Length);


        }

        public void SendStringMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                this.ShowErrorNotifier("Message is Empty!");
                return;
            }
            byte[] commandBytes = Encoding.ASCII.GetBytes(message);


            if (cbCR.Checked && cbLF.Checked)
            {
                _serialPort.WriteLine(message);
                return;
            }

            if (!cbCR.Checked && !cbLF.Checked)
            {
                _serialPort.Write(message);
                return;
            }
        }

        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmRs232_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(_serialPort is null) && _serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            Thread.Sleep(10);
            string receivedData = _serialPort.IsOpen ? _serialPort.ReadExisting() : "Close";
            txtLog.BeginInvoke(new Action(() =>
            {
                txtLog.AppendText(receivedData);
            }));

        }

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (!comOpenStatus)
                {
                    Parity parity = (Parity)Enum.Parse(typeof(Parity), comParity.Text, true);
                    StopBits stopBits = (StopBits)Enum.Parse(typeof(StopBits), comboxStopBits.Text, true);
                    _serialPort = new SerialPort(cbComlist.Text, int.Parse(baudRate.Text), parity, int.Parse(comboxDataBit.Text), stopBits);
                    _serialPort.Open();
                    uiLedBulb1.On = true;
                    uiLedBulb1.Blink = true;
                    uiLedBulb1.Color = Color.Lime;
                    comOpenStatus = true;
                    _serialPort.DataReceived += _serialPort_DataReceived;
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorNotifier(ex.Message);
            }
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (comOpenStatus)
            {
                _serialPort.Close();
                uiLedBulb1.On = false;
                uiLedBulb1.Blink = false;
                uiLedBulb1.Color = Color.Red;
                comOpenStatus = false;
            }

        }

        private void RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadComList();
        }

        private void FrmRs232_Load(object sender, EventArgs e)
        {
            loadComList();
        }
        /// <summary>
        /// 加载串口列表
        /// </summary>
        private void loadComList()
        {

            string[] ports = SerialPort.GetPortNames(); // 获取所有可用串口名称
            cbComlist.Items.Clear();
            ports.ForEach(com =>
            {
                cbComlist.Items.Add(com);
                cbComlist.Text = com;
            });
            this.ShowInfoTip("Load Succeed!");
        }
    }
}
