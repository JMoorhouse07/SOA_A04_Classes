using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.ServiceModel.Activation;
using System.ServiceModel;

namespace SOA_A04_Classes
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Customers : ICustomers
    {
        List<Customer> customers = new List<Customer>();

        public Customer AddCustomer(Customer inCustomer)
        {
            Customer response = new Customer();

            return response;
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        public Customer GetCustomer(string id)
        {
            Customer response = new Customer();

            return response;
        }

        public Customer UpdateCustomer(string id, Customer whichCustomer)
        {
            Customer response = new Customer();

            return response;
        }

        public Customer DeleteCustomer(string id)
        {
            Customer response = new Customer();

            return response;
        }
    }
}
