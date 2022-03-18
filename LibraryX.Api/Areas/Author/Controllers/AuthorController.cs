using CreateRequest = LibraryX.Api.Areas.Author.UseCases.Create.Request;
using DeleteRequest = LibraryX.Api.Areas.Author.UseCases.Delete.Request;
using EditRequest = LibraryX.Api.Areas.Author.UseCases.Edit.Request;
using GetDetailsRequest = LibraryX.Api.Areas.Author.UseCases.GetDetails.Request;
using GetAllRequest = LibraryX.Api.Areas.Author.UseCases.GetAll.Request;

namespace LibraryX.Api.Areas.Author.Controllers;

[ApiController]
[Route("v1/authors")]
public class AuthorController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetAllRequest model) => await Handle(model);
    
    [HttpGet("get/{id}")]
    public async Task<IActionResult> Get([FromRoute] GetDetailsRequest model) => await Handle(model);
    
    [HttpPost]
    public async Task<IActionResult> Post([FromQuery] CreateRequest model) => await Handle(model);
    
    [HttpPut("put/{id}")]
    public async Task<IActionResult> Put([FromRoute] EditRequest model) => await Handle(model);
    
    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteRequest model) => await Handle(model);
}