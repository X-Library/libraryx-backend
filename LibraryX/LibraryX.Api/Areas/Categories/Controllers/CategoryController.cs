using LibraryX.Api.Controllers;
using CreateRequest = LibraryX.Api.Areas.Categories.UseCases.Create.Request;
using DeleteRequest = LibraryX.Api.Areas.Categories.UseCases.Delete.Request;
using EditRequest = LibraryX.Api.Areas.Categories.UseCases.Edit.Request;
using GetDetailsRequest = LibraryX.Api.Areas.Categories.UseCases.GetDetails.Request;
using GetAllRequest = LibraryX.Api.Areas.Categories.UseCases.GetAll.Request;

namespace LibraryX.Api.Areas.Categories.Controllers;

public class CategoryController : BaseController
{
    [HttpGet("v1/categories")]
    public async Task<IActionResult> Get([FromQuery] GetAllRequest model) => await Handle(model);
    
    [HttpGet("v1/categories/{id}")]
    public async Task<IActionResult> Get([FromRoute] GetDetailsRequest model) => await Handle(model);
    
    [HttpPost("v1/categories")]
    public async Task<IActionResult> Post([FromQuery] CreateRequest model) => await Handle(model);
    
    [HttpPut("v1/categories/{id}")]
    public async Task<IActionResult> Put([FromRoute] EditRequest model) => await Handle(model);
    
    [HttpDelete("v1/categories/{id}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteRequest model) => await Handle(model);
}