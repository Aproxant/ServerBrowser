using ServerBrowser.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerBrowser
{
    public class ServerBrowserCleaner
    {
        private readonly ServersDBContext dBContext;
        public ServerBrowserCleaner(ServersDBContext sb)
        {
            dBContext = sb;
        }
        public void clean()
        {
            if(dBContext.Database.CanConnect())
            {
                dBContext.ServerList.RemoveRange(dBContext.ServerList);
                dBContext.SaveChanges();
            }
        }
    }
}
