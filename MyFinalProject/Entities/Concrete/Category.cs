﻿using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Category:IEntity
	{
		public Category()
		{
		}
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }

	}
}

