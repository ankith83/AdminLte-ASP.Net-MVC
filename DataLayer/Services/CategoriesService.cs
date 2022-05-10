using DataLayer.CommonLibraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{	
	public class CategoriesService
	{
		private readonly GenericRepository<Category> repository = new GenericRepository<Category>();

		public List<Category> GetAllCategories()
		{
			return repository.Get().ToList();
		}

		public bool AddCategory(Category category)
		{
			return repository.Insert(category);
		}
	}
}
