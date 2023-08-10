using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
	public static class Messages
	{
		public static string ProductAdded = "Product Added!";
		public static string ProductNameInvalid = "Product Name Is Invalid!";
		public static string MaintenanceTime = "Maintenance Time!";
		public static string ProductsListed = "Products Listed!";
		public static string CategoriesListed = "Categories Listed!";
		public static string ProductCountOfCategoryError = "One Category Can Have Maximum 10 Products!";
		public static string ProductUpdated = "Product Updated!";
		public static string ProductNameAlreadyExists = "Product Name Already Exists!";
		public static string CategoryLimitExceded = "Category Limit Exceded!";
		public static string? AuthorizationDenied = "Authorization Denied!";
		internal static string UserRegistered;
		internal static User UserNotFound;
		internal static User PasswordError;
		internal static string SuccessfulLogin;
		internal static string UserAlreadyExists;
		internal static string AccessTokenCreated;
	}
}
