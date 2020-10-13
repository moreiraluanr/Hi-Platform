using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Entities;
using Mercado.Domain.Repository;

namespace Mercado.Aplicattion.UseCase
{
    public class AlterFoodUseCase : IUseCase<AlterFoodRequest>
    {
        private readonly IMapper _mapper;
        private readonly IFoodRepository _repository;

        public AlterFoodUseCase(IMapper mapper, IFoodRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Execute(AlterFoodRequest request)
        {
            var input = _mapper.Map<Food>(request);
            _repository.Alter(input);
        }
    }
}
