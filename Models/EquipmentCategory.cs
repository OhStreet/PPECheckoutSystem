using System.ComponentModel.DataAnnotations;

namespace PPECheckoutSystem.Models;

public class EquipmentCategory
{
    public int EquipmentCategoryId { get; set; }

    [Required]
    [StringLength(75)]
    public string CategoryName { get; set; } = string.Empty;

    [StringLength(250)]
    public string? Description { get; set; }

    public int DefaultCheckoutDays { get; set; } = 7;

    public ICollection<EquipmentItem> EquipmentItems { get; set; } = new List<EquipmentItem>();
}