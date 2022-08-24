public static class AnalyticsSessionInfo // TypeDefIndex: 4748
{
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged; 


	[RequiredByNativeCodeAttribute] 
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	[RequiredByNativeCodeAttribute] 
	internal static void CallIdentityTokenChanged(string token) { }

}

public sealed class AnalyticsSessionInfo.SessionStateChanged : MulticastDelegate // TypeDefIndex: 4749
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	public virtual IAsyncResult BeginInvoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AnalyticsSessionInfo.IdentityTokenChanged : MulticastDelegate // TypeDefIndex: 4750
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string token) { }

	public virtual IAsyncResult BeginInvoke(string token, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

