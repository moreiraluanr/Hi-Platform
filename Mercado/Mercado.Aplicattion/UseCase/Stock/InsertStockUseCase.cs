using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Entities;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class InsertStockUseCase : IUseCase<InsertStockRequest>
    {
        private readonly IMapper _mapper;
        private readonly IStockRepository _repository;

        public InsertStockUseCase(IMapper mapper, IStockRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(InsertStockRequest request)
        {
            var input = _mapper.Map<Stock>(request);
            _repository.Insert(input);
        }
    }
}
