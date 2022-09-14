using System.ComponentModel.DataAnnotations;

namespace compiled.vs.standard.queries.Models;

/// <summary>
/// <see cref="Phone"> entity model
/// </summary>
public sealed class Phone : Base
{
    [Required, MaxLength(15)]
    public string Number { get; set; }

    [Required]
    public User User { get; set; }
}