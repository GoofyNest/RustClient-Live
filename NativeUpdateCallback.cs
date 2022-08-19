internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 4520
{
// Namespace: UnityEngineInternal.Input
internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 4520
	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDDD820 Offset: 0xDDCC20 VA: 0x180DDD820 Slot: 12
	public virtual void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

	// RVA: 0x231CC40 Offset: 0x231C040 VA: 0x18231CC40 Slot: 13
	public virtual IAsyncResult BeginInvoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

