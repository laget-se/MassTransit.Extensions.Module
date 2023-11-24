namespace MassTransit.Extensions.Module
{
    public abstract class Module
    {
        public abstract void Configure(IBusRegistrationConfigurator configurator);
    }
}
