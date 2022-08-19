public sealed class WaitOrTimerCallback : MulticastDelegate // TypeDefIndex: 807
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16181D0 Offset: 0x16175D0 VA: 0x1816181D0 Slot: 12
	public virtual void Invoke(object state, bool timedOut) { }

	// RVA: 0x1618140 Offset: 0x1617540 VA: 0x181618140 Slot: 13
	public virtual IAsyncResult BeginInvoke(object state, bool timedOut, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

