using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OuterTrading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 发送合约
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SendIns_Click(object sender, EventArgs e)
        {
            WndHookSender wndSender = new WndHookSender();

            try
            {
                IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_InsHandle.Text, 16);

                wndSender.SendTextString(this.textBox_ins.Text , handle);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ":Button_SendIns_Click");
            }
        }

        /// <summary>
        /// 发送数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SendShares_Click(object sender, EventArgs e)
        {
            WndHookSender wndSender = new WndHookSender();

            try
            {
                IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_SharesHandle.Text, 16);

                wndSender.SendTextString(this.textBox_Shares.Text, handle);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":Button_SendShares_Click");
            }
        }

        /// <summary>
        /// 发送价格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SendPrice_Click(object sender, EventArgs e)
        {
            WndHookSender wndSender = new WndHookSender();

            try
            {
                IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_PriceHandle.Text, 16);

                wndSender.SendTextString(this.textBox_price.Text, handle);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":Button_SendPrice_Click");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WndHookSender wndSender = new WndHookSender();

            try
            {
                IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_BuyHandle.Text, 16);
                wndSender.SendButton(handle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":Button1_Click");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WndHookSender wndSender = new WndHookSender();

            try
            {
                IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_SellHandle.Text, 16);
                wndSender.SendButton(handle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":Button2_Click");
            }
        }

        private void Button_SendBuy_Click(object sender, EventArgs e)
        {
            WndHookSender wndSender = new WndHookSender();

            try
            {
                IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_BuyHandle.Text, 16);
                wndSender.SendButton(handle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":Button_SendBuy_Click");
            }
        }

        private void Button_SendSell_Click(object sender, EventArgs e)
        {
            WndHookSender wndSender = new WndHookSender();

            try
            {
                IntPtr handle = (IntPtr)Convert.ToInt32(this.textBox_SellHandle.Text, 16);
                wndSender.SendButton(handle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":Button_SendSell_Click");
            }
        }

        /// <summary>
        /// 计时器开关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Start_Click(object sender, EventArgs e)
        {
            //每次开启循环前先清空，然后初始设为“”
            try
            {
                if(this.textBox_Path.Text == "")
                {
                    MessageBox.Show("MC输出文件为null,请先确认MC输出文件路径");
                    return;
                }

                ClearTxt(this.textBox_Path.Text);

                this.timer1.Enabled = true;
                this.timer1.Start();

                this.button_Start.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Button_Start_Click");

                this.timer1.Enabled = false;
                this.timer1.Stop();

                this.button_Start.Enabled = true;

            }
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            this.button_Start.Enabled = true;

            this.timer1.Enabled = false;
            this.timer1.Stop();
        }

        private void AppendText(string info)
        {
            if(this.InvokeRequired) 
            {
                this.BeginInvoke(new Action<string>(AppendText), info);
            }

           this.richTextBox1.AppendText("\r\n" + info);
        }

        public string ReadTxt(string path)
        {
            try
            {
                List<string> lastTxtSingleInfo = new List<string>();

                //设置文件共享方式为读写，FileShare.ReadWrite，这样的话，就可以打开了
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    lastTxtSingleInfo.Add(line.ToString());
                }

                fs.Close();
                sr.Close();

                if (lastTxtSingleInfo.Count == 0)
                {
                    return "";
                }
                else
                {
                    return lastTxtSingleInfo[lastTxtSingleInfo.Count - 1];
                }
            }
            catch (Exception ex)
            {
                return "";
            }

        }

        public void ClearTxt(string path)
        {
            try
            {
                //设置文件共享方式为读写，FileShare.ReadWrite，这样的话，就可以打开了
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                fs.SetLength(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("清空文本失败:" + ex.Message);
            }

        }

        string m_lastTxtSingleInfo = "";
        private void Timer_Event(object sender, EventArgs e)
        {
            this.timer1.Stop();

            string lastSingleInfo = ReadTxt(this.textBox_Path.Text);
            if (lastSingleInfo.CompareTo(m_lastTxtSingleInfo) == 0)
            {

            }
            else
            {
                AppendText(lastSingleInfo);

                m_lastTxtSingleInfo = lastSingleInfo;

                //解构-下单

            }

            this.timer1.Start();
        }
    }
}
