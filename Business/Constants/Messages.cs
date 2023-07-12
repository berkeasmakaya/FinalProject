﻿using Entities.Concrete;
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
	}
}