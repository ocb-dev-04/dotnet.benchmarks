using System.ComponentModel.DataAnnotations;

namespace compiled.vs.standard.queries.Models;

/// <summary>
/// <see cref="Story"> entity model
/// </summary>
public sealed class Story : Base
{
    [Required, MaxLength(15)]
    public string ImageUrl { get; set; }

    [Required]
    public User User { get; set; }
}