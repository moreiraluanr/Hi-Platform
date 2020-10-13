using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Mercado.Aplicattion.UseCase
{
    public class ListKitUseCase : IUseCase<ListKitRequest, IEnumerable<ListKitResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IFoodRepository _foodRepository;
        private readonly ICleaningProductRepository _cleaningProductRepository;
        private readonly IMarketResearchRepository _marketResearchRepository;
        private readonly IElementStockRepository _elementStockRepository;

        public ListKitUseCase(
            IMapper mapper, 
            IFoodRepository foodRepository, 
            ICleaningProductRepository cleaningProductRepository, 
            IMarketResearchRepository marketResearchRepository, 
            IElementStockRepository elementStockRepository)
        {
            _mapper = mapper;
            _foodRepository = foodRepository;
            _cleaningProductRepository = cleaningProductRepository;
            _marketResearchRepository = marketResearchRepository;
            _elementStockRepository = elementStockRepository;
        }

        public IEnumerable<ListKitResponse> Execute(ListKitRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
