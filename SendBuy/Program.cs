using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SendBuy
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length <= 0) return;

            WndHookSender sendMessageHooker = new WndHookSender();

            string[] nowArgs = args;

            if (args != null && args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }

            ///买入操作
            if (args[0] == "B")
            {
                //发送证券
                IntPtr handleStock = (IntPtr)Convert.ToInt32("00071A96", 16);
                sendMessageHooker.SendTextString(args[1], handleStock);

                //发送数量
                IntPtr handleShares = (IntPtr)Convert.ToInt32("00141CDE", 16);
                sendMessageHooker.SendTextString(args[3], handleShares);

                //发送买入确认
                IntPtr handleOK = (IntPtr)Convert.ToInt32("00041C24", 16);
                sendMessageHooker.SendButton(handleOK);

            }

            ///卖出操作
            if (args[0] == "S")
            {
                //发送证券
                IntPtr handleStock = (IntPtr)Convert.ToInt32("", 16);
                sendMessageHooker.SendTextString(args[1], handleStock);

                //发送数量
                IntPtr handleShares = (IntPtr)Convert.ToInt32("", 16);
                sendMessageHooker.SendTextString(args[3], handleShares);

                //发送买入确认
                IntPtr handleOK = (IntPtr)Convert.ToInt32("", 16);
                sendMessageHooker.SendButton(handleOK);

            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// 通达信HooK
    /// </summary>
    public class WndHookSender
    {
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);
        private const int WM_SETTEXT = 0x000C;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, StringBuilder lParam);
        private int WM_GETTEXT = 0x0D;
        private int WM_CLICK = 0x00F5;

        /// <summary>
        /// 发送字符串到Edit
        /// </summary>
        /// <param name="str"></param>
        /// <param name="handle"></param>
        public void SendTextString(string str, IntPtr handle)
        {
            SendMessage(handle, WM_SETTEXT, IntPtr.Zero, str);
        }

        /// <summary>
        /// 发送按钮
        /// </summary>
        /// <param name="str"></param>
        /// <param name="handle"></param>
        public void SendButton(IntPtr handle)
        {
            SendMessage(handle, WM_CLICK, (IntPtr)0, "0");
        }
    }
}
