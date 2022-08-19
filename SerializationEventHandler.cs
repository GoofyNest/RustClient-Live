internal sealed class SerializationEventHandler : MulticastDelegate // TypeDefIndex: 1024
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x129FFD0 Offset: 0x129F3D0 VA: 0x18129FFD0 Slot: 12
	public virtual void Invoke(StreamingContext context) { }

	// RVA: 0x129FF50 Offset: 0x129F350 VA: 0x18129FF50 Slot: 13
	public virtual IAsyncResult BeginInvoke(StreamingContext context, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

