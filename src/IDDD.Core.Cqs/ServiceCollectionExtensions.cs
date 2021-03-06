﻿using IDDD.Core.Cqs.Command;
using IDDD.Core.Cqs.Query;
using Microsoft.Extensions.DependencyInjection;

namespace IDDD.Core.Cqs
{
    public static class ServiceCollectionExtensions
        {

            public static IServiceCollection AddCqs(this IServiceCollection services)
            {
                services.AddTransient<IQueryProcessor, QueryProcessor>();
                services.AddTransient<ICommandDispatcher, CommandDispatcher>();
                return services;
            }
        }
}
