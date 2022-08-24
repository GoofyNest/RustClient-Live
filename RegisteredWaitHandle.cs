public sealed class RegisteredWaitHandle : MarshalByRefObject // TypeDefIndex: 830
{
	private WaitHandle _waitObject; 
	private WaitOrTimerCallback _callback; 
	private object _state; 
	private WaitHandle _finalEvent; 
	private ManualResetEvent _cancelEvent; 
	private TimeSpan _timeout; 
	private int _callsInProcess; 
	private bool _executeOnlyOnce; 
	private bool _unregistered; 


internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

internal void Wait(object state) { }

private void DoCallBack(object timedOut) { }

	[ComVisibleAttribute] 
public bool Unregister(WaitHandle waitObject) { }

}

