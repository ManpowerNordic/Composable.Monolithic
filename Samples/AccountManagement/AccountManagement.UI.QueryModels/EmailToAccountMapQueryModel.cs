﻿using System;
using AccountManagement.Domain.Shared;

namespace AccountManagement.UI.QueryModels
{
    public class EmailToAccountMapQueryModel
    {
        public EmailToAccountMapQueryModel(Email email, Guid accountId)
        {
            Email = email;
            AccountId = accountId;
        }

        public Email Email { get; private set; }
        public Guid AccountId { get; private set; }
    }
}
