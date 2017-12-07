using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriwestWebAPI.Models
{
    public class TrainingMessage
    {
        public int Id { get; set; }

        public string title { get; set; }

        public string message { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}


        