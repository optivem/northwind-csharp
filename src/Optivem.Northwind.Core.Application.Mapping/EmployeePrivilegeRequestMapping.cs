﻿using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Core.Application.Mapping
{
	public class EmployeePrivilegeRequestMapping : BaseMapping<EmployeePrivilege, EmployeePrivilegeRequest>
	{
		public EmployeePrivilegeRequestMapping()
		{
			// // dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
		}
	}
}
