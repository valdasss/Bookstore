using BookStore.Contract.Models;
using BookStore.EntityCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.EntityCore.Extension
{
    public static class CustomerExtensions
    {
        public static CustomerModel ToModel( this CustomerEntity customerEntity)
        {
            var model = new CustomerModel()
            {
                Id = customerEntity.Id,
                FirstName = customerEntity.FirstName,
                LastName = customerEntity.LastName
            };
            return model;
        }

        public static CustomerEntity ToEntity(this CustomerModel customerModel)
        {
            var entity = new CustomerEntity()
            {            
                FirstName = customerModel.FirstName,
                LastName = customerModel.LastName
            };
            return entity;
        }
    }
}
