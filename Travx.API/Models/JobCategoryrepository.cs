using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Travx.Models;

namespace Travx.API.Models
{
    public class JobCategoryrepository : IJobCategoryRepository
    {
        private readonly AppDbContext context;

        public JobCategoryrepository(AppDbContext appDbContext) => context = appDbContext;

        public async Task<JobCalegory> AddJobCategory(JobCalegory jobCategory)
        {
            var result = await context.JobCalegories.AddAsync(jobCategory);
            await context.SaveChangesAsync();
            return result.Entity;;
        }

        public async Task<JobCalegory> DeleteJobCategory(int id)
        {
            var result = await context.JobCalegories.FirstOrDefaultAsync(c=> c.JobCalegoryId == id);
            if ( result is not null)
            {
                context.JobCalegories.Remove(result);
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<JobCalegory>> GetJobCategories() 
            => await context.JobCalegories
                .OrderBy(c => c.CategoryName)
                .ToListAsync();

        public async Task<JobCalegory> GetJobCategoryById(int id) 
            => await context.JobCalegories
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.JobCalegoryId == id);

        public async Task<JobCalegory> UpdateJobCategory(JobCalegory jobCategory)
        {
            var result = await context.JobCalegories.FirstOrDefaultAsync(c=> c.JobCalegoryId == jobCategory.JobCalegoryId);
            if (result is not null) {
                result.CategoryName = jobCategory.CategoryName;
                
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}