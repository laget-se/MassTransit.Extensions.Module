using System;

namespace MassTransit.Extensions.Module
{
    public abstract class Module
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
