using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NDde.Server;

namespace DDEServer
{
    public partial class Form1 : Form
    {
        private MyDDEServer m_server = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                //申明并实例化一个DdeClient对象 
                m_server = new MyDDEServer("M");
                m_server.Register();
                

                for (int i = 0; i < 100000; i++)
                {
                    m_server.Advise("BID", "USDJPY");
                    System.Threading.Thread.Sleep(1000);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
