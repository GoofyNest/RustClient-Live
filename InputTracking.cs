public static class InputTracking // TypeDefIndex: 4137
{
// Namespace: UnityEngine.XR
[RequiredByNativeCodeAttribute] // RVA: 0x94F80 Offset: 0x94380 VA: 0x180094F80
[NativeHeaderAttribute] // RVA: 0x94F80 Offset: 0x94380 VA: 0x180094F80
[NativeConditionalAttribute] // RVA: 0x94F80 Offset: 0x94380 VA: 0x180094F80
[StaticAccessorAttribute] // RVA: 0x94F80 Offset: 0x94380 VA: 0x180094F80
public static class InputTracking // TypeDefIndex: 4137
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action<XRNodeState> trackingAcquired; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<XRNodeState> trackingLost; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<XRNodeState> nodeAdded; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<XRNodeState> nodeRemoved; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F6080 Offset: 0x22F5480 VA: 0x1822F6080
	private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }

	// RVA: 0x22F62C0 Offset: 0x22F56C0 VA: 0x1822F62C0
	private static void .cctor() { }

}

private enum InputTracking.TrackingStateEventType // TypeDefIndex: 4138
{	// Fields
	public int value__; // 0x0
	public const InputTracking.TrackingStateEventType NodeAdded = 0;
	public const InputTracking.TrackingStateEventType NodeRemoved = 1;
	public const InputTracking.TrackingStateEventType TrackingAcquired = 2;
	public const InputTracking.TrackingStateEventType TrackingLost = 3;

}

