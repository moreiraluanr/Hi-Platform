using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;
using System.Collections.Generic;

namespace Mercado.Aplicattion.UseCase
{
    public class ListElementStockUseCase : IUseCase<ListElementStockRequest, IEnumerable<ListElementStockResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IElementStockRepository _repository;

        public ListElementStockUseCase(IMapper mapper, IElementStockRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<ListElementStockResponse> Execute(ListElementStockRequest request)
        {
            var list = _repository.List();
            return _mapper.Map<IEnumerable<ListElementStockResponse>>(list);
        }
    }
}
