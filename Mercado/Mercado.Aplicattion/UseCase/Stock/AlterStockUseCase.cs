using AutoMapper;
using Mercado.Aplicattion.Model.Stock.Request;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Entities;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class AlterStockUseCase : IUseCase<AlterStockRequest>
    {
        private readonly IMapper _mapper;
        private readonly IStockRepository _repository;

        public AlterStockUseCase(IMapper mapper, IStockRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(AlterStockRequest request)
        {
            var input = _mapper.Map<Stock>(request);
            _repository.Alter(input);
        }
    }
}
