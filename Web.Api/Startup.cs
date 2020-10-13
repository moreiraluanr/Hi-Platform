using AutoMapper;
using Mercado.Aplicattion.Mappers;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Infra.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace Web.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            #region UseCase
            services.AddTransient<IUseCase<InsertCleaningProductRequest>, InsertCleaningProductUseCase>();
            services.AddTransient<IUseCase<InsertElementStockRequest>, InsertElementStockUseCase>();
            services.AddTransient<IUseCase<InsertFoodRequest>, InsertFoodUseCase>();
            services.AddTransient<IUseCase<InsertMarketResearchRequest>, InsertMarketResearchUseCase>();
            services.AddTransient<IUseCase<InsertStockRequest>, InsertStockUseCase>();
            services.AddTransient<IUseCase<ListKitRequest, IEnumerable<ListKitResponse>>, ListKitUseCase>();
            #endregion

            #region Context 
            services.AddDbContext<CleaningProductContext>();
            services.AddDbContext<ElementStockContext>();
            services.AddDbContext<FoodContext>();
            services.AddDbContext<MarketResearchContext>();
            services.AddDbContext<StockContext>();
            #endregion

            #region AutoMapper
            var autoMapper = new MapperConfiguration(c => c.AddProfile<AutoMapProfiller>());
            services.AddSingleton(autoMapper.CreateMapper());
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors();
            app.UseEndpoints(e => e.MapControllers());
        }
    }
}
