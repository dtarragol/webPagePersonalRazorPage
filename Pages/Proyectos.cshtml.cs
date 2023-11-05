using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PPag.Pages;

public class ProyectosModel : PageModel
{
    private readonly ILogger<ProyectosModel> _logger;

    public ProyectosModel(ILogger<ProyectosModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

