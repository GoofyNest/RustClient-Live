public class WorldAnchor : Component // TypeDefIndex: 4774
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private WorldAnchor.OnTrackingChangedDelegate OnTrackingChanged; 


	[RequiredByNativeCodeAttribute] 
	private static void Internal_TriggerEventOnTrackingLost(WorldAnchor worldAnchor, bool located) { }

}

public sealed class WorldAnchor.OnTrackingChangedDelegate : MulticastDelegate // TypeDefIndex: 4775
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(WorldAnchor worldAnchor, bool located) { }

	public virtual IAsyncResult BeginInvoke(WorldAnchor worldAnchor, bool located, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

