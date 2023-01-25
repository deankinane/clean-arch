using MediatR;

namespace CleanArch.Application.Features.Stars.Queries.GetStarsList
{
    public class GetStarsListQuery : IRequest<List<StarListVm>>
    {
    }
}
