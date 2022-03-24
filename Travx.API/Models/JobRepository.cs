using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Travx.Models;

namespace Travx.API.Models
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext context;

        public JobRepository(AppDbContext appDbContext)
        {
            context= appDbContext;
        }

        public async Task<Job> AddJob(Job job)
        {
            var result = await context.Jobs.AddAsync(job);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Job> DeleteJob(int id)
        {
            var result = await context.Jobs.FirstOrDefaultAsync(j => j.JobId == id);
            if ( result is not null)
            {
                context.Jobs.Remove(result);
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Job> GetJobById(int id)
        {
            return await context.Jobs
            .AsNoTracking()
            .FirstOrDefaultAsync(j => j.JobId == id);
        }

        public async Task<IEnumerable<Job>> GetJobs()
        {
            return await context.Jobs
                .OrderByDescending(j=> j.DatePosted)
                .ToListAsync();
        }

        public async Task<Job> UpdateJob(Job job)
        {
            var result = await context.Jobs.FirstOrDefaultAsync(j => j.JobId == job.JobId);
            if (result is not null) {
                result.JobTitle = job.JobTitle;
                result.Description = job.Description;
                result.BusnessName = job.BusnessName;
                result.LastModifie = job.LastModifie;
                result.IsOpenForApplications = job.IsOpenForApplications;
                result.WorkLoation = job.WorkLoation;
                result.SalaryType = job.SalaryType;
                result.MinSalary = job.MinSalary;
                result.MaxSalary = job.MaxSalary;
                result.JobType = job.JobType;
                
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}