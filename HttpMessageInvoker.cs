public class HttpMessageInvoker : IDisposable // TypeDefIndex: 5751
{
	private HttpMessageHandler handler; 
	private readonly bool disposeHandler; 


public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

public void Dispose() { }

protected virtual void Dispose(bool disposing) { }

public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

