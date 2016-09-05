using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginationTestv_2.Helpers
{
    public static class DefaultValues
    {
        //
        public static SelectList ItemsPerPageList
        {
            get
            {
                return (new SelectList(new [] { 5, 10, 15 }, selectedValue: 5));
            }
        }
	}
}