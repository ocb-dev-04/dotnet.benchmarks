using System.ComponentModel.DataAnnotations;

namespace compiled.vs.standard.queries.Models;

/// <summary>
/// <see cref="Base"> base entity model
/// </summary>
public class Base
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public DateTimeOffset? CreatedDate { get; set; } 
    [Required]
    public DateTimeOffset ModifiedDate { get; set; }
    [Required]
    public Guid CreatorId { get; set; }

    /// <summary>
    /// <see cref="Base"> ctor
    /// </summary>
    public Base()
    {
        if(CreatedDate is null)
            CreatedDate = DateTimeOffset.UtcNow;

        ModifiedDate = DateTimeOffset.UtcNow;
    }
}