using System.ComponentModel.DataAnnotations;

namespace PPECheckoutSystem.Models;

public class CheckoutRecord
{
    public int CheckoutRecordId { get; set; }

    [Required]
    public int EmployeeId { get; set; }

    public Employee? Employee { get; set; }

    [Required]
    public int EquipmentItemId { get; set; }

    public EquipmentItem? EquipmentItem { get; set; }

    public DateTime CheckedOutAt { get; set; } = DateTime.Now;

    public DateTime? DueDate { get; set; }

    public DateTime? CheckedInAt { get; set; }

    [StringLength(250)]
    public string? CheckoutNotes { get; set; }

    public EquipmentCondition? ReturnCondition { get; set; }

    [StringLength(250)]
    public string? ReturnNotes { get; set; }

    public bool IsActiveCheckout => CheckedInAt == null;
}