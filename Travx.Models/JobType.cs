

using System.ComponentModel.DataAnnotations;

namespace Travx.Models;

public enum JobType
{
    [Display(Name = "Full Time")]
    FullTime,
    [Display(Name = "Part Time")]
    PartTime,
    Internship,
    Volunterr,
    Contract
}
