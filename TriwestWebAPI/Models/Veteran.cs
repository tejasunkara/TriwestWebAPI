using System;
using System.Collections.Generic;

namespace TriwestWebAPI.Models
{
    public class Veteran
    {
        public int Id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string memberNumber { get; set; }

        public string ssnLast4 { get; set; }

        public DateTime? dateOfBirth { get; set; }
        
        public DateTime? dateOfDeath { get; set; }
        public int Age
        {
            get
            {
                if (!this.dateOfBirth.HasValue)
                    return 0;
                var today = DateTime.Today;
                var age = today.Year - this.dateOfBirth.Value.Year;
                return this.dateOfBirth > today.AddYears(-age) ? age-- : age; // in case of leap year
            }
        }
        public string gender { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }
        public string vamc { get; set; }
        public string program { get; set; }
        public string additionalEmailAddress { get; set; }
        public string subscriptionType { get; set; }
        public string countOfAuths { get; set; }
        public virtual List<Phone> phones { get; set; }
        public virtual List<Address> addresses { get; set; }
        public virtual List<HippaAlert> hippaAlerts { get; set; }
    }
}
