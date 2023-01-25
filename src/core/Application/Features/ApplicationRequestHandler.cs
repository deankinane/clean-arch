using AutoMapper;
using MediatR;

namespace CleanArch.Application.Features
{
    public abstract class ApplicationRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        protected readonly IMapper _mapper;

        public ApplicationRequestHandler(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
