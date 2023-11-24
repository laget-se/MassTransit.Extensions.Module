namespace MassTransit.Extensions.Module
{
    public abstract class Module
    {
        protected abstract void Configure(IBusRegistrationConfigurator configurator);
    }
}
