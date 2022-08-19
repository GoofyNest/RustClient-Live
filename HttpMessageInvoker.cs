public class HttpMessageInvoker : IDisposable // TypeDefIndex: 5751
{	// Fields
	private HttpMessageHandler handler; // 0x10
	private readonly bool disposeHandler; // 0x18

	// Methods

	// RVA: 0x10899F0 Offset: 0x1088DF0 VA: 0x1810899F0
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x1009F60 Offset: 0x1009360 VA: 0x181009F60 Slot: 4
	public void Dispose() { }

	// RVA: 0x1089990 Offset: 0x1088D90 VA: 0x181089990 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1085190 Offset: 0x1084590 VA: 0x181085190 Slot: 6
	public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

