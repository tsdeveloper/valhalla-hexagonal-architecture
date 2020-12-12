﻿using Valhalla.Modules.Application.Abstractions.Commands;
using Valhalla.Modules.Domain.Entities;

namespace Valhalla.Tests.Fakes
{
    public class FakeOrderWriteRepository : IOrderWriteRepository
    {
        public string PlaceOrder(Customer customer, Order order)
        {
            return "0123456789";
        }
    }
}
