using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class GetElementStockUseCase : IUseCase<GetElementStockRequest, GetElementStockResponse>
    {
        private readonly IMapper _mapper;
        private readonly IElementStockRepository _repository;

        public GetElementStockUseCase(IMapper mapper, IElementStockRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public GetElementStockResponse Execute(GetElementStockRequest request)
        {
            var output = _repository.Get(request.Id);
            return _mapper.Map<GetElementStockResponse>(output);
        }
    }
}
