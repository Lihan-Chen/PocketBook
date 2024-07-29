﻿using System;
using Microsoft.Extensions.Logging;
using PocketBook.Core.IConfiguration;
using PocketBook.Core.IRepositories;
using PocketBook.Core.Repositories;

namespace PocketBook.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger _logger;

        // Add all IRepositories here
        public IUserRepository Users { get; private set; }
        public IMeterRepository Meters { get; private set; }

        public UnitOfWork(
            ApplicationDbContext context,
            ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("Logs");

            Users = new UserRepository(_context, _logger);
        }

        public async Task CompleteAsync()
        { 
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        //public async Task Dispose()
        //{
        //    await _context.DisposeAsync(); 
        //}





    }
}
