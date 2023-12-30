using Microsoft.EntityFrameworkCore;

namespace DB_Layer1_Draftflex.Data.Features.Tenants;

public class CurrentTenantService : ICurrentTenantService
{
    // Make it accessible for this class 
    private readonly TenantDataContext _context; 
    public string? TenantId { get; set; }

    public CurrentTenantService(TenantDataContext context)
    {
        _context = context;
    }
    public async Task<bool> SetTenant(string tenant)
    {

        var tenantInfo = await _context.Tenants.Where(x => x.Id == tenant).FirstOrDefaultAsync(); // check if tenant exists
        if (tenantInfo != null)
        {
            TenantId = tenant;
            return true;
        }
        else
        {
            throw new Exception("Tenant invalid"); 
        }

    }
}