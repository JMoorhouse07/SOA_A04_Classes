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
    public interface IOrders
    {
        //POST Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "", Method = "POST")]
        Order AddOrder(Order inOrder);

        //GET Operation
        [OperationContract]
        [WebGet(UriTemplate = "")]
        List<Order> GetAllOrders();

        [OperationContract]
        [WebGet(UriTemplate = "{id}")]
        Order GetOrder(string id);

        //PUT Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "PUT")]
        Order UpdateOrder(string id, Order whichOrder);

        //DELETE Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        Order DeleteOrder(string id);
    }

    public class Order
    {
        [DataMember]
        public string ID;
        [DataMember]
        public string CustomerID;
        [DataMember]
        public string POnumber;
        [DataMember]
        public string OrderDate;
    }
}
