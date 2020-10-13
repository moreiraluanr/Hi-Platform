using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Entities;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class InsertMarketResearchUseCase : IUseCase<InsertMarketResearchRequest>
    {
        private readonly IMapper _mapper;
        private readonly IMarketResearchRepository _repository;

        public InsertMarketResearchUseCase(IMapper mapper, IMarketResearchRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(InsertMarketResearchRequest request)
        {
            var input = _mapper.Map<MarketResearch>(request);
            _repository.Insert(input);
        }
    }
}
