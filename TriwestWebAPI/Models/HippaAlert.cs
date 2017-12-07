using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriwestWebAPI.Models
{
    public class HippaAlert
    {
        public int Id {get; set;}
        public string AlertType { get; set; }
        public DateTimeOffset BeginOn { get; set; }
        public DateTimeOffset EndOn { get; set; }
        public string Message { get; set; }
    }
}
