using BookStore.Contract.Models;
using BookStore.EntityCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.EntityCore.Extension
{
    public static class OrderItemExtension
    {
        public static OrderItemEntity ToEntity(this OrderItemModel model,int orderId)
        {
            var entity = new OrderItemEntity()
            {
                BookId = model.Id,
                OrderId = orderId,
                Quantity = model.Quantity
            };
            return entity;

        }

        public static OrderItemModel ToModel(this OrderItemEntity entity)
        {
            var model = new OrderItemModel()
            {
                Name=entity.Book.Name,
                PublishDate = entity.Book.PublishYear,
                Quantity = entity.Quantity
            };
            return model;

        }
    }
}
