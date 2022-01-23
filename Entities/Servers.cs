using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerBrowser.Entities
{
    public class Servers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public DateTime lastActive { get; set; }
        public bool Mode { get; set; }
        public int playerNumber { get; set; }
    }
}
