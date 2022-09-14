using System.ComponentModel.DataAnnotations;

namespace compiled.vs.standard.queries.Models;

/// <summary>
/// <see cref="User"> entity model
/// </summary>
public sealed class User : Base
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public int Age { get; set; }

    public ICollection<Phone> Phones { get; set; } = new List<Phone>();
    public ICollection<Location> Phones { get; set; } = new List<Location>();
    public ICollection<Story> Phones { get; set; } = new List<Story>();
}