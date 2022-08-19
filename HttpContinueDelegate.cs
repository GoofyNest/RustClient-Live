public sealed class HttpContinueDelegate : MulticastDelegate // TypeDefIndex: 2891
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDDD820 Offset: 0xDDCC20 VA: 0x180DDD820 Slot: 12
	public virtual void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }

	// RVA: 0x13364B0 Offset: 0x13358B0 VA: 0x1813364B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(int StatusCode, WebHeaderCollection httpHeaders, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

