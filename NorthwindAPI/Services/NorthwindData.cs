using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;
using NorthwindAPI.Models;

namespace NorthwindAPI.Services
{
    public class NorthwindData : INorthwindData
    {
        private IDbConnection db;

        public NorthwindData(IConfiguration config)
        {
            string connString = config.GetConnectionString("defaultDb");
            db = new MySqlConnection(connString);
        }

        public void AddCategory(Category cat)
        {
            db.Insert<Category>(cat);
        }

        public void AddCustomer(Customer cust)
        {
            db.Insert<Customer>(cust);
        }

        public void CreateProduct(Product prod)
        {
            db.Insert<Product>(prod);
        }

        public void DeleteCategory(int id)
        {
            Category cat = new Category { categoryId = id };

            db.Delete<Category>(cat);
        }

        public void DeleteCustomerById(int id)
        {
            Customer cust = new Customer { custId = id };

            db.Delete<Customer>(cust);
        }

        public void DeleteProductById(int id)
        {
            Product prod = new Product { productId = id };

            db.Delete<Product>(prod);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return db.GetAll<Category>().ToList();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return db.GetAll<Customer>().ToList();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return db.GetAll<Product>().ToList();
        }

        public Category GetCategoryById(int id)
        {
            return db.Get<Category>(id);
        }

        public Customer GetCustomerById(int id)
        {
            return db.Get<Customer>(id);
        }

        public Product GetProductById(int id)
        {
            return db.Get<Product>(id);
        }

        public void UpdateCategory(Category cat)
        {
            db.Update<Category>(cat);
        }

        public void UpdateCustomer(Customer cust)
        {
            db.Update<Customer>(cust);
        }

        public void UpdateProduct(Product prod)
        {
            db.Update<Product>(prod);
        }
    }
}
