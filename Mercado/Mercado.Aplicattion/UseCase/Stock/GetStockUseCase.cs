using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class GetStockUseCase : IUseCase<GetStockRequest, GetStockResponse>
    {
        private readonly IMapper _mapper;
        private readonly IStockRepository _repository;

        public GetStockUseCase(IMapper mapper, IStockRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public GetStockResponse Execute(GetStockRequest request)
        {
            var output = _repository.Get(request.Id);
            return _mapper.Map<GetStockResponse>(output);
        }
    }
}
