using System;
using System.Collections.Generic;
using api.Models;
using api.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace api.Services
{
    public class AccountService : IAccountService
    {
        private ILogger<AccountService> _logger;

        public AccountService(ILogger<AccountService> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Account> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
