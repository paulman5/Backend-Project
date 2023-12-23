using Microsoft.AspNetCore.Http;

namespace DB_Layer1_Draftflex.Data.Features.Tenants;

public class TenantResolver
{
    // Code used to initiate middleware in application
    private readonly RequestDelegate _next;
    public TenantResolver(RequestDelegate next)
    {
        _next = next;
    }
    // Get Tenant Id from incoming requests 
    public async Task InvokeAsync(HttpContext context, ICurrentTenantService currentTenantService)
    {
        context.Request.Headers.TryGetValue("tenant", out var tenantFromHeader); // Tenant Id from incoming request header
        if (string.IsNullOrEmpty(tenantFromHeader) == false)
        {
            await currentTenantService.SetTenant(tenantFromHeader);
        }
        await _next(context);
    }
}