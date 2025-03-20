using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Product Name is required.")]
    [Column(TypeName = "nvarchar(50)")]
    [RegularExpression(@"^[a-zA-Z0-9\s\p{P}]{1,50}$", ErrorMessage = "Only letters, numbers, and punctuation are allowed.")]
    [Display(Name = "Product Name")]
    [DataType(DataType.Text)]
    public string Name { get; set; } = string.Empty; // Ensure it's never null

    [Required(ErrorMessage = "Price is required.")]
    [Precision(18, 2)]
    [Column(TypeName = "decimal(18,2)")]
    [Display(Name = "Price")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Quantity is required.")]
    [Display(Name = "Quantity")]
    [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only numeric values are allowed.")]
    public int Quantity { get; set; }
}
