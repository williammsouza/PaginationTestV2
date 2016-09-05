using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginationTestv_2.Models
{
    public class Product 
    {
        public Product()
        {
            Id = 0;
        }
        public Product(int id, string name, decimal price, IEnumerable<Category> categories, IEnumerable<string> tags, bool isDisabled = false)
        {
            Id = id;
            Name = name;
            Price = price;
            Categories = categories.ToList();
            Tags = tags.ToList();
            IsDisabled = isDisabled;
        }
        /// <summary>
        /// Product Unique identification
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Product price in local currency
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// List of categories
        /// </summary>
        public List<Category> Categories { get; set; }
        /// <summary>
        /// List of tags
        /// </summary>
        public List<string> Tags { get; set; }
        /// <summary>
        /// Product is disabled and should not be displayed
        /// </summary>
        public bool IsDisabled { get; set; }
	}
}