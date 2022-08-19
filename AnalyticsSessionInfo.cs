public static class AnalyticsSessionInfo // TypeDefIndex: 4748
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231BB20 Offset: 0x231AF20 VA: 0x18231BB20
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231BAC0 Offset: 0x231AEC0 VA: 0x18231BAC0
	internal static void CallIdentityTokenChanged(string token) { }

}

public sealed class AnalyticsSessionInfo.SessionStateChanged : MulticastDelegate // TypeDefIndex: 4749
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x231BF70 Offset: 0x231B370 VA: 0x18231BF70 Slot: 12
	public virtual void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	// RVA: 0x231BEB0 Offset: 0x231B2B0 VA: 0x18231BEB0 Slot: 13
	public virtual IAsyncResult BeginInvoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AnalyticsSessionInfo.IdentityTokenChanged : MulticastDelegate // TypeDefIndex: 4750
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497240 Offset: 0x496640 VA: 0x180497240 Slot: 12
	public virtual void Invoke(string token) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(string token, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

