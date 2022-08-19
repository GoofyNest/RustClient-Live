public sealed class RegisteredWaitHandle : MarshalByRefObject // TypeDefIndex: 830
{	// Fields
	private WaitHandle _waitObject; // 0x18
	private WaitOrTimerCallback _callback; // 0x20
	private object _state; // 0x28
	private WaitHandle _finalEvent; // 0x30
	private ManualResetEvent _cancelEvent; // 0x38
	private TimeSpan _timeout; // 0x40
	private int _callsInProcess; // 0x48
	private bool _executeOnlyOnce; // 0x4C
	private bool _unregistered; // 0x4D

	// Methods

	// RVA: 0x14939E0 Offset: 0x1492DE0 VA: 0x1814939E0
	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1493520 Offset: 0x1492920 VA: 0x181493520
	internal void Wait(object state) { }

	// RVA: 0x14931F0 Offset: 0x14925F0 VA: 0x1814931F0
	private void DoCallBack(object timedOut) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x14933B0 Offset: 0x14927B0 VA: 0x1814933B0
	public bool Unregister(WaitHandle waitObject) { }

}

