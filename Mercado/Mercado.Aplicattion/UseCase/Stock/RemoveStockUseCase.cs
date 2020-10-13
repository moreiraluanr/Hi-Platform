using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class RemoveStockUseCase : IUseCase<RemoveStockRequest>
    {
        private readonly IMapper _mapper;
        private readonly IStockRepository _repository;

        public RemoveStockUseCase(IMapper mapper, IStockRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(RemoveStockRequest request)
        {
            _repository.Remove(request.Id);
        }
    }
}
