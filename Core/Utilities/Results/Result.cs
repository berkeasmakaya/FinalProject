﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
	public class Result : IResult
	{
		// getter is readonly and readonly can be set in constructor.
		public Result(bool success, string message):this(success)
		{
			Message = message;
		}
        public Result(bool success)
        {
            Success = success;
        }


        public bool Success { get; }

		public string Message { get; }
	}
}
