using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginationTestv_2.Models
{
    public class Category 
    {
        //
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        /// <summary>
        /// Category unique identification
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }
	}
}