using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Travx.API.Models;
using Travx.Models;

namespace Travx.API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class JobCategoryController : ControllerBase
{
    private readonly IJobCategoryRepository jobCategoryRepository;

    public JobCategoryController(IJobCategoryRepository jobCategoryRepository)
    {
        this.jobCategoryRepository = jobCategoryRepository;
    }
     [HttpGet]
    public async Task<ActionResult> GetJobCategories()
    {
        try
        {
            return Ok(await jobCategoryRepository.GetJobCategories());
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<JobCalegory>> GetJobCategoryById(int id)
    {
        try
        {
            var result = await jobCategoryRepository.GetJobCategoryById(id);
            if (result is null) return NotFound();
            return result;
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }

    [HttpPost]
    public async Task<ActionResult<JobCalegory>> AddJobCategory(JobCalegory jobCalegory)
    {
        try
        {
            if(jobCalegory is null ) return BadRequest();

            var addedJobCategory = await jobCategoryRepository.AddJobCategory(jobCalegory);

            return CreatedAtAction(nameof(GetJobCategoryById),
                new {id = addedJobCategory.JobCalegoryId},
                addedJobCategory);
        }
        catch (System.Exception)
        {
            return StatusCode500("Error ADDING DATA To the database");
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<JobCalegory>> UpdateJobCategory(int id, JobCalegory jobCategory)
    {
        try
        {
            if (id == jobCategory.JobCalegoryId) return BadRequest("Job ID missmatch");

            var JobCategoryToUpdate = await jobCategoryRepository.GetJobCategoryById(id);

            if (JobCategoryToUpdate is null)
                return NotFound($"Article with id= {id} is not founf");

            return await jobCategoryRepository.UpdateJobCategory(jobCategory);
        }
        catch(Exception)
        {
            return StatusCode500("Error UPDATING DATA from the database");
        }
    }
    private ObjectResult StatusCode500(string statusCode = "Error RETREEVING DATA from the database") =>
                        StatusCode(StatusCodes.Status500InternalServerError, statusCode);
}
