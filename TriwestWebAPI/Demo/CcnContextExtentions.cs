using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriwestWebAPI.Models;

namespace TriwestWebAPI.Demo
{
    public static class CcnContextExtentions 
    {

        public static void SeedData(this CcnContext context)
        {
            if (!context.TrainingMessages.Any())
            {
                var tmessage = new TrainingMessage
                {
                    Id = 10,
                    title = "Windstorm",
                    message = "This is a test training message for the CSR portal users that will use this portal",
                    CreatedOn = new DateTimeOffset(DateTime.Now)
                };

                context.TrainingMessages.Add(tmessage);
            }

            if (!context.Providers.Any())
            {
                context.Providers.AddRange(
                new Provider
                {
                    Id = 1,
                    taxId = "200923219",
                    npi = "123123",
                    providerName = "Charles Rogers",
                    groupName = "Barnes Medical Center",
                    addressPrimary = "2123 La Maridian St",
                    cityPrimary = "Palm Springs",
                    statePrimary = "CA",
                    postalCodePrimary = "90222"
                },
                new Provider
                {
                    Id = 2,
                    taxId = "564326985",
                    npi = "322222",
                    providerName = "Margaret Smith",
                    groupName = "Utica Medical Clinic",
                    addressPrimary = "2123 La Maridian St",
                    cityPrimary = "Fremont",
                    statePrimary = "CA",
                    postalCodePrimary = "94536"
                },
                new Provider
                {
                    Id = 3,
                    taxId = "650336521",
                    npi = "8688686",
                    providerName = "Larry Mills",
                    groupName = "North West Medical Center",
                    addressPrimary = "902 Edge Dr",
                    cityPrimary = "Phoenix",
                    statePrimary = "AZ",
                    postalCodePrimary = "84903"
                },
                new Provider
                {
                    Id = 4,
                    taxId = "6521023",
                    npi = "747747",
                    providerName = "Deborah Williams",
                    groupName = "Kaiser Permanente",
                    addressPrimary = "1 Alton Medical Center Dr",
                    cityPrimary = "Irvine",
                    statePrimary = "CA",
                    postalCodePrimary = "92690"
                });
            }
            if (!context.Veterans.Any())
            { 
                context.Veterans.AddRange(
                new Veteran
                {
                    Id = 1,
                    firstName = "Jimmy",
                    lastName = "Carter",
                    ssnLast4 = "2222",
                    memberNumber = "909234",
                    phoneNumber = "555-112-9572",
                    vamc = "Tenessee Valley VAMC",
                    dateOfBirth = DateTime.Parse("01/05/1917"),
                    dateOfDeath = DateTime.Parse("02/09/1964"),
                    emailAddress = "jimmy.carter@hotmail.com",
                    phones = new List<Phone>()
                     {
                        new Phone { PhoneNumber= "847-575-2342", PhoneType="Home"},
                        new Phone { PhoneNumber= "916-009-3423", PhoneType="Work"},
                        new Phone { PhoneNumber= "480-343-4566", PhoneType="Mobile"},
                        new Phone { PhoneNumber= "510-303-0202", PhoneType="Fax"},
                        new Phone { PhoneNumber= "901-343-2342", PhoneType="Other"}
                     },
                    addresses = new List<Address>() { new Address { Street = "PO Box 8845", City = "Omaha", State = "NE", PostalCode = "68007", AddressType = "Default" } },
                    hippaAlerts = new List<HippaAlert>() { new HippaAlert { AlertType = "Alert", BeginOn = DateTime.Now.AddDays(-360), EndOn = DateTime.Now.AddDays(130), Message = "Somebody has POA." } }
                },

                 new Veteran
                 {
                     Id = 2,
                     firstName = "Gerald",
                     lastName = "Ford",
                     gender = "M",
                     memberNumber = "34254",
                     dateOfBirth = DateTime.Parse("4/14/1913"),
                     phoneNumber = "555-112-9572",
                     program = "Distance",
                     ssnLast4 = "5465",
                     phones = new List<Phone>() { new Phone { PhoneNumber = "555-112-9572", PhoneType = "Home" } },
                     addresses = new List<Address>() { new Address { Street = "PO Box 8845", City = "Omaha", State = "NE", PostalCode = "68007", AddressType = "Default" } },
                     hippaAlerts = new List<HippaAlert>() { new HippaAlert { AlertType = "Alert", BeginOn = DateTime.Now.AddDays(-360), EndOn = DateTime.Now.AddDays(130), Message = "Somebody has POA." } }
                 });
            }
            context.SaveChanges();
        }
    }
}


