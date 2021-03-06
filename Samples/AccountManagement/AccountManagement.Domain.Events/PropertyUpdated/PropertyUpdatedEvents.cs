﻿using AccountManagement.Domain.Shared;

namespace AccountManagement.Domain.Events.PropertyUpdated
{
    public interface IAccountPasswordPropertyUpdatedEvent : IAccountEvent
    {
        Password Password { get; /* Never add a setter! */ }
    }

    public interface IAccountEmailPropertyUpdatedEvent : IAccountEvent
    {
        Email Email { get; /* Never add a setter! */ }
    }
}
