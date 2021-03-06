﻿using System;
using TimeTracker.Data.Models;
using TimeTracker.Data.Repositories;

namespace TimeTracker.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository Projects { get; }
        IBranchRepository Branches { get; }
        ITeamRepository Teams { get; }
        IHolidayRepository Holidays { get; }
        ITicketTypeRepository TicketTypes { get; }

        /// <summary>
        /// Get repository according to the type
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseModel;

        /// <summary>
        /// Get repository according to the type
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IRepositoryMany<TEntity> GetRepositoryMany<TEntity>() where TEntity : class;

        /// <summary>
        /// Saves all pending changes into the database
        /// </summary>
        void Save();
    }
}
