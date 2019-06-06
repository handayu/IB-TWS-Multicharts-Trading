using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDde.Server;

namespace DDEServer
{
    public class MyDDEServer:DdeServer
    {
        /// <summary>
        /// 父类构造
        /// </summary>
        /// <param name="service"></param>
        public MyDDEServer(string service):base(service)
        {
        }

        protected override byte[] OnAdvise(string topic, string item, int format)
        {
            string str = "111.109";
            byte[] b = Encoding.Default.GetBytes(str);
            return b;
        }
    }
}
