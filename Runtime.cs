public static class Runtime // TypeDefIndex: 4
{

private static void mono_runtime_install_handlers() { }

public static void InstallSignalHandlers() { }

private static void mono_runtime_cleanup_handlers() { }

public static void RemoveSignalHandlers() { }

public static string GetDisplayName() { }

private static string GetNativeStackTrace(Exception exception) { }

public static bool SetGCAllowSynchronousMajor(bool flag) { }

}

public static class Runtime // TypeDefIndex: 7162
{
	private static readonly NativeClient.CallbackProgress nogc_AntiCheatProgress; 
	private static readonly NativeClient.CallbackFinished nogc_AntiCheatEvent; 
	private static bool initializeCalled; 
	private static EventHandler<StateChangedEventArgs> onStateChanged; 
	private static EventHandler<LoadCompletedEventArgs> onLoadCompleted; 
	private static EventHandler<LoadProgressEventArgs> onProgress; 
	private static NetProtect _NetProtect; 
	[CompilerGeneratedAttribute] 
	private static bool <Initialized>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static IntegrityDescriptor <Integrity>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static HostValidationResult <HostValidation>k__BackingField; 

public static bool Initialized { get; set; }
private static IntegrityDescriptor Integrity { set; }
private static HostValidationResult HostValidation { set; }
public static INetProtect NetProtect { get; }


	[CompilerGeneratedAttribute] 
public static bool get_Initialized() { }

	[CompilerGeneratedAttribute] 
private static void set_Initialized(bool value) { }

	[CompilerGeneratedAttribute] 
private static void set_Integrity(IntegrityDescriptor value) { }

	[CompilerGeneratedAttribute] 
private static void set_HostValidation(HostValidationResult value) { }

public static void Initialize(EventHandler<StateChangedEventArgs> onStateChanged, EventHandler<LoadCompletedEventArgs> onCompleted, EventHandler<LoadProgressEventArgs> onProgress) { }

public static bool IsActive() { }

public static void Release() { }

public static void SetPlatformUserAuthTicket(string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

public static void ConnectionReset() { }

public static bool PopNetworkMessage(out byte[] MessageBuffer, out int MessageLength) { }

public static void PushNetworkMessage(byte[] MessageBuffer, int MessageLength) { }

public static void PollStatus() { }

public static INetProtect get_NetProtect() { }

	[MonoPInvokeCallbackAttribute] 
private static uint OnInternalProgress(uint Progress, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] 
private static void OnInternalEvent(LoadResult Result, string Message, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] 
private static uint OnIntegrityViolation(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] 
private static bool OnHostValidation(HostValidationResult Result, string Message, IntPtr CallbackParameter) { }

private static void .cctor() { }

}

private sealed class Runtime.<>c__DisplayClass19_0 // TypeDefIndex: 7163
{
	public EventHandler<LoadCompletedEventArgs> onCompleted; 


public void .ctor() { }

internal void <Initialize>b__0(object s, LoadCompletedEventArgs args) { }

}

