﻿using System;
using Valhalla.Modules.Application.Inputs.Order;

namespace Valhalla.Modules.Application.Commands.PlaceOrder
{
    public interface IPlaceOrderUseCase
    {
        string Execute(PlaceOrderInput orderInput);
    }
}
