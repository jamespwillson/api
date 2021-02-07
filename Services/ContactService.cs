using System;
using System.Collections.Generic;
using api.Models;
using api.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace api.Services
{
    public class ContactService : IContactService
    {
        private ILogger<ContactService> _logger;

        public ContactService(ILogger<ContactService> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Contact> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
