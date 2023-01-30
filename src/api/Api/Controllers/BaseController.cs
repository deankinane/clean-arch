using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseController : ControllerBase
{
    protected readonly IMediator mediator;

    public BaseController(IMediator mediator)
    {
        this.mediator = mediator;
    } 
}
