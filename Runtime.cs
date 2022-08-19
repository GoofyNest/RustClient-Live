public static class Runtime // TypeDefIndex: 4
{	// Methods

	// RVA: 0x16452F0 Offset: 0x16446F0 VA: 0x1816452F0
	private static void mono_runtime_install_handlers() { }

	// RVA: 0x16452F0 Offset: 0x16446F0 VA: 0x1816452F0
	public static void InstallSignalHandlers() { }

	// RVA: 0x1645300 Offset: 0x1644700 VA: 0x181645300
	private static void mono_runtime_cleanup_handlers() { }

	// RVA: 0x1645300 Offset: 0x1644700 VA: 0x181645300
	public static void RemoveSignalHandlers() { }

	// RVA: 0x16452E0 Offset: 0x16446E0 VA: 0x1816452E0
	public static string GetDisplayName() { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90
	private static string GetNativeStackTrace(Exception exception) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public static bool SetGCAllowSynchronousMajor(bool flag) { }

}

public static class Runtime // TypeDefIndex: 7162
{	// Fields
	private static readonly NativeClient.CallbackProgress nogc_AntiCheatProgress; // 0x0
	private static readonly NativeClient.CallbackFinished nogc_AntiCheatEvent; // 0x8
	private static bool initializeCalled; // 0x10
	private static EventHandler<StateChangedEventArgs> onStateChanged; // 0x18
	private static EventHandler<LoadCompletedEventArgs> onLoadCompleted; // 0x20
	private static EventHandler<LoadProgressEventArgs> onProgress; // 0x28
	private static NetProtect _NetProtect; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <Initialized>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static IntegrityDescriptor <Integrity>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static HostValidationResult <HostValidation>k__BackingField; // 0x50

	// Properties
	public static bool Initialized { get; set; }
	private static IntegrityDescriptor Integrity { set; }
	private static HostValidationResult HostValidation { set; }
	public static INetProtect NetProtect { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22E2EE0 Offset: 0x22E22E0 VA: 0x1822E2EE0
	public static bool get_Initialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22E3000 Offset: 0x22E2400 VA: 0x1822E3000
	private static void set_Initialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22E3060 Offset: 0x22E2460 VA: 0x1822E3060
	private static void set_Integrity(IntegrityDescriptor value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22E2FA0 Offset: 0x22E23A0 VA: 0x1822E2FA0
	private static void set_HostValidation(HostValidationResult value) { }

	// RVA: 0x22E1B50 Offset: 0x22E0F50 VA: 0x1822E1B50
	public static void Initialize(EventHandler<StateChangedEventArgs> onStateChanged, EventHandler<LoadCompletedEventArgs> onCompleted, EventHandler<LoadProgressEventArgs> onProgress) { }

	// RVA: 0x22E1DE0 Offset: 0x22E11E0 VA: 0x1822E1DE0
	public static bool IsActive() { }

	// RVA: 0x22E2B30 Offset: 0x22E1F30 VA: 0x1822E2B30
	public static void Release() { }

	// RVA: 0x22E2CA0 Offset: 0x22E20A0 VA: 0x1822E2CA0
	public static void SetPlatformUserAuthTicket(string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E1A90 Offset: 0x22E0E90 VA: 0x1822E1A90
	public static void ConnectionReset() { }

	// RVA: 0x22E2850 Offset: 0x22E1C50 VA: 0x1822E2850
	public static bool PopNetworkMessage(out byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E29D0 Offset: 0x22E1DD0 VA: 0x1822E29D0
	public static void PushNetworkMessage(byte[] MessageBuffer, int MessageLength) { }

	// RVA: 0x22E26E0 Offset: 0x22E1AE0 VA: 0x1822E26E0
	public static void PollStatus() { }

	// RVA: 0x22E2F40 Offset: 0x22E2340 VA: 0x1822E2F40
	public static INetProtect get_NetProtect() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22E25C0 Offset: 0x22E19C0 VA: 0x1822E25C0
	private static uint OnInternalProgress(uint Progress, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22E23A0 Offset: 0x22E17A0 VA: 0x1822E23A0
	private static void OnInternalEvent(LoadResult Result, string Message, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22E2100 Offset: 0x22E1500 VA: 0x1822E2100
	private static uint OnIntegrityViolation(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22E1E90 Offset: 0x22E1290 VA: 0x1822E1E90
	private static bool OnHostValidation(HostValidationResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E2E00 Offset: 0x22E2200 VA: 0x1822E2E00
	private static void .cctor() { }

}

private sealed class Runtime.<>c__DisplayClass19_0 // TypeDefIndex: 7163
{	// Fields
	public EventHandler<LoadCompletedEventArgs> onCompleted; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22E3150 Offset: 0x22E2550 VA: 0x1822E3150
	internal void <Initialize>b__0(object s, LoadCompletedEventArgs args) { }

}

