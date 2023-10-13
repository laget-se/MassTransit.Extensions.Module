using System;

namespace MassTransit.Extensions.Module.Extensions
{
    public static class ModuleRegistrationExtensions
    {
        public static IBusRegistrationConfigurator RegisterModule<TModule>(this IBusRegistrationConfigurator configurator) where TModule : IModule, new()
        {
            if (configurator == null)
            {
                throw new ArgumentNullException(nameof(configurator));
            }

            var module = new TModule();
            module.Configure(configurator);

            return configurator;
        }
    }
}