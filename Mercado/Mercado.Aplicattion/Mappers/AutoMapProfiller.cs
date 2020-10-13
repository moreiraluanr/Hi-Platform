using AutoMapper;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.Model.Stock.Request;
using Mercado.Domain.Entities;

namespace Mercado.Aplicattion.Mappers
{
    public class AutoMapProfiller : Profile
    {
        public AutoMapProfiller()
        {
            #region CleaningProduct
            CreateMap<InsertCleaningProductRequest, CleaningProduct>();
            CreateMap<AlterCleaningProductRequest, CleaningProduct>();
            CreateMap<CleaningProduct, GetCleaningProductResponse>();
            CreateMap<CleaningProduct, ListCleaningProductResponse>();
            #endregion

            #region ElementStock
            CreateMap<InsertElementStockRequest, ElementStock>();
            CreateMap<AlterElementStockRequest, ElementStock>();
            CreateMap<ElementStock, GetElementStockResponse>();
            CreateMap<ElementStock, ListElementStockResponse>();
            #endregion

            #region Food
            CreateMap<InsertFoodRequest, Food>();
            CreateMap<AlterFoodRequest, Food>();
            CreateMap<Food, GetFoodResponse>();
            CreateMap<Food, ListFoodResponse>();
            #endregion

            #region MarketReasearch
            CreateMap<InsertMarketResearchRequest, MarketResearch>();
            CreateMap<AlterMarketResearchRequest, MarketResearch>();
            CreateMap<MarketResearch, GetMarketResearchResponse>();
            CreateMap<MarketResearch, ListMarketResearchResponse>();
            #endregion

            #region Stock
            CreateMap<InsertStockRequest, Stock>();
            CreateMap<AlterStockRequest, Stock>();
            CreateMap<Stock, GetStockResponse>();
            CreateMap<Stock, ListStockResponse>();
            #endregion
        }
    }
}
