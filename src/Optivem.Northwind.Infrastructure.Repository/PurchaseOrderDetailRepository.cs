﻿using Optivem.Commons.Persistence.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
	public class PurchaseOrderDetailRepository : EntityFrameworkRepository<NorthwindContext, PurchaseOrderDetail, int>, IPurchaseOrderDetailRepository
	{
		public PurchaseOrderDetailRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
