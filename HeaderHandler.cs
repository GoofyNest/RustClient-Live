public sealed class HeaderHandler : MulticastDelegate // TypeDefIndex: 1238
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1472460 Offset: 0x1471860 VA: 0x181472460 Slot: 12
	public virtual object Invoke(Header[] headers) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(Header[] headers, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual object EndInvoke(IAsyncResult result) { }

}

