public class InputDevices // TypeDefIndex: 4149
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<InputDevice> deviceConnected; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<InputDevice> deviceDisconnected; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<InputDevice> deviceConfigChanged; 


	[RequiredByNativeCodeAttribute] 
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }

}

