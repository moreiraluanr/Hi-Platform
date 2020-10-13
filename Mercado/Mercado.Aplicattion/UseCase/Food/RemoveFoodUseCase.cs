using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class RemoveFoodUseCase : IUseCase<RemoveFoodRequest>
    {
        private readonly IMapper _mapper;
        private readonly IFoodRepository _repository;

        public RemoveFoodUseCase(IMapper mapper, IFoodRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(RemoveFoodRequest request)
        {
            _repository.Remove(request.Id);
        }
    }
}
