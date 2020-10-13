using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;
using System.Collections.Generic;

namespace Mercado.Aplicattion.UseCase
{
    public class ListMarketResearchUseCase : IUseCase<ListMarketResearchRequest, IEnumerable<ListMarketResearchResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IMarketResearchRepository _repository;

        public ListMarketResearchUseCase(IMapper mapper, IMarketResearchRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<ListMarketResearchResponse> Execute(ListMarketResearchRequest request)
        {
            var list = _repository.List();
            return _mapper.Map<IEnumerable<ListMarketResearchResponse>>(list);

        }
    }
}
