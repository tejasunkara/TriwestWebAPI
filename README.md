# TriwestWebAPI
.Net Core Web API

About this repo:

By default the App is set to run on port 5000, using kerstel

There are four end points that can be hit right now:

1. http://localhost:5000/api/values
   returns: ["value1","value2"]
2. http://localhost:5000/api/veterans/1
   
   returns veteran data by Id in json format:
   
   {"id":1,"firstName":"Jimmy","lastName":"Carter","memberNumber":"909234","ssnLast4":"2222","dateOfBirth":"1917-01-05T00:00:00",
   "dateOfDeath":"1964-02-09T00:00:00","age":100,"gender":null,"phoneNumber":"555-112-9572","emailAddress":"jimmy.carter@hotmail.com",
   "vamc":"Tenessee Valley VAMC","program":null,"additionalEmailAddress":null,"subscriptionType":null,"countOfAuths":null,
   "phones":[{"id":7,"phoneNumber":"847-575-2342","phoneType":"Home"},
   {"id":8,"phoneNumber":"916-009-3423","phoneType":"Work"},
   {"id":9,"phoneNumber":"480-343-4566","phoneType":"Mobile"},
   {"id":10,"phoneNumber":"510-303-0202","phoneType":"Fax"},
   {"id":11,"phoneNumber":"901-343-2342","phoneType":"Other"}],
   "addresses":[{"id":3,"street":"PO Box 8845","city":"Omaha","state":"NE","postalCode":"68007","addressType":"Default"}],
   "hippaAlerts":[{"id":3,"alertType":"Alert","beginOn":"2016-12-11T18:58:53.2343785-07:00","endOn":"2018-04-15T18:58:53.2343785-07:00",
   "message":"Somebody has POA."}]}
   
3. http://localhost:5000/api/providers
   
   returns list of all providers in json format:
   
   [{"id":1,"taxId":"200923219","npi":"123123","providerName":"Charles Rogers","groupName":"Barnes Medical Center",
   "addressPrimary":"2123 La Maridian St","cityPrimary":"Palm Springs","statePrimary":"CA","postalCodePrimary":"90222"},
   {"id":2,"taxId":"564326985","npi":"322222","providerName":"Margaret Smith","groupName":"Utica Medical Clinic",
   "addressPrimary":"2123 La Maridian St","cityPrimary":"Fremont","statePrimary":"CA","postalCodePrimary":"94536"},
   {"id":3,"taxId":"650336521","npi":"8688686","providerName":"Larry Mills","groupName":"North West Medical Center",
   "addressPrimary":"902 Edge Dr","cityPrimary":"Phoenix","statePrimary":"AZ","postalCodePrimary":"84903"},
   {"id":4,"taxId":"6521023","npi":"747747","providerName":"Deborah Williams","groupName":"Kaiser Permanente",
   "addressPrimary":"1 Alton Medical Center Dr","cityPrimary":"Irvine","statePrimary":"CA","postalCodePrimary":"92690"}]
   
 4. http://localhost:5000/api/trainingmessage
 
    returns the latest training message in json format:
    [{"id":10,"title":"Windstorm","message":"This is a test training message for the CSR portal users that will use this portal",
    "createdOn":"2017-12-06T18:58:53.2333774-07:00"}]
