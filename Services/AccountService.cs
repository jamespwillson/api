using System;
using Microsoft.Extensions.Logging;

namespace api.Services
{
    public class AccountService
    {
        private ILogger<AccountService> _logger;

        public AccountService(ILogger<AccountService> logger)
        {
            _logger = logger;
        }
    }
}
