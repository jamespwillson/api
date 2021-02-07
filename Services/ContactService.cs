using System;
using Microsoft.Extensions.Logging;

namespace api.Services
{
    public class ContactService
    {
        private ILogger<ContactService> _logger;

        public ContactService(ILogger<ContactService> logger)
        {
            _logger = logger;
        }
    }
}
