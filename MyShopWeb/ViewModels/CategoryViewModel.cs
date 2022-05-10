using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShopWeb.ViewModels
{
	public class CategoryViewModel
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string ParentName { get; set; }
    }
}