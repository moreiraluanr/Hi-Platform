using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class GetCleaningProductUseCase : IUseCase<GetCleaningProductRequest, GetCleaningProductResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICleaningProductRepository _repository;

        public GetCleaningProductUseCase(IMapper mapper, ICleaningProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public GetCleaningProductResponse Execute(GetCleaningProductRequest request)
        {
            return _mapper.Map<GetCleaningProductResponse>(_repository.Get(request.Id));
        }
    }
}
