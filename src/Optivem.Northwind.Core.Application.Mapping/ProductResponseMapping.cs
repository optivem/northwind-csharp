﻿using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Core.Application.Mapping
{
	public class ProductResponseMapping : BaseMapping<Product, ProductResponse>
	{
		public ProductResponseMapping()
		{
			// dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
		}
	}
}