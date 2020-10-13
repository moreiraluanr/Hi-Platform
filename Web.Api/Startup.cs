using AutoMapper;
using Mercado.Aplicattion.Mappers;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase;
using Mercado.Aplicattion.UseCase.Interface;
using Mercado.Domain.Repository;
using Mercado.Domain.Repository.Abstract;
using Mercado.Infra.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;

namespace Web.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            #region Repository
            services.AddTransient<ICleaningProductRepository, CleaningProductRepository>();
            services.AddTransient<IElementStockRepository, ElementStockRepository>();
            services.AddTransient<IFoodRepository, FoodRepository>();
            services.AddTransient<IStockRepository, StockRepository>();
            services.AddTransient<IMarketResearchRepository, MarketResearchRespository>();
            #endregion

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

            services.AddMvc();

            #region Swagger
            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Hi Platform",
                        Version = "v1",
                        Description = "Documentação api Hi Platform",
                        Contact = new OpenApiContact
                        {
                            Name = "Luan Moreira",
                            Url = new Uri("https://github.com/moreiraluanr/Hi-Platform")
                        }
                    });
            });
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
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=ElementStock}/{action=Insert}/{id?}");
            });

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hi Platform V1");
            });
        }
    }
}
