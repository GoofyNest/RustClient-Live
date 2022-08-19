public sealed class ResolveEventHandler : MulticastDelegate // TypeDefIndex: 387
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFE6720 Offset: 0xFE5B20 VA: 0x180FE6720 Slot: 12
	public virtual Assembly Invoke(object sender, ResolveEventArgs args) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, ResolveEventArgs args, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual Assembly EndInvoke(IAsyncResult result) { }

}

