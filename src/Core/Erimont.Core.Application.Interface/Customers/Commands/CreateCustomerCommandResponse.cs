﻿using System;

namespace Erimont.Core.Application.Customers.Commands
{
    public class CreateCustomerCommandResponse
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}