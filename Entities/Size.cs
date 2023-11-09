using System.ComponentModel.DataAnnotations;

namespace LR4.Entities;

public class Size : BaseEntity
{
    [Required(ErrorMessage = "Поле обов'язкове для введення")]
    public string SizeSybmol { get; set; }

    [Required(ErrorMessage = "Поле обов'язкове для введення")]
    public double Price { get; set; }

    public Guid ProductId { get; set; }
}