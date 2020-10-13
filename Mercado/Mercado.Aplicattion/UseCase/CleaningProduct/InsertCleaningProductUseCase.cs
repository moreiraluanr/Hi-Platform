using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Entities;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class InsertCleaningProductUseCase : IUseCase<InsertCleaningProductRequest>
    {
        private readonly IMapper _mapper;
        private readonly ICleaningProductRepository _repository;

        public InsertCleaningProductUseCase(IMapper mapper, ICleaningProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(InsertCleaningProductRequest request)
        {
            var input = _mapper.Map<CleaningProduct>(request);
            _repository.Insert(input);
        }
    }
}
