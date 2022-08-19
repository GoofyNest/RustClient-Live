public sealed class SerializationCallback : MulticastDelegate // TypeDefIndex: 6007
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x180BAC0 Offset: 0x180AEC0 VA: 0x18180BAC0 Slot: 12
	public virtual void Invoke(object o, StreamingContext context) { }

	// RVA: 0x180BA30 Offset: 0x180AE30 VA: 0x18180BA30 Slot: 13
	public virtual IAsyncResult BeginInvoke(object o, StreamingContext context, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

