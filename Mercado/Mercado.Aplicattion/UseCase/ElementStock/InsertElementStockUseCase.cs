using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Entities;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class InsertElementStockUseCase : IUseCase<InsertElementStockRequest>
    {
        private readonly IMapper _mapper;
        private readonly IElementStockRepository _repository;

        public InsertElementStockUseCase(IMapper mapper, IElementStockRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(InsertElementStockRequest request)
        {
            var input = _mapper.Map<ElementStock>(request);
            _repository.Insert(input);
        }
    }
}
