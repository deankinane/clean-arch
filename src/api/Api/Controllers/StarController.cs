using CleanArch.Application.Features.Stars.Queries.GetStarDetails;
using CleanArch.Application.Features.Stars.Queries.GetStarsList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers;

public class StarController : BaseController
{
    public StarController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet(Name = "GetAllStars")]
    public async Task<ActionResult<List<StarListVm>>> GetAllStars()
    {
        return Ok(await mediator.Send(new GetStarsListQuery()));
    }
    
    [HttpGet("{id}", Name = "GetStarDetails")]
    public async Task<ActionResult<StarDetailVm>> GetStarDetails(Guid id)
    {
        return Ok(await mediator.Send(new GetStarDetailsQuery() { Id = id }));
    }
}
