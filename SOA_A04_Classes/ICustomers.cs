using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SOA_A04_Classes
{
    [ServiceContract]
    [XmlSerializerFormat]
    public interface ICustomers
    {
        //POST Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "", Method = "POST")]
        Customer AddCustomer(Customer inCustomer);

        //GET Operation
        [OperationContract]
        [WebGet(UriTemplate = "")]
        List<Customer> GetAllCustomers();

        [OperationContract]
        [WebGet(UriTemplate = "{id}")]
        Customer GetCustomer(string id);

        //PUT Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "PUT")]
        Customer UpdateCustomer(string id, Customer whichCustomer);

        //DELETE Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        Customer DeleteCustomer(string id);
    }

    public class Customer
    {
        [DataMember]
        public string ID;
        [DataMember]
        public string FirstName;
        [DataMember]
        public string LastName;
        [DataMember]
        public string PhoneNumber;
    }
}
