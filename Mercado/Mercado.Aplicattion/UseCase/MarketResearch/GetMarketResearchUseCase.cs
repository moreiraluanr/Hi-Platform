using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class GetMarketResearchUseCase : IUseCase<GetMarketResearchRequest, GetMarketResearchResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMarketResearchRepository _repository;

        public GetMarketResearchUseCase(IMapper mapper, IMarketResearchRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public GetMarketResearchResponse Execute(GetMarketResearchRequest request)
        {
            var output = _repository.Get(request.Id);
            return _mapper.Map<GetMarketResearchResponse>(output);
        }
    }
}
