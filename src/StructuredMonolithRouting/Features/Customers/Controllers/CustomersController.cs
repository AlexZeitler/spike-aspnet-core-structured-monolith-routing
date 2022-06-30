using Microsoft.AspNetCore.Mvc;

namespace StructuredMonolithRouting.Features.Customers.Controllers;

[Route("customers")]
public class CustomersController : Controller
{
  private readonly ILogger _logger;

  public CustomersController(ILogger logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    _logger.LogInformation("Test");
    return View();
  }

  [HttpPost]
  [Route("")]
  public async Task<IActionResult> Register()
  {
    _logger.LogInformation("Registration has been called");
    return Redirect(Url.Action("Index", "Customers") ?? throw new InvalidOperationException());
  }
}
