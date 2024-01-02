using Microsoft.AspNetCore.Mvc;

namespace DB_Layer1_Draftflex.Data.Features.Tenants;

[ApiController]
[Route("api/tenants")]
public class TenantController : ControllerBase
{
    private readonly CurrentTenantService _currentTenantService;

    public TenantController(CurrentTenantService currentTenantService)
    {
        _currentTenantService = currentTenantService;
    }
}