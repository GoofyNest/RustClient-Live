public sealed class SerializationErrorCallback : MulticastDelegate // TypeDefIndex: 6008
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x180C0A0 Offset: 0x180B4A0 VA: 0x18180C0A0 Slot: 12
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x180C010 Offset: 0x180B410 VA: 0x18180C010 Slot: 13
	public virtual IAsyncResult BeginInvoke(object o, StreamingContext context, ErrorContext errorContext, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

