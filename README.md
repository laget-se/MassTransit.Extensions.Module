﻿# MassTransit.Extensions.Module
Autofac inspired `Module` structure for `MassTransit` that is used by calling `.RegisterModule<T>()` in `.AddMassTransit`.

## Usage
```c#
public class Program
{
    private static async Task Main()
    {
        await Host.CreateDefaultBuilder()
            .ConfigureContainer<ContainerBuilder>((context, builder) =>
            {
            })
            .ConfigureServices((context, services) =>
            {
                services.AddOptions<AzureServiceBusTransportOptions>().Configure(options =>
                {
                    options.ConnectionString = context.Configuration.GetValue<string>("AzureServiceBusTransportOptions:ConnectionString");
                });
                services.AddMassTransit(x =>
                {
                    x.RegisterModule<SomeModule>();

                    x.SetKebabCaseEndpointNameFormatter();
                    x.UsingAzureServiceBus((context, cfg) =>
                    {
                        cfg.ConfigureEndpoints(context);
                    });
                });
            })
            .Build()
            .RunAsync();
    }
}
```
