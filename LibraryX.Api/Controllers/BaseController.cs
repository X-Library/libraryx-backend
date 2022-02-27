using LibraryX.Api.SharedContext.UseCases;

namespace LibraryX.Api.Controllers;

public abstract class BaseController : ControllerBase
{
    public async Task<IActionResult> Handle(IRequest request)
    {
        await Task.Delay(1);
        return Ok();
    }
}