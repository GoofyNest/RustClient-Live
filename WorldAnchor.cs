public class WorldAnchor : Component // TypeDefIndex: 4769
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private WorldAnchor.OnTrackingChangedDelegate OnTrackingChanged; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231D2F0 Offset: 0x231C6F0 VA: 0x18231D2F0
	private static void Internal_TriggerEventOnTrackingLost(WorldAnchor worldAnchor, bool located) { }

}

public sealed class WorldAnchor.OnTrackingChangedDelegate : MulticastDelegate // TypeDefIndex: 4770
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16181D0 Offset: 0x16175D0 VA: 0x1816181D0 Slot: 12
	public virtual void Invoke(WorldAnchor worldAnchor, bool located) { }

	// RVA: 0x231D260 Offset: 0x231C660 VA: 0x18231D260 Slot: 13
	public virtual IAsyncResult BeginInvoke(WorldAnchor worldAnchor, bool located, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

