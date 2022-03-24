using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travx.Models;

namespace Travx.API.Models
{
    public interface IJobRepository
    {
        public Task<IEnumerable<Job>> GetJobs();
        public Task<Job> GetJobById(int id);
        
        public Task<Job> AddJob(Job job);
        public Task<Job> UpdateJob(Job job);
        public Task<Job> DeleteJob(int id);
    }
}