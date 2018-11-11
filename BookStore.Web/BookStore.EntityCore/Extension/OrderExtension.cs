using BookStore.Contract.Models;
using BookStore.EntityCore.Entity;
using System;
using System.Linq;

namespace BookStore.EntityCore.Extension
{
    public static class OrderExtension
    {
        public static OrderEntity ToEntity(this AddOrderModel model)
        {
            var entity = new OrderEntity()
            {
                CustomerId = model.CustomerId,
                OrderDate = DateTime.UtcNow
            };
            return entity;
        }
        public static OrderModel ToModel(this OrderEntity entity)
        {
            var model = new OrderModel()
            { Id = entity.Id,
                Date = entity.OrderDate,
                FullName = string.Format("{0} {1}",entity.Customer.FirstName, entity.Customer.LastName)
            };
            return model;
        }
        public static OrderDetailModel ToDetailModel(this OrderEntity entity)
        {
            var model = new OrderDetailModel()
            {
                Id = entity.Id,
                Date = entity.OrderDate,
                FullName = string.Format("{0} {1}", entity.Customer.FirstName, entity.Customer.LastName),
                OrderItems = entity.OrderItems.Select(x=>x.ToModel())
            };
            return model;
        }
    }
}
