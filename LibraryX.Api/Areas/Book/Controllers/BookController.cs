using LibraryX.Api.Controllers;
using CreateRequest = LibraryX.Api.Areas.Book.UseCases.Create.Request;
using DeleteRequest = LibraryX.Api.Areas.Book.UseCases.Delete.Request;
using EditRequest = LibraryX.Api.Areas.Book.UseCases.Edit.Request;
using GetDetailsRequest = LibraryX.Api.Areas.Book.UseCases.GetDetails.Request;
using GetAllRequest = LibraryX.Api.Areas.Book.UseCases.GetAll.Request;

namespace LibraryX.Api.Areas.Book.Controllers;

public class BookController : BaseController
{
    [HttpGet("v1/books")]
    public async Task<IActionResult> Get([FromQuery] GetAllRequest model) => await Handle(model);
    
    [HttpGet("v1/books/{id}")]
    public async Task<IActionResult> Get([FromRoute] GetDetailsRequest model) => await Handle(model);
    
    [HttpPost("v1/books")]
    public async Task<IActionResult> Post([FromQuery] CreateRequest model) => await Handle(model);
    
    [HttpPut("v1/books/{id}")]
    public async Task<IActionResult> Put([FromRoute] EditRequest model) => await Handle(model);
    
    [HttpDelete("v1/books/{id}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteRequest model) => await Handle(model);
} 