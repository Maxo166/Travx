using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travx.Models
{
    public class Job
    {
        public int JobId { get; set; }

        [Display(Name ="Job Title")]
         [Column(TypeName = "varchar(100)")]
        public string JobTitle { get; set; }

        [Display(Name = "Job Description")]
        [Column(TypeName = "varchar(1000)")]
        public string Description { get; set; }

        [Display(Name = "Busness Name")]
        [MaxLength(100, ErrorMessage = "you have reached the maximun char limit(500 char) ")]
        [Column(TypeName = "varchar(100)")]
        public string BusnessName { get; set; }

        [Display(Name = "Maximum Salary ")]
        public double MaxSalary { get; set; }
        [Display(Name = "Minimum Salary ")]
        public double MinSalary { get; set; }
        [Display(Name = "Work Loation ")]
        [Column(TypeName = "varchar(150)")]
        public string WorkLoation { get; set; }

        [Display(Name ="Posted Date")]
        public DateTime DatePosted { get; init; } = DateTime.Now;
        public DateTime LastModifie { get; set; } = DateTime.Now;

        [Display(Name = "Is Still Open For Application?")]
        public bool IsOpenForApplications { get; set; }
        [Display(Name ="Salary Type")]
        public SalaryType SalaryType { get; set; } = new SalaryType();
        [Display(Name ="Job Type")]
        public JobType JobType { get; set; } = new();
    }    
}