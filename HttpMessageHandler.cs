public abstract class HttpMessageHandler : IDisposable // TypeDefIndex: 5754
{

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

	protected void .ctor() { }

}

