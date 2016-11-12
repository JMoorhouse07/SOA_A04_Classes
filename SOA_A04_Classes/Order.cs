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
    public class Orders : IOrders
    {
        List<Order> orders = new List<Order>();

        public Order AddOrder(Order inOrder)
        {
            Order response = new Order();

            return response;
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }

        public Order UpdateOrder(string id, Order whichOrder)
        {
            Order response = new Order();

            return response;
        }

        public Order GetOrder(string id)
        {
            return orders.FirstOrDefault(e => e.ID.Equals(id));
        }

        public Order DeleteOrder(string id)
        {
            Order response = new Order();
            return response;
        }
    }
}
