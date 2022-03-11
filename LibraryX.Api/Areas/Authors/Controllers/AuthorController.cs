using CreateRequest = LibraryX.Api.Areas.Authors.UseCases.Create.Request;
using DeleteRequest = LibraryX.Api.Areas.Authors.UseCases.Delete.Request;
using EditRequest = LibraryX.Api.Areas.Authors.UseCases.Edit.Request;
using GetDetailsRequest = LibraryX.Api.Areas.Authors.UseCases.GetDetails.Request;
using GetAllRequest = LibraryX.Api.Areas.Authors.UseCases.GetAll.Request;

namespace LibraryX.Api.Areas.Authors.Controllers;

public class AuthorController : BaseController
{
    [HttpGet("v1/authors/")]
    public async Task<IActionResult> Get([FromQuery] GetAllRequest model)
    {
        return await Handle(model);
    }

    [HttpGet("v1/authors/{id}")]
    public async Task<IActionResult> Get([FromRoute] GetDetailsRequest model)
    {
        return await Handle(model);
    }

    [HttpPost("v1/authors/")]
    public async Task<IActionResult> Post([FromQuery] CreateRequest model)
    {
        return await Handle(model);
    }

    [HttpPut("v1/authors/{id}")]
    public async Task<IActionResult> Put([FromRoute] EditRequest model)
    {
        return await Handle(model);
    }

    [HttpDelete("v1/authors/{id}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteRequest model)
    {
        return await Handle(model);
    }
}