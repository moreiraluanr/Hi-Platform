using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;
using System.Collections.Generic;

namespace Mercado.Aplicattion.UseCase
{
    public class ListCleaningProductUseCase : IUseCase<GetCleaningProductRequest, IEnumerable<GetCleaningProductResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ICleaningProductRepository _repository;

        public ListCleaningProductUseCase(IMapper mapper, ICleaningProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<GetCleaningProductResponse> Execute(GetCleaningProductRequest request)
        {
            return _mapper.Map<IEnumerable<GetCleaningProductResponse>>(_repository.List());
        }
    }
}
