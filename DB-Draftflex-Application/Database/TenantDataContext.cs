using Microsoft.EntityFrameworkCore;

namespace DB_Layer1_Draftflex.Data;

public class TenantDataContext : DbContext
{
    // This context is for looking up the tenant when a request comes in.
    public TenantDataContext(DbContextOptions<TenantDataContext> options)
        : base(options)
    {
    }

    public DbSet<Tenant> Tenants { get; set; }

}