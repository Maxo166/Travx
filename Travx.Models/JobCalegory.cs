using System.ComponentModel.DataAnnotations;

namespace Travx.Models;

public class JobCalegory
{
    public int JobCalegoryId { get; set; }
    [Display(Name ="Category Name")]
    public string CategoryName { get; set; }
}
