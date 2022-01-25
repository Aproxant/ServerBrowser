using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerBrowser.Models
{
    public class UpdateServer
    {
        public bool Mode { get; set; }
        public int PlayerNumber { get; set; }
    }
}
