

using System.ComponentModel.DataAnnotations;

namespace Travx.Models;

public enum SalaryType
{
    [Display(Name = "Per Hour")]
    PerHour,
    [Display(Name = "Per Day")]
    PerDay,
    [Display(Name = "Per Week")]
    PerWeek,
    [Display(Name = "Per Tow Weeks")]
    PerTowWeeks,
    [Display(Name = "Per Month")]
    PerMonth,
    [Display(Name = "Per Year")]
    PerYear,
    [Display(Name = "One Time")]
    OneTime
}
