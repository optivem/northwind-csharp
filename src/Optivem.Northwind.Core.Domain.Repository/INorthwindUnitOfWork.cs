﻿using Optivem.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Domain.Repository
{
    public interface INorthwindUnitOfWork : IUnitOfWork
    {
        ISupplierRepository SupplierRepository { get; }
    }
}