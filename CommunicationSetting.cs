using MainPanel.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPanel
{
    public partial class CommunicationSetting : Form
    {
        public static CommunicationSetting CommunicationHandle;

        public CommunicationSetting()
        {
            InitializeComponent();
            CommunicationHandle = this;
            portComboBox.Text = "COM3";
            baudRateComboBox.Text = "9600";
            ParityCmb.Text = "None";
            stopBitComboBox.Text = "1";
            //SearchPort();
        }
        private void CommunicationSetting_Load(object sender, EventArgs e)
        {
            
        }
        private void IPConbt_Click(object sender, EventArgs e)
        {
            ModbusRW modbusRw = new ModbusRW();
            IPConbt.Text = IPConbt.Text == "连    接"?"关    闭" : "连    接";
            if (IPConbt.Text == "关    闭")
            {
                modbusRw.ConnectTCP();
            }
            else
            {
                modbusRw.CloseTCP();
            }
        }
        private void OpenPortbt_Click(object sender, EventArgs e)
        {
           
            OpenPortbt.Text = OpenPortbt.Text == "打开串口" ? "关闭串口" : "打开串口";
            ModbusRW modbusRw = new ModbusRW();
            if (OpenPortbt.Text == "关闭串口")
            {
                modbusRw.ConnectRTU();
                Thread th = new Thread(new ThreadStart(read));
                th.Start();

                //modbusRw.WriteRegister(91, 1);
            }
            else if (OpenPortbt.Text == "打开串口")
            {
                modbusRw.CloseRTU();

            }
 

        }

        private static AutoResetEvent handleA = new AutoResetEvent(false);
        private void read()
        {
            while (handleA.WaitOne())
            {
                while (true)
                {
                    ushort[] desk = new ushort[2];
                    modbusRW.ReadRegister(1, 1, desk);
                    if (desk[0] == 0)
                    {
                        Trace.WriteLine($"设备停止{desk[0]},{desk[1]}");
                        handleA.Reset();
                        break;
                    } 
                    else if(desk[0] == 1128)
                    {
                        Trace.WriteLine($"接触传感器{desk[0]},{desk[1]}");
                        ushort[] direct = new ushort[1];
                        modbusRW.ReadRegister(23, 1, direct);
 
                        //内部脉冲
                        modbusRW.WriteRegister(17, 0);
                        modbusRW.WriteRegister(18, 0);
                        modbusRW.WriteRegister(20, 0);

                        Thread.Sleep(100);

                        int a = (int)direct[0];
                        if (a == 0)
                            modbusRW.WriteRegister(23, 1);
                        else
                            modbusRW.WriteRegister(23, 0);
                    } 
                    else
                    {
                        Trace.WriteLine($"{desk[0]},{desk[1]}");
                    }
                        
                    Thread.Sleep(30);
                }
            }
        }

   


        static ModbusRW modbusRW;
        private void button1_Click(object sender, EventArgs e)
        {
            if(modbusRW == null)
                modbusRW = new ModbusRW();
            Button button =(Button)sender;
            ushort[] desk = new ushort[2];
            ushort[] data = new ushort[3];
            data[0] = Convert.ToUInt16(textBox1.Text);
            data[1] = Convert.ToUInt16(textBox2.Text);
            data[2] = Convert.ToUInt16(textBox3.Text);

            //内部脉冲
            modbusRW.WriteRegister(17, 0);
            modbusRW.WriteRegister(18, 0);
            modbusRW.WriteRegister(20, 0);
            //设置连续运动速度相关
            modbusRW.WriteRegister(77, data[0]);
            modbusRW.WriteRegister(75, data[1]);
            modbusRW.WriteRegister(76, data[2]);
            switch (button.Name)
            {
                case "button1":
                    //modbusRW.ReadRegister(18, 1, desk);
                    modbusRW.WriteRegister(18, 3);
                    handleA.Set();
                    break;
                case "button2":
                    modbusRW.WriteRegister(18, 4);
                    handleA.Set();
                    break;
                case "button3":
                    modbusRW.WriteRegister(18, 6);
                    handleA.Reset();
                    break;
            }
        }

        private bool isRun = false;
        

        private void read2()
        {
            while ( 1 == 1)
            {
                Thread.Sleep(200);
                while (isRun)
                {
                    ushort[] desk = new ushort[2];
                    modbusRW.ReadRegister(77, 1, desk);
                    Trace.WriteLine(desk[0]);
                    Thread.Sleep(200);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)//char8是退格键键值,限制textBox只能输入数字
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
    }
}
