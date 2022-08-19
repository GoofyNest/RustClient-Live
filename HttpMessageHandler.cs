public abstract class HttpMessageHandler : IDisposable // TypeDefIndex: 5750
{	// Methods

	// RVA: 0x1009F60 Offset: 0x1009360 VA: 0x181009F60 Slot: 4
	public void Dispose() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

