using System.ComponentModel.DataAnnotations;

namespace compiled.vs.standard.queries.Models;

/// <summary>
/// <see cref="Location"> entity model
/// </summary>
public sealed class Location : Base
{
    [Required, MaxLength(15)]
    public string Lat { get; set; }

    [Required, MaxLength(15)]
    public string Long { get; set; }

    [Required]
    public User User { get; set; }
}