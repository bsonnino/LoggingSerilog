using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Windows.ApplicationModel;

namespace LoggingSerilog.Model
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }


        public static IEnumerable<Customer> GetCustomers()
        {
            string customerXml = Path.Combine(Package.Current.InstalledLocation.Path, "Customers.xml");
            return XDocument.Load(customerXml).Descendants("Customer").Select(c =>
                new Customer
                {
                    Id = c.Element("CustomerID")?.Value,
                    Name = c.Element("CompanyName")?.Value,
                    Address = c.Element("Address")?.Value,
                    City = c.Element("City")?.Value,
                    Country = c.Element("Country")?.Value,
                    Phone = c.Element("Phone")?.Value,
                });
        }
    }
}
