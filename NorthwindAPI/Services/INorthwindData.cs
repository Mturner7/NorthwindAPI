using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindAPI.Services
{
    public interface INorthwindData
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void UpdateProduct(Product prod);
        void CreateProduct(Product prod);
        void DeleteProductById(int id);

        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void UpdateCustomer(Customer cust);
        void AddCustomer(Customer cust);
        void DeleteCustomerById(int id);

        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void UpdateCategory(Category cat);
        void AddCategory(Category cat);
        void DeleteCategory(int id);
    }
}
