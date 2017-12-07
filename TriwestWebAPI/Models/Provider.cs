using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriwestWebAPI.Models
{
    public class Provider
    {
        public int Id { get; set; }

        public string taxId { get; set; }

        public string npi { get; set; }

        public string providerName { get; set; }

        public string groupName { get; set; }

        public string addressPrimary { get; set; }

        public string cityPrimary { get; set; }

        public string statePrimary { get; set; }

        public string postalCodePrimary { get; set; }
    }
}
