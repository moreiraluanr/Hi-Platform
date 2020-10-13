using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class RemoveElementStockUseCase : IUseCase<RemoveElementStockRequest>
    {
        private readonly IMapper _mapper;
        private readonly IElementStockRepository _repository;

        public RemoveElementStockUseCase(IMapper mapper, IElementStockRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(RemoveElementStockRequest request)
        {
            _repository.Remove(request.Id);
        }
    }
}
