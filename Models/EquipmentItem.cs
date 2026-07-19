using System.ComponentModel.DataAnnotations;

namespace PPECheckoutSystem.Models;

public class EquipmentItem
{
    public int EquipmentItemId { get; set; }

    [Required]
    public int EquipmentCategoryId { get; set; }

    public EquipmentCategory? EquipmentCategory { get; set; }

    [Required]
    [StringLength(50)]
    public string ItemCode { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string ItemName { get; set; } = string.Empty;

    public EquipmentStatus Status { get; set; } = EquipmentStatus.Available;

    public EquipmentCondition Condition { get; set; } = EquipmentCondition.Good;

    [StringLength(100)]
    public string? Location { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime DateAdded { get; set; } = DateTime.Now;

    public ICollection<CheckoutRecord> CheckoutRecords { get; set; } = new List<CheckoutRecord>();
}