﻿using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class PurchaseOrderRepository : EntityFrameworkRepository<NorthwindContext, PurchaseOrder, int>, IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}