using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Entities;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class AlterMarketResearchUseCase : IUseCase<AlterMarketResearchRequest>
    {
        private readonly IMapper _mapper;
        private readonly IMarketResearchRepository _repository;

        public AlterMarketResearchUseCase(IMapper mapper, IMarketResearchRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(AlterMarketResearchRequest request)
        {
            var input = _mapper.Map<MarketResearch>(request);
            _repository.Alter(input);
        }
    }
}
