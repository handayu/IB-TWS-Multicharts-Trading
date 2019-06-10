using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDde.Server;

namespace DDEServer
{

    /// <summary>
    /// DDEServer服务
    /// </summary>
    public class DDEServer : DdeServer
    {
        private System.Threading.Thread m_adviseThread = null;

        /// <summary>
        /// 父类构造
        /// </summary>
        /// <param name="service"></param>
        public DDEServer(string service) : base(service)
        {
            m_adviseThread = new System.Threading.Thread(ThreadAdvise);
            m_adviseThread.Start();
        }

        /// <summary>
        /// 客户端订阅，CallBack
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="item"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        protected override byte[] OnAdvise(string topic, string item, int format)
        {
            string str = "111.109";
            byte[] b = Encoding.Default.GetBytes(str);
            return b;
        }

        /// <summary>
        /// 服务端线程推送线程
        /// </summary>
        public void ThreadAdvise()
        {
            this.Register();
            while (true)
            {
                try
                {
                    this.Advise("BID", "USDJPY");
                    System.Threading.Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }

}
