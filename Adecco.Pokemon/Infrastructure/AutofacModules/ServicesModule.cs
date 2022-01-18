using Adecco.Pokemon.Application.Services;
using Adecco.Pokemon.Application.Services.Contracts;
using Autofac;

namespace Adecco.Pokemon.Infrastructure.AutofacModules
{
    /// <summary>
    /// Services autofac module.
    /// </summary>
    public class ServicesModule : Module
    {
        /// <summary>
        /// Services module.
        /// </summary>
        public ServicesModule()
        {
        }

        /// <inheritdoc/>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PokemonApiService>()
                .As<IPokemonApiService>()
                .InstancePerLifetimeScope();
        }
    }
}
