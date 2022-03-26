using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travx.Models;

namespace Travx.API.Models
{
    public interface IJobCategoryRepository
    {
        public Task<IEnumerable<JobCalegory>> GetJobCategories();
        public Task<JobCalegory> GetJobCategoryById(int id);
        
        public Task<JobCalegory> AddJobCategory(JobCalegory jobCategory);
        public Task<JobCalegory> UpdateJobCategory(JobCalegory jobCategory);
        public Task<JobCalegory> DeleteJobCategory(int id);
    }
}