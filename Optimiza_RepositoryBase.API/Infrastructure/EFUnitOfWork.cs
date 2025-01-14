﻿using Optimiza_RepositoryBase.API.Abstractions;

namespace Optimiza_RepositoryBase.API.Infrastructure;

public class EFUnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public EFUnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Dispose()
    {
        _context.SaveChanges();
    }

    public void Commit()
    {
        _context.Dispose();
    }
}