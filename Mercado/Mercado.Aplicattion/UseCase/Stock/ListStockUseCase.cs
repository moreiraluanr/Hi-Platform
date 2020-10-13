using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;
using System.Collections.Generic;

namespace Mercado.Aplicattion.UseCase
{
    public class ListStockUseCase : IUseCase<ListStockRequest, IEnumerable<ListStockResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IStockRepository _repository;

        public ListStockUseCase(IMapper mapper, IStockRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<ListStockResponse> Execute(ListStockRequest request)
        {
            var list = _repository.List();
            return _mapper.Map<IEnumerable<ListStockResponse>>(list);
        }
    }
}
