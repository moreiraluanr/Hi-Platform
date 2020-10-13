using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class RemoveMarketResearchUseCase : IUseCase<RemoveMarketResearchRequest>
    {
        private readonly IMapper _mapper;
        private readonly IMarketResearchRepository _repository;

        public RemoveMarketResearchUseCase(IMapper mapper, IMarketResearchRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(RemoveMarketResearchRequest request)
        {
            _repository.Remove(request.Id);
        }
    }
}
