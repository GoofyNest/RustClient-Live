internal sealed class CompletionDelegate : MulticastDelegate // TypeDefIndex: 2957
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14243E0 Offset: 0x14237E0 VA: 0x1814243E0 Slot: 12
	public virtual void Invoke(byte[] responseBytes, Exception exception, object State) { }

	// RVA: 0x130A3E0 Offset: 0x13097E0 VA: 0x18130A3E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] responseBytes, Exception exception, object State, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

