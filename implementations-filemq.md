---
title: FileMQ Extensions
layout: api
---
# FileMQ

<div class="nuget-badge">
	<p>
		<code>Install-Package Shuttle.Esb.FileMQ</code>
	</p>
</div>

This `IQueue` implementation makes use of a folder as a queue with the messages saved as file.  It is provided mainly as a backup mechanism.

## Configuration

The queue configuration is part of the specified uri, e.g.:

```xml
    <inbox
      workQueueUri="filemq://{directory-path}"
	  .
	  .
	  .
    />
```
