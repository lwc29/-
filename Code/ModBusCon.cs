using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MainPanel
{
    class ModBusCon
    {
        //RTU模式创建的关联函数
        [DllImport("modbus.dll", EntryPoint = "modbus_new_rtu",CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr modbus_new_rtu(string device, int baud,char parity, int data_bit, int stop_bit);

        //TCP模式创建的关联函数
        [DllImport("modbus.dll", EntryPoint = "modbus_new_tcp",CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr modbus_new_tcp(string ip_address, int port);

        //共通的操作函数
        [DllImport("modbus.dll", EntryPoint ="modbus_set_slave", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_set_slave(IntPtr ctx, int slave);

        [DllImport("modbus.dll", EntryPoint = "modbus_connect", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_connect(IntPtr ctx);

        [DllImport("modbus.dll", EntryPoint = "modbus_set_response_timeout", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_set_response_timeout(IntPtr ctx, int tv_sec,int to_usec);  //string改为int

        [DllImport("modbus.dll", EntryPoint = "modbus_read_bits",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_read_bits(IntPtr ctx, int addr,int nb, byte[] dest);

        [DllImport("modbus.dll", EntryPoint = "modbus_read_input_bits", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_read_input_bits(IntPtr ctx,int addr, int nb, byte[] dest);

        [DllImport("modbus.dll", EntryPoint = "modbus_read_registers",CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_read_registers(IntPtr ctx,int addr, int nb, UInt16[] dest); //长度为nb个寄存器

        [DllImport("modbus.dll", EntryPoint = "modbus_read_input_registers",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_read_input_registers(IntPtr ctx, int addr, int nb, UInt16[] dest);
 
        [DllImport("modbus.dll", EntryPoint = "modbus_write_bit",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_write_bit(IntPtr ctx,int coil_addr, int status);

        [DllImport("modbus.dll", EntryPoint = "modbus_write_register",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_write_register(IntPtr ctx, int reg_addr, int value);

        [DllImport("modbus.dll", EntryPoint = "modbus_write_bits", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_write_bits(IntPtr ctx,int co1l_addr, int nb, byte[] status);

        [DllImport("modbus.dll", EntryPoint = "modbus_write_registers",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_write_registers(IntPtr ctx,int reg_addr, int nb, UInt16[] status);

        [DllImport("modbus.dll", EntryPoint = "modbus_write_and_read_registers",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern int modbus_write_and_read_registers (IntPtr ctx,int write_addr, int write_nb, UInt16[] src,
        int read_addr, int read_nb, UInt16[] dest);

        [DllImport("modbus.dll", EntryPoint = "modbus_close", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern void modbus_close(IntPtr ctx);

        [DllImport("modbus.dll", EntryPoint = "modbus_free",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern void modbus_free(IntPtr ctx);

        [DllImport("modbus.dll", EntryPoint = "modbus_strerror", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern string modbus_strerror(int errnum);


    }
    //https://blog.csdn.net/qq_23670601/article/details/82155378
}
