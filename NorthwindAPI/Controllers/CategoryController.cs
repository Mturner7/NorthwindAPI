using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.Models;
using System;
using System.Collections.Generic;
using NorthwindAPI.Services;

namespace NorthwindAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private INorthwindData northData;

        public CategoryController(INorthwindData _northdata)
        {
            northData = _northdata;
        }

        [HttpGet]
        public IEnumerable<Category> GetCategories()
        {
            return northData.GetAllCategories();
        }

        [HttpGet("{catid}")]
        public Category GetCategory(int catid)
        {
            return northData.GetCategoryById(catid);
        }

        [HttpPut("update")]
        public void UpdateACategory(Category cat)
        {
            northData.UpdateCategory(cat);
        }

        [HttpPost("add")]
        public void CreateCategory(Category cat)
        {
            northData.AddCategory(cat);
        }

        [HttpDelete("delete/{catid}")]
        public void DeleteCategory(int catid)
        {
            northData.DeleteCategory(catid);
        }
    }
}
