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
public class JobsController : ControllerBase
{
    private readonly IJobRepository jobRepository;
    public JobsController(IJobRepository jobRepository)
    {
        this.jobRepository = jobRepository;
    }
    [HttpGet]
    public async Task<ActionResult> GetJobs()
    {
        try
        {
            return Ok(await jobRepository.GetJobs());
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Job>> GetJobbyId(int id)
    {
        try
        {
            var result = await jobRepository.GetJobById(id);
            if (result is null) return NotFound();
            return result;
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }

    [HttpPost]
    public async Task<ActionResult<Job>> AddJob(Job job)
    {
        try
        {
            if(job is null ) return BadRequest();
            var addedJob = await jobRepository.AddJob(job);
            return CreatedAtAction(nameof(GetJobbyId),
                new {id = addedJob.JobId},
                addedJob);
        }
        catch (System.Exception)
        {
            return StatusCode500("Error ADDING DATA To the database");
        }
    }
    [HttpPut("{id:int}")]
    public async Task<ActionResult<Job>> UpdateJob(int id, Job job)
    {
        try
        {
            if (id == job.JobId) return BadRequest("Job ID missmatch");

            var JobToUpdate = await jobRepository.GetJobById(id);

            if (JobToUpdate == null)
                return NotFound($"Article with id= {id} is not founf");

            return await jobRepository.UpdateJob(job);
        }
        catch(Exception)
        {
            return StatusCode500("Error UPDATING DATA from the database");
        }
    }
     private ObjectResult StatusCode500(string statusCode = "Error RETREEVING DATA from the database") =>
                        StatusCode(StatusCodes.Status500InternalServerError, statusCode);
}
