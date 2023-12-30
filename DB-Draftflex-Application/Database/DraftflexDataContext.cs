using DB_Layer1_Draftflex.Data.Features.Tenants;
using Microsoft.EntityFrameworkCore;

namespace DB_Layer1_Draftflex.Data;

public class DraftflexDataContext : DbContext
{
    
    private readonly ICurrentTenantService _currentTenantService;
    public string CurrentTenantId { get; set; }

    public DraftflexDataContext(ICurrentTenantService currentTenantService, DbContextOptions<DraftflexDataContext> options):
        base(options)
    {
        _currentTenantService = currentTenantService;
        CurrentTenantId = _currentTenantService.TenantId;
    }
    // Add entity for every table that needs to be tenant isolated
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();
        modelBuilder.Entity<User>().HasQueryFilter(a => a.TenantId == CurrentTenantId);
    }
    
    // Entities of our database
    public DbSet<User> Users { get; set; }
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<License> Licenses { get; set; }
    public DbSet<Templates> Templates { get; set; }
    public DbSet<Unique_Document> UniqueDocuments { get; set; }
    
    // Checking if tenant id is added or modified and if so changes the tenantId to that of the current tenant
    public override int SaveChanges()
    {        
        foreach (var entry in ChangeTracker.Entries<ITenantEntity>().ToList()) 
        {
            switch (entry.State)
            {
                case EntityState.Added:
                case EntityState.Modified:
                    entry.Entity.TenantId = CurrentTenantId; 
                    break;
            }
        }
        var result = base.SaveChanges();
        return result;
    }
}