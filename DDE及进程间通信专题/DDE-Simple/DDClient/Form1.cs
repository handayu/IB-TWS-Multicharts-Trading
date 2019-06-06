using NDde.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDClient
{
    public partial class Form1 : Form
    {
        private DdeClient client = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                //申明并实例化一个DdeClient对象 
                client = new DdeClient("M", "BID", this);
                client.Advise += client_Advise;
                //连接到DDE服务器 
                client.Connect();
                //循环获取数据 
                client.StartAdvise("USDJPY", 1, true, 60000);
            }
            catch (Exception ex)
            {
                displayTextBox.Text = "MainForm_Load: " + ex.Message;
            }

        }

        private void client_Advise(object sender, DdeAdviseEventArgs args)
        {
            //显示更新数据 
            displayTextBox.Text = "OnAdvise: " + args.Text;
        }

    }
}
