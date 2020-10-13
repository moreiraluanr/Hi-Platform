using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class RemoveCleaningProductUseCase : IUseCase<RemoveCleaningProductRequest>
    {
        private readonly IMapper _mapper;
        private readonly ICleaningProductRepository _repository;

        public RemoveCleaningProductUseCase(IMapper mapper, ICleaningProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(RemoveCleaningProductRequest request)
        {
            _repository.Remove(request.Id);
        }
    }
}
