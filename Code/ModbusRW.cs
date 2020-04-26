using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPanel.Code
{
    class ModbusRW
    {
        static IntPtr ctx;
        public static int ModbusOpen=-1;  //判断串口是否打开
        static int MbStatus = 0;
        static char PrityBit;
        public void ConnectRTU()
        {
            string PortNo = CommunicationSetting.CommunicationHandle.portComboBox.Text;
            int Rate = Convert.ToInt32(CommunicationSetting.CommunicationHandle.baudRateComboBox.Text);
            int StopBit = Convert.ToInt16(CommunicationSetting.CommunicationHandle.stopBitComboBox.Text);
            int DataBit = Convert.ToInt16(CommunicationSetting.CommunicationHandle.dataBittxb.Text);
            string PrityBitstr =Convert.ToString( CommunicationSetting.CommunicationHandle.ParityCmb.Text);
            int rc = Convert.ToInt32(CommunicationSetting.CommunicationHandle.deviceAddrNumerUpd.Value);//从站地址 
            int ModbusTimeOut = Convert.ToInt16(CommunicationSetting.CommunicationHandle.comtimeouttxb.Text);//通讯超时
            switch (PrityBitstr)
            {
                case "None":
                    PrityBit = 'N';
                    break;
                case "Odd":
                    PrityBit = 'O';
                    break;
                case "Even":
                    PrityBit = 'E';
                    break;
            }
            ctx = ModBusCon.modbus_new_rtu(PortNo, Rate, PrityBit, DataBit, StopBit);
            if (ctx != null)
            {
                ModbusTimeOut = ModbusTimeOut * 1000;
                int tv_sec = ModbusTimeOut / 1000000;
                int tv_usec = ModbusTimeOut - tv_sec * 1000000;

                ModBusCon.modbus_set_response_timeout(ctx, tv_sec, tv_usec);

                ModBusCon.modbus_set_slave(ctx, rc);

                ModbusOpen = ModBusCon.modbus_connect(ctx);
               
                if (ModbusOpen < 0)
                {
                    //MessageBox.Show("串口未打开，请重试！", "温馨提示");
                   
                    CommunicationSetting.CommunicationHandle.OpenPortbt.Text = "打开串口";
                    CommunicationSetting.CommunicationHandle. portComboBox.Enabled = true;
                    CommunicationSetting.CommunicationHandle.portComboBox.Enabled = true;
                    CommunicationSetting.CommunicationHandle.baudRateComboBox.Enabled = true;
                    CommunicationSetting.CommunicationHandle.comtimeouttxb.Enabled = true;
                    CommunicationSetting.CommunicationHandle.ParityCmb.Enabled = true;
                    CommunicationSetting.CommunicationHandle.stopBitComboBox.Enabled = true;
                    return;
                }
                CommunicationSetting.CommunicationHandle.portComboBox.Enabled = false;
                CommunicationSetting.CommunicationHandle.portComboBox.Enabled = false;
                CommunicationSetting.CommunicationHandle.baudRateComboBox.Enabled = false;
                CommunicationSetting.CommunicationHandle.comtimeouttxb.Enabled = false;
                CommunicationSetting.CommunicationHandle.ParityCmb.Enabled = false;
                CommunicationSetting.CommunicationHandle.stopBitComboBox.Enabled = false;
            }
            else
            {
                CommunicationSetting.CommunicationHandle.textBox4.Text += "通讯超时" + "\r\n";
            }

        }
        public void CloseRTU()
        {
            ModBusCon.modbus_close(ctx);
            ModBusCon.modbus_free(ctx);
            ModbusOpen = -1;
            CommunicationSetting.CommunicationHandle.portComboBox.Enabled = true;
            CommunicationSetting.CommunicationHandle.portComboBox.Enabled = true;
            CommunicationSetting.CommunicationHandle.baudRateComboBox.Enabled = true;
            CommunicationSetting.CommunicationHandle.comtimeouttxb.Enabled = true;
            CommunicationSetting.CommunicationHandle.ParityCmb.Enabled = true;
            CommunicationSetting.CommunicationHandle.stopBitComboBox.Enabled = true;

        }
        public void ReadRegister(int RegisterAddr, int readCount, ushort[] desk)
        {
            int rc = Convert.ToInt32(CommunicationSetting.CommunicationHandle.deviceAddrNumerUpd.Value);//从站地址 
            MbStatus =  ModBusCon.modbus_read_registers(ctx, RegisterAddr, readCount, desk);
            if (MbStatus == -1)
            {
                 SetText("通讯超时" + "\r\n");
                //CommunicationSetting.CommunicationHandle.textBox4.Invoke(() => {
                //    CommunicationSetting.CommunicationHandle.textBox4.Text += "通讯超时" + "\r\n";
                //});
                //CommunicationSetting.CommunicationHandle.textBox4.Text += "通讯超时" + "\r\n";

            }
            else
                SetText($"结果:{MbStatus}，desk {desk[0] }");
                //CommunicationSetting.CommunicationHandle.textBox4.Text += $"结果:{MbStatus}，desk {desk.ToString() }";
        }

        delegate void SetTextCallback(string text);

        

        private void SetText(string text)
        {
 
            if (CommunicationSetting.CommunicationHandle.textBox4.InvokeRequired)//如果调用控件的线程和创建创建控件的线程不是同一个则为True
            {
                while (!CommunicationSetting.CommunicationHandle.textBox4.IsHandleCreated)
                {
                    //解决窗体关闭时出现“访问已释放句柄“的异常
                    if (CommunicationSetting.CommunicationHandle.textBox4.Disposing || CommunicationSetting.CommunicationHandle.textBox4.IsDisposed)
                        return;
                }
                SetTextCallback d = new SetTextCallback(SetText);
                CommunicationSetting.CommunicationHandle.textBox4.BeginInvoke(d, new object[] { text });
            }
            else
            {
                //string aa = CommunicationSetting.CommunicationHandle.textBox4.Text;
                //aa += text;
                CommunicationSetting.CommunicationHandle.textBox4.Text = text + "\r\n";

            }
        }

        public void WriteRegister(int RegisterAddr, int value)
        {
            int rc = Convert.ToInt32(CommunicationSetting.CommunicationHandle.deviceAddrNumerUpd.Value);//从站地址 
            MbStatus = ModBusCon.modbus_write_register(ctx, RegisterAddr, value);
           
            if (MbStatus == -1)
            {
                CommunicationSetting.CommunicationHandle.textBox4.Text = "通讯超时" + "\r\n";
            }

        }

        //ModbusTCP
        public void ConnectTCP()
        {
            string IPAddr = CommunicationSetting.CommunicationHandle.IpAddrtxb.Text;
            string Porttxb = CommunicationSetting.CommunicationHandle.Porttxb.Text;
            ModBusCon.modbus_connect(ctx);
        }
        public void CloseTCP()
        {
            ModBusCon.modbus_close(ctx);
            ModBusCon.modbus_free(ctx);
        }
    }
}
