public class WorldAnchor : Component // TypeDefIndex: 4769
{	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private WorldAnchor.OnTrackingChangedDelegate OnTrackingChanged; // 0x18


	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void Internal_TriggerEventOnTrackingLost(WorldAnchor worldAnchor, bool located) { }

}

public sealed class WorldAnchor.OnTrackingChangedDelegate : MulticastDelegate // TypeDefIndex: 4770
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(WorldAnchor worldAnchor, bool located) { }

	public virtual IAsyncResult BeginInvoke(WorldAnchor worldAnchor, bool located, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

