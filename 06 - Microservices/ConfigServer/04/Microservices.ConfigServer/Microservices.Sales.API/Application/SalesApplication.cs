using Microservices.Sales.API.Infrastructure.Data.Context;
using Microservices.Sales.API.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Sales.API.Application
{
    public class SalesApplication
    {
        private readonly BikeStoreContext _bikeStoreContext;
        public SalesApplication(BikeStoreContext bikeStoreContext)
        {
            _bikeStoreContext = bikeStoreContext;
        }
        public List<OrderDto> ListOrders()
        {
            var query = from o in _bikeStoreContext.Orders
                        join c in _bikeStoreContext.Customers on o.CustomerId equals c.CustomerId
                        join s in _bikeStoreContext.staff on o.StaffId equals s.StaffId
                        join st in _bikeStoreContext.Stores on o.StoreId equals st.StoreId
                        select new OrderDto
                        {
                            OrderId = o.OrderId,
                            OrderStatus = o.OrderStatus,
                            OrderDate = o.OrderDate,
                            CustomerId = o.CustomerId,
                            Customer = new CustomerDto
                            {
                                CustomerId = c.CustomerId,
                                FirstName = c.FirstName,
                                LastName = c.LastName
                            },
                            StaffId = o.StaffId,
                            Staff = new StaffDto
                            {
                                StaffId = s.StaffId,
                                FirstName = s.FirstName,
                                LastName = s.LastName
                            },
                            StoreId =o.StoreId,
                            Store = new StoreDto
                            {
                                StoreId = st.StoreId,
                                StoreName = st.StoreName
                            }
                        };

            List<OrderDto> orders = query.ToList();

            return orders;
        }
    }
}
