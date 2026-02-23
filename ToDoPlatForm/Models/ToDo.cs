using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ToDoPlatForm.Models;

[Table("todos")]

public class ToDo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [Required]

    public string UserId { get; set; }
    [ForeignKey (nameof(UserId))]

    public AppUser User { get; set; }
    [StringLength(100)]
    [Display(Name = "Titulo")]
    public string Title { get; set; }

    public string Description { get; set; }

    public bool Done { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.Now;    
}
