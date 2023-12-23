namespace DB_Layer1_Draftflex.Data.Features.Tenants;

public interface ICurrentTenantService
{
    string? TenantId { get; set; }
    public Task<bool> SetTenant(string tenant);
}