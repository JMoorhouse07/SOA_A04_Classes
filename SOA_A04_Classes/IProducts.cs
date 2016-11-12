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
    public interface IProducts
    {
        //POST Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "", Method = "POST")]
        Product AddProduct(Product inProduct);

        //GET Operation
        [OperationContract]
        [WebGet(UriTemplate = "")]
        List<Product> GetAllProducts();

        [OperationContract]
        [WebGet(UriTemplate = "{id}")]
        Product GetProduct(string id);

        //PUT Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "PUT")]
        Product UpdateProduct(string id, Product whichProduct);

        //DELETE Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        Product DeleteProduct(string id);
    }

    [DataContract]
    public class Product
    {
        [DataMember]
        public string ID;
        [DataMember]
        public string Name;
        [DataMember]
        public string Price;
        [DataMember]
        public string Weight;
        [DataMember]
        public string InStock;
    }
}
