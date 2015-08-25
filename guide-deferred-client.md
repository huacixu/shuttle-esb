---
title: Deferred Messages Guide
layout: guide
---
<script src="{{ site.baseurl }}/assets/js/guide-deferred.js"></script>
<script>shuttle.guideData.selectedItemName = 'guide-deferred-client'</script>
# Client

> Add a new `Console Application` to the solution called `Shuttle.Deferred.Client`.

![Deferred Client]({{ site.baseurl }}/assets/images/guide-deferred-client.png "Deferred Client")

> Install the `shuttle-esb-msmq` nuget package.

![Deferred Client - Nuget]({{ site.baseurl }}/assets/images/guide-deferred-client-nuget.png "Deferred Client - Nuget")

This will provide access to the Msmq `IQueue` implementation and also include the required dependencies.

> Add a reference to the `Shuttle.Deferred.Messages` project.

## Program

> Implement the main client code as follows:

``` c#
using System;
using Shuttle.ESB.Core;
using Shuttle.Deferred.Messages;

namespace Shuttle.Deferred.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var bus = ServiceBus.Create().Start())
			{
				string userName;

				while (!string.IsNullOrEmpty(userName = Console.ReadLine()))
				{
					bus.Send(new RegisterMemberCommand
					{
						UserName = userName
					}, c => c.Defer(DateTime.Now.AddSeconds(5)));
				}
			}
		}
	}
}
```

The message sent will have its `IgnoreTilleDate` set to 5 seconds into the future.  You can have a look at the [TransportMessage][transport-message] for more information on the message structure.

## App.config

> Create the shuttle configuration as follows:

``` xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<configSections>
		<section name='serviceBus' type="Shuttle.ESB.Core.ServiceBusSection, Shuttle.ESB.Core"/>
	</configSections>

	<serviceBus>
		<messageRoutes>
			<messageRoute uri="msmq://./shuttle-server-work">
				<add specification="StartsWith" value="Shuttle.Deferred.Messages" />
			</messageRoute>
		</messageRoutes>		
	</serviceBus>
	
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5" />
    </startup>
</configuration>
```

This tells shuttle that all messages that are sent and have a type name starting with `Shuttle.Deferred.Messages` should be sent to endpoint `msmq://./shuttle-server-work`.

Previous: [Messages][previous] | Next: [Server][next]

[previous]: {{ site.baseurl }}/guide-deferred-messages
[next]: {{ site.baseurl }}/guide-deferred-server
[transport-message]: {{ site.baseurl }}/transport-message