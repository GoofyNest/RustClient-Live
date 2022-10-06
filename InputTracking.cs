public static class InputTracking // TypeDefIndex: 4140
{

[RequiredByNativeCodeAttribute] 
[NativeHeaderAttribute] 
[NativeConditionalAttribute] 
[StaticAccessorAttribute] 
public static class InputTracking
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static Action<XRNodeState> trackingAcquired; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<XRNodeState> trackingLost; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<XRNodeState> nodeAdded; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<XRNodeState> nodeRemoved; 


	[RequiredByNativeCodeAttribute] 
	private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }

	private static void .cctor() { }

}

private enum InputTracking.TrackingStateEventType // TypeDefIndex: 4141
{
	public int value__; 
	public const InputTracking.TrackingStateEventType NodeAdded = 0;
	public const InputTracking.TrackingStateEventType NodeRemoved = 1;
	public const InputTracking.TrackingStateEventType TrackingAcquired = 2;
	public const InputTracking.TrackingStateEventType TrackingLost = 3;

}

