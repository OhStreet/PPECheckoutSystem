using System.ComponentModel.DataAnnotations;

namespace PPECheckoutSystem.Models;

public class Employee
{
    public int EmployeeId { get; set; }

    [Required]
    [StringLength(50)]
    public string EmployeeNumber { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string BadgeNumber { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Role { get; set; } = "Employee";

    [StringLength(50)]
    public string? Department { get; set; }

    public bool IsActive { get; set; } = true;

    public ICollection<CheckoutRecord> CheckoutRecords { get; set; } = new List<CheckoutRecord>();

    public string FullName => $"{FirstName} {LastName}";
}