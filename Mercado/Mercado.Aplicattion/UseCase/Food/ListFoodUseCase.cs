using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;
using System.Collections.Generic;

namespace Mercado.Aplicattion.UseCase
{
    public class ListFoodUseCase : IUseCase<ListFoodRequest, IEnumerable<ListFoodResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IFoodRepository _repository;

        public ListFoodUseCase(IMapper mapper, IFoodRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<ListFoodResponse> Execute(ListFoodRequest request)
        {
            var list = _repository.List();
            return _mapper.Map<IEnumerable<ListFoodResponse>>(list);
        }
    }
}
