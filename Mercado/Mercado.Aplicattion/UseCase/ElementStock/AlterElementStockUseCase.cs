using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Entities;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class AlterElementStockUseCase : IUseCase<AlterElementStockRequest>
    {
        private readonly IMapper _mapper;
        private readonly IElementStockRepository _repository;

        public AlterElementStockUseCase(IMapper mapper, IElementStockRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(AlterElementStockRequest request)
        {
            var input = _mapper.Map<ElementStock>(request);
            _repository.Alter(input);
        }
    }
}
