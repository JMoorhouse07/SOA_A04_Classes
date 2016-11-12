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
    public class Products : IProducts
    {
        List<Product> products = new List<Product>();

        public Product AddProduct(Product inProduct)
        {
            Product response = new Product();

            return response;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product UpdateProduct(string id, Product whichProduct)
        {
            Product response = new Product();

            return response;
        }

        public Product GetProduct(string id)
        {
            return products.FirstOrDefault(e => e.ID.Equals(id));
        }

        public Product DeleteProduct(string id)
        {
            Product response = new Product();
            return response;
        }
    }
}
