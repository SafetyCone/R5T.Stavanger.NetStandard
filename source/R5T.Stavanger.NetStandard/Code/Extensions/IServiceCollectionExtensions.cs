using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Stavanger.NetStandard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ShortcutOperator"/> implementation of <see cref="IShortcutOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddNetStandardShortcutOperator(this IServiceCollection services)
        {
            services.AddSingleton<IShortcutOperator, ShortcutOperator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ShortcutOperator"/> implementation of <see cref="IShortcutOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IShortcutOperator> AddNetStandardShortcutOperatorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IShortcutOperator>(() => services.AddNetStandardShortcutOperator());
            return serviceAction;
        }
    }
}
