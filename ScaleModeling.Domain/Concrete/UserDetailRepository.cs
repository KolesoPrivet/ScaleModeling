﻿using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class UserDetailRepository : IRepository<UserDetail, string>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<UserDetail> Get
        {
            get
            {
                return context.UserDetails;
            }
        }
    }
}