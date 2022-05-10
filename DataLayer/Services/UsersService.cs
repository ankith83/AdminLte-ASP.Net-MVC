using DataLayer.CommonLibraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer.Services
{
	public class UsersService
	{
		private readonly GenericRepository<User> repository = new GenericRepository<User>();

		public User AuthenticateUser(string UserName, string Password)
		{
			try
			{
				var user = repository.Get(u => u.UserName == UserName && u.Password == Password && u.IsActive == true).FirstOrDefault();
				if (user != null)
					return user;
			}
			catch
			{
				throw;
			}

			return null;
		}
	}
}