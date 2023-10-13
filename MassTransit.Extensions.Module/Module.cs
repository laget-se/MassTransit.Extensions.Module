using System;

namespace MassTransit.Extensions.Module
{
    public interface IModule
    {
        void Configure(IBusRegistrationConfigurator configurator);
    }

    public abstract class Module : IModule
    {
        public void Configure(IBusRegistrationConfigurator configurator)
        {
            if (configurator == null)
            {
                throw new ArgumentNullException(nameof(configurator));
            }
        }
    }
}
