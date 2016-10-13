﻿using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;


namespace ScaleModeling.Domain.Concrete
{
    public class VideoCommentRepository : IRepository<VideoComment, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<VideoComment> Get
        {
            get
            {
                return context.VideoComments;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}