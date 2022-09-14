using Microsoft.EntityFrameworkCore;
using compiled.vs.standard.queries.Models;

namespace compiled.vs.standard.queries.Context;

/// <summary>
/// <see cref="MainDbContext"> DbContext class
/// </summary>
public class MainDbContext : DbContext
{
    #region Ctor

    public MainDbContext(DbContextOptions<MainDbContext> options)
                : base(options)
    {

    }

    #endregion

    #region DbSet's

    /// <summary>
    /// <see cref="User"> as db table
    /// </summary>
    /// <value></value>
    public DbSet<User> Users { get; set; }

    /// <summary>
    /// <see cref="Phone"> as db table
    /// </summary>
    /// <value></value>
    public DbSet<Phone> Phones { get; set; }

    /// <summary>
    /// <see cref="Location"> as db table
    /// </summary>
    /// <value></value>
    public DbSet<Location> Locations { get; set; }

    /// <summary>
    /// <see cref="Story"> as db table
    /// </summary>
    /// <value></value>
    public DbSet<Story> Stories { get; set; }

    #endregion
}