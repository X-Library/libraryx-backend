using CreateRequest = LibraryX.Api.Areas.Book.UseCases.Create.Request;
using DeleteRequest = LibraryX.Api.Areas.Book.UseCases.Delete.Request;
using EditRequest = LibraryX.Api.Areas.Book.UseCases.Edit.Request;
using GetDetailsRequest = LibraryX.Api.Areas.Book.UseCases.GetDetails.Request;
using GetAllRequest = LibraryX.Api.Areas.Book.UseCases.GetAll.Request;

namespace LibraryX.Api.Areas.Book.Controllers;

[ApiController]
[Route("v1/books")]
public class BookController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetAllRequest model) => await Handle(model);
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] GetDetailsRequest model) => await Handle(model);
    
    [HttpPost]
    public async Task<IActionResult> Post([FromQuery] CreateRequest model) => await Handle(model);
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] EditRequest model) => await Handle(model);
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteRequest model) => await Handle(model);
} 