using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class GetFoodUseCase : IUseCase<GetFoodRequest, GetFoodResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFoodRepository _repository;

        public GetFoodUseCase(IMapper mapper, IFoodRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public GetFoodResponse Execute(GetFoodRequest request)
        {
            var output = _repository.Get(request.Id);
            return _mapper.Map<GetFoodResponse>(output);
        }
    }
}
