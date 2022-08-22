public class HttpMessageInvoker : IDisposable // TypeDefIndex: 5751
{	private HttpMessageHandler handler; // 0x10
	private readonly bool disposeHandler; // 0x18


	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

