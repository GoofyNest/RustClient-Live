public static class RemoteSettings // TypeDefIndex: 4741
{

[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
public static class RemoteSettings 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static RemoteSettings.UpdatedEventHandler Updated; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static Action BeforeFetchFromServer; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<bool, bool, int> Completed; 


	[RequiredByNativeCodeAttribute] 
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	[RequiredByNativeCodeAttribute] 
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[RequiredByNativeCodeAttribute] 
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }

}

public sealed class RemoteSettings.UpdatedEventHandler : MulticastDelegate // TypeDefIndex: 4742
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

