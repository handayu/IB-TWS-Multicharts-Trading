using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OuterTrading
{
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
        public void SendTextString(string str,IntPtr handle)
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
