﻿using BancosAPI.Dominio.Interfaces;
using BancosAPI.Infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace BancosAPI.Infra.IC.InversaoDeControle
{
    public static class InjecaoDependenciaRepositorios
    {

        /// <summary>
        /// Metodo de Extensão que será utilizado no ConfigureServices do Startup.cs
        /// Adciona as classe da camada InfraData
        /// services.AddRespositorios(Configuration);
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddRespositorios(this IServiceCollection services)
        {

            // Interface e os Repositories
            // Sistema.Domain.Interfaces e Sistema.InfraData.Repositories
            //***********************************************************************************
            services.AddScoped<IBancoRepositorio, BancoRepositorio>();

            return services;
        }
    }
}
