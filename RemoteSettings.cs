public static class RemoteSettings // TypeDefIndex: 4741
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xAA380 Offset: 0xA9780 VA: 0x1800AA380
[NativeHeaderAttribute] // RVA: 0xAA380 Offset: 0xA9780 VA: 0x1800AA380
public static class RemoteSettings // TypeDefIndex: 4741
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static RemoteSettings.UpdatedEventHandler Updated; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action BeforeFetchFromServer; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<bool, bool, int> Completed; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231BCD0 Offset: 0x231B0D0 VA: 0x18231BCD0
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231BC00 Offset: 0x231B000 VA: 0x18231BC00
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231BC50 Offset: 0x231B050 VA: 0x18231BC50
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }

}

public sealed class RemoteSettings.UpdatedEventHandler : MulticastDelegate // TypeDefIndex: 4742
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497060 Offset: 0x496460 VA: 0x180497060 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

